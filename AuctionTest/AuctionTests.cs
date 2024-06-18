using CarAuction.Models;

namespace AuctionTest
{
    public class UnitTests
    {
        [Fact]
        public void TestConstructorCallClasses()
        {
            // vehicle classes
            var vehicle = new Vehicle(1, "new car", 100000, "AB12345", 2000, true, "B", 2.0, 12.4, "Souls", "yes");
            Assert.NotNull(vehicle);
            var passengerCar = new PassengerCar(1, "new car", 100000, "AB12345", 2000, true, "B", 2.0, 12.4, "Souls", "yes", 3, "1x2x3");
            Assert.NotNull(passengerCar);
            var privateVehicle = new PrivateVehicle(1, "new car", 100000, "AB12345", 2000, true, "B", 2.0, 12.4, "Souls", "yes", 3, "1x2x3", true);
            Assert.NotNull(privateVehicle);
            var commercialVehicle = new CommercialVehicle(1, "new car", 100000, "AB12345", true, "B", 2.0, 12.4, "A", 3, "1x2x3", true, "Mercer", "The Good One", 2000, "Souls", 12, 1, true);
            Assert.NotNull(commercialVehicle);
            var heavyVehicle = new HeavyVehicle(1, "new car", 100000, "AB12345", 2000, true, "B", 2.0, 12.4, "Souls", "yes", 3, 4, 1, 9);
            Assert.NotNull(heavyVehicle);
            var bus = new Bus(1, "new car", 100000, "AB12345", 2000, true, "B", 2.0, 12.4, "Souls", "yes", 3, 4, 1, 9, 5, 0);
            Assert.NotNull(bus);
            var truck = new Truck(1, "new car", 100000, "AB12345", 2000, true, "B", 2.0, 12.4, "Souls", "yes", 3, 4, 1, 9, 50);
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
            var vehicle = new Vehicle(1, "Car", 1000, "ABC123", 2020, true, "B", 2.0, 20, "Gasoline", "A");

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
            var passengerCar = new PassengerCar(1, "Car", 1000, "ABC123", 2020, true, "B", 2.0, 20, "Gasoline", "B", 5, "1x2x3");

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
            Assert.Equal("B", passengerCar.EnergyType);
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
            PassengerCar passengerCar = new PassengerCar(1, "Car", 1000, "ABC123", 2020, true, "B", 2.0, 20, "Gasoline", "B", 5, "1x2x3");

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
            PassengerCar passengerCar = new PassengerCar(1, "Car", 1000, "ABC123", 2020, true, "B", 2.0, 20, "Gasoline", "B", 5, "1x2x3");

            passengerCar.EngineSize = engineSizeInL;

            Assert.Equal(engineSizeInL, passengerCar.EngineSize);
        }
    }
}