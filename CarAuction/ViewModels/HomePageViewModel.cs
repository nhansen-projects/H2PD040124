using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuction.ViewModels
{
    internal class HomePageViewModel : ViewModelBase
    {

        private MainWindowViewModel main;
        private LoginViewModel login;
        public HomePageViewModel(MainWindowViewModel main, LoginViewModel login)
        {
            this.main = main;
            this.login = login;
        }

        public HomePageViewModel()
        {

        }


        public void LoginView()
        {
            main.SetViewModel(new LoginViewModel(main));
        }

        public void SetForSale()
        {
            main.SetViewModel(new SetForSaleViewModel(main, login));
        }

        public void MyProfile()
        {
            main.SetViewModel(new MyProfileViewModel(main, login));
        }

        public void BidHistory()
        {
            main.SetViewModel(new BidHistoryViewModel(main, login));
        }

        public void BuyerOfAuction()
        {
            main.SetViewModel(new BuyerOfAuctionViewModel(main, login));
        }

        public void SellerOfAuction()
        {
            main.SetViewModel(new SellerOfAuctionViewModel(main, login));
        }
    }
}
