using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuction.ViewModels
{
    internal class SellerOfAuctionViewModel : ViewModelBase
    {
        private MainWindowViewModel main;
        public SellerOfAuctionViewModel(MainWindowViewModel main)
        {
            this.main = main;
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
            //main.SetViewModel(new HomePageViewModel(main)); VED IKKE OM DET ER TIL HomePage eller hvor Seller of auction skal være?
        }


    }
}
