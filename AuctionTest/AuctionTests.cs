using CarAuction.Models;
using Microsoft.Data.SqlClient;
using Xunit;
using Moq;
using System.Data;
using Microsoft.Data.SqlClient;
using CarAuction.ConnectionHandlers;

namespace AuctionTest
{
    public class UnitTests
    {
        [Fact]
        public void TestConstructorCallClasses()
        {
            // vehicle classes
            var vehicle = new Vehicle(1, "new car", 100000, "AB12345", 2000, true, "B", 2.0, 12.4, "Souls");
            Assert.NotNull(vehicle);
            var passengerCar = new PassengerCar(1, "new car", 100000, "AB12345", 2000, true, "B", 2.0, 12.4, "Souls", 3, "1x2x3");
            Assert.NotNull(passengerCar);
            var privateVehicle = new PrivateVehicle(1, "new car", 100000, "AB12345", 2000, true, "B", 2.0, 12.4, "Souls", 3, "1x2x3", true);
            Assert.NotNull(privateVehicle);
            var commercialVehicle = new CommercialVehicle(1, "new car", 100000, "AB12345", true, "B", 2.0, 12.4, 3, "1x2x3", true, "Mercer", "The Good One", 2000, "Souls", 12, 1, true);
            Assert.NotNull(commercialVehicle);
            var heavyVehicle = new HeavyVehicle(1, "new car", 100000, "AB12345", 2000, true, "B", 2.0, 12.4, "Souls", 3, 4, 1, 9);
            Assert.NotNull(heavyVehicle);
            var bus = new Bus(1, "new car", 100000, "AB12345", 2000, true, "B", 2.0, 12.4, "Souls", 3, 4, 1, 9, 5, 0);
            Assert.NotNull(bus);
            var truck = new Truck(1, "new car", 100000, "AB12345", 2000, true, "B", 2.0, 12.4, "Souls", 3, 4, 1, 9, 50);
            Assert.NotNull(truck);

            // users
            Assert.NotNull(commercialVehicle);
            var user = new User(1, "Bob", "a@a.dk", "wery saife");
            Assert.NotNull(user);
            var privateUser = new PrivateUser(1, "Bob", "a@a.dk", "wery saife", "1234");
            Assert.NotNull(privateUser);
            var corporateUser = new CorporateUser(1, "Bob", "a@a.dk", "wery saife", 1, 12431243);
            Assert.NotNull(corporateUser);

            // auction
            var auction = new Auction(1, 1, 1, 1, 1.0);
            Assert.NotNull(auction);
        }
        
        [Fact]
        public void TestVehicleClass()
        {
            var vehicle = new Vehicle(1, "Car", 1000, "ABC123", 2020, true, "B", 2.0, 20, "Gasoline");

            Assert.Equal(1, vehicle.Id);
            Assert.Equal("Car", vehicle.Name);
            Assert.Equal(1000, vehicle.Km);
            Assert.Equal("ABC123", vehicle.Regnr);
            Assert.Equal(2020, vehicle.Year);
            Assert.True(vehicle.TowingHook);
            Assert.Equal("B", vehicle.DriversLicenseType);
            Assert.Equal(2.0, vehicle.EngineSize);
            Assert.Equal(20, vehicle.KmPerLiter);
            Assert.Equal("Gasoline", vehicle.FuelType);
            Assert.Equal("A", vehicle.EnergyType);
        }
        [Fact]
        public void TestPassengerCarClass()
        {
            var passengerCar = new PassengerCar(1, "Car", 1000, "ABC123", 2020, true, "B", 2.0, 20, "Gasoline", 5, "1x2x3");

            Assert.Equal(1, passengerCar.Id);
            Assert.Equal("Car", passengerCar.Name);
            Assert.Equal(1000, passengerCar.Km);
            Assert.Equal("ABC123", passengerCar.Regnr);
            Assert.Equal(2020, passengerCar.Year);
            Assert.True(passengerCar.TowingHook);
            Assert.Equal("B", passengerCar.DriversLicenseType);
            Assert.Equal(2.0, passengerCar.EngineSize);
            Assert.Equal(20, passengerCar.KmPerLiter);
            Assert.Equal("Gasoline", passengerCar.FuelType);
            Assert.Equal(5, passengerCar.Seats);
            Assert.Equal("1x2x3", passengerCar.Dimensions);
        }
        [Theory]
        [InlineData(0)]
        [InlineData(0.5)]
        [InlineData(0.6)]
        [InlineData(10.1)]
        [InlineData(20)]
        public void TestPassengerCarMotorSizeOutOfRange(double engineSizeInL)
        {
            PassengerCar passengerCar = new PassengerCar(1, "Car", 1000, "ABC123", 2020, true, "B", 2.0, 20, "Gasoline", 5, "1x2x3");

            Assert.Throws<ArgumentOutOfRangeException>(() => passengerCar.EngineSize = engineSizeInL);

        }
        [Theory]
        [InlineData(0.7)]
        [InlineData(1.7)]
        [InlineData(2.0)]
        [InlineData(10.0)]
        [InlineData(5.2)]
        public void TestPassengerCarMotorSizeInRange(double engineSizeInL)
        {
            PassengerCar passengerCar = new PassengerCar(1, "Car", 1000, "ABC123", 2020, true, "B", 2.0, 20, "Gasoline", 5, "1x2x3");

            passengerCar.EngineSize = engineSizeInL;

            Assert.Equal(engineSizeInL, passengerCar.EngineSize);
        }
        [Theory]
        [InlineData("Gasoline", 20, 2020, "A")]
        [InlineData("Diesel", 20, 2020, "B")]
        [InlineData("Hydrogen", 20, 2020, "A")]
        [InlineData("Electricity", 20, 2020, "A")]
        [InlineData("Gasoline", 12, 2005, "C")]
        [InlineData("Diesel", 12, 2005, "D")]
        [InlineData("Gasoline", 12, 2015, "C")]
        public void TestEnergyClassCalculation(string fuelType, double kmPerLiter, int year, string expectedEnergyClass)
        {
            Vehicle vehicle = new Vehicle(1, "Car", 1000, "ABC123", year, true, "B", 2.0, kmPerLiter, fuelType);

            Assert.Equal(expectedEnergyClass, vehicle.EnergyType);
        }
        
