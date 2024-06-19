using CarAuction.Models;
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
        private MyProfileViewModel user;
        public HomePageViewModel(MainWindowViewModel main, MyProfileViewModel user)
        {
            this.main = main;
            this.user = user;
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
            main.SetViewModel(new SetForSaleViewModel(main, user, new Vehicle()));
        }

        public void MyProfile()
        {
            main.SetViewModel(new MyProfileViewModel(main, user));
        }

        public void BidHistory()
        {
            main.SetViewModel(new BidHistoryViewModel(main, user));
        }

        public void BuyerOfAuction()
        {
            main.SetViewModel(new BuyerOfAuctionViewModel(main, user));
        }

        public void SellerOfAuction()
        {
            main.SetViewModel(new SellerOfAuctionViewModel(main, user));
        }
    }
}
