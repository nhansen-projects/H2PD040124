using AuctionTest;
using CarAuction;
using CarAuction.ViewModels;

namespace AuctionTest
{
    public class ViewTests
    {
        IDatabaseRepository _databaseRepository = new UnitTestDatabaseRepository();
        [Fact]
        public async Task TestCreateViewModel()
        {
            var createViewModel = new CreateViewModel();
            createViewModel.UserNameInput = "User";
            createViewModel.PasswordInput = "Password";
            createViewModel.PasswordAgainInput = "Password";

            Assert.Equal("User", createViewModel.UserNameInput);
            Assert.Equal("Password", createViewModel.PasswordInput);
            Assert.Equal("Password", createViewModel.PasswordAgainInput);
        }
    }
}
