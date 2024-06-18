using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace CarAuction.ViewModels
{
    internal class BuyerOfAuctionViewModel : ViewModelBase
    {
        private MainWindowViewModel main;
        private MyProfileViewModel user;
        public BuyerOfAuctionViewModel(MainWindowViewModel main, MyProfileViewModel user)
        {
            this.main = main;
            this.user = user;
        }

        public BuyerOfAuctionViewModel()
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
            main.SetViewModel(new HomePageViewModel(main, user));
        }
    }
}
