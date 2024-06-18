using CarAuction.Models;

namespace AuctionTest
{
    public class UnitTests
    {
        [Fact]
        public void TestConstructorCallClasses()
        {
            // vehicle classes
            var vehicle = new Vehicle();
            Assert.NotNull(vehicle);
            var passengerCar = new PassengerCar();
            Assert.NotNull(passengerCar);
            var privateVehicle = new PrivateVehicle();
            Assert.NotNull(privateVehicle);
            var commercialVehicle = new CommercialVehicle();
            var heavyVehicle = new HeavyVehicle();
            Assert.NotNull(heavyVehicle);
            var bus = new Bus();
            Assert.NotNull(bus);
            var truck = new Truck();
            Assert.NotNull(truck);

            // users
            Assert.NotNull(commercialVehicle);
            var user = new User();
            Assert.NotNull(user);
            var privateUser = new PrivateUser();
            Assert.NotNull(privateUser);
            var corporateUser = new CorporateUser();
            Assert.NotNull(corporateUser);

            // auction
            var auction = new Auction(1, 1, 1, 1, 1.0);
            Assert.NotNull(auction);
        }

        [Fact]
        public void TestVehicleClass()
        {
            var vehicle = new Vehicle();
            vehicle.Id = 1;
            vehicle.Name = "Car";
            vehicle.Km = 1000;
            vehicle.Regnr = "ABC123";
            vehicle.Year = 2020;
            vehicle.TowingHook = true;
            vehicle.DriversLicenseType = "B";
            vehicle.EngineSize = 2.0;
            vehicle.KmPerLiter = 20;
            vehicle.FuelType = "Gasoline";
            vehicle.EnergyType = "A";

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
            var passengerCar = new PassengerCar();
            passengerCar.Id = 1;
            passengerCar.Name = "Car";
            passengerCar.Km = 1000;
            passengerCar.Regnr = "ABC123";
            passengerCar.Year = 2020;
            passengerCar.TowingHook = true;
            passengerCar.DriversLicenseType = "B";
            passengerCar.EngineSize = 2.0;
            passengerCar.KmPerLiter = 20;
            passengerCar.FuelType = "Gasoline";
            passengerCar.EnergyType = "B";
            passengerCar.Seats = 5;
            passengerCar.Dimensions = "4x4";

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
            Assert.Equal("4x4", passengerCar.Dimensions);
        }
        [Theory]
        [InlineData(0)]
        [InlineData(0.5)]
        [InlineData(0.6)]
        [InlineData(10.1)]
        [InlineData(20)]
        public void TestPassengerCarMotorSizeOutOfRange(double engineSizeInL)
        {
            PassengerCar passengerCar = new PassengerCar();

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
            PassengerCar passengerCar = new PassengerCar();

            passengerCar.EngineSize = engineSizeInL;

            Assert.Equal(engineSizeInL, passengerCar.EngineSize);
        }
    }
}