        public class DatabaseTests
        {
            [Fact]
            public void Insert_WithValidParameters_ExecutesNonQuery()
            {
                // Arrange
                var mockConnection = new Mock<SqlConnection>();
                var mockCommand = new Mock<SqlCommand>();
                mockCommand.Setup(m => m.ExecuteNonQuery()).Returns(1);
                mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);
                Database.ConnectionString = mockConnection.Object.ConnectionString;

                // Act
                Database.Insert("TestTable", new string[] { "Column1", "Column2" },
                    new string[] { "Value1", "Value2" });

                // Assert
                mockCommand.Verify(m => m.ExecuteNonQuery(), Times.Once);
            }

            [Fact]
            public void Update_WithValidParameters_ExecutesNonQuery()
            {
                var mockConnection = new Mock<SqlConnection>();
                var mockCommand = new Mock<SqlCommand>();
                mockCommand.Setup(m => m.ExecuteNonQuery()).Returns(1);
                mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);
                Database.ConnectionString = mockConnection.Object.ConnectionString;

                Database.Update("TestTable", new string[] { "Column1", "Column2" }, new string[] { "Value1", "Value2" },
                    "Condition");

                mockCommand.Verify(m => m.ExecuteNonQuery(), Times.Once);
            }

            [Fact]
            public void Delete_WithValidParameters_ExecutesNonQuery()
            {
                var mockConnection = new Mock<SqlConnection>();
                var mockCommand = new Mock<SqlCommand>();
                mockCommand.Setup(m => m.ExecuteNonQuery()).Returns(1);
                mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);
                Database.ConnectionString = mockConnection.Object.ConnectionString;

                Database.Delete("TestTable", "Condition");

                mockCommand.Verify(m => m.ExecuteNonQuery(), Times.Once);
            }

            [Fact]
            public void Select_WithValidParameters_ReturnsDataReader()
            {
                var mockConnection = new Mock<SqlConnection>();
                var mockCommand = new Mock<SqlCommand>();
                var mockReader = new Mock<SqlDataReader>();
                mockCommand.Setup(m => m.ExecuteReader()).Returns(mockReader.Object);
                mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);
                Database.ConnectionString = mockConnection.Object.ConnectionString;

                var result = Database.Select("TestTable", new string[] { "Column1", "Column2" }, "Condition");

                Assert.NotNull(result);
            }

            [Fact]
            public void SelectAll_WithValidParameters_ReturnsDataReader()
            {
                var mockConnection = new Mock<SqlConnection>();
                var mockCommand = new Mock<SqlCommand>();
                var mockReader = new Mock<SqlDataReader>();
                mockCommand.Setup(m => m.ExecuteReader()).Returns(mockReader.Object);
                mockConnection.Setup(m => m.CreateCommand()).Returns(mockCommand.Object);
                Database.ConnectionString = mockConnection.Object.ConnectionString;

                var result = Database.SelectAll("TestTable");

                Assert.NotNull(result);
            }
        }
    }
}