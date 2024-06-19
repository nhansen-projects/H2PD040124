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
        private MyProfileViewModel userProfileView;
        private User user;

        public HomePageViewModel(MainWindowViewModel main, MyProfileViewModel userProfileView , User user)
        {
            this.main = main;
            this.userProfileView = userProfileView;
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
            main.SetViewModel(new SetForSaleViewModel(main, userProfileView, new Vehicle(), new Auction(), user ));
        }

        public void MyProfile()
        {
            main.SetViewModel(new MyProfileViewModel(main, userProfileView, user));
        }

        public void BidHistory()
        {
            main.SetViewModel(new BidHistoryViewModel(main, userProfileView, user));
        }

        public void BuyerOfAuction()
        {
            main.SetViewModel(new BuyerOfAuctionViewModel(main, userProfileView, user));
        }

        public void SellerOfAuction()
        {
            main.SetViewModel(new SellerOfAuctionViewModel(main, userProfileView, user));
        }
    }
}
