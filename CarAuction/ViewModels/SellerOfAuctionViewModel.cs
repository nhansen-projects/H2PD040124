using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAuction.Models;

namespace CarAuction.ViewModels
{
    public class SellerOfAuctionViewModel : ViewModelBase
    {
        private MainWindowViewModel main;
        private MyProfileViewModel userProfileView;
        private Vehicle vehicle;
        private User user;
        
        public SellerOfAuctionViewModel(MainWindowViewModel main, MyProfileViewModel userProfileView, User user)
        {
            this.main = main;
            this.userProfileView = userProfileView;
            this.user = user;
        }

        public SellerOfAuctionViewModel()
        {

        }


        private string _closingTime;
        public string ClosingTime
        {
            get => _closingTime;
            set
            {
                this.RaiseAndSetIfChanged(ref _closingTime, value, nameof(ClosingTime));
            }
        }


        private string _currentBid;
        public string CurrentBid
        {
            get => _currentBid;
            set
            {
                this.RaiseAndSetIfChanged(ref _currentBid, value, nameof(CurrentBid));
            }
        }


        public void BackBtn()
        {
            main.SetViewModel(new HomePageViewModel(main, userProfileView, user));
        }


    }
}
