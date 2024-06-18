using CarAuction.Models;

namespace AuctionTest
{
    public class UnitTests
    {
        [Fact]
        public void TestCallClasses()
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
    }
}