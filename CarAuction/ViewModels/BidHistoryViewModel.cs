using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuction.ViewModels
{
    internal class BidHistoryViewModel : ViewModelBase
    {
        private MainWindowViewModel main;
        public BidHistoryViewModel(MainWindowViewModel main)
        {
            this.main = main;
        }

        public BidHistoryViewModel()
        {

        }


        public void HistoryList()
        {

        }

        public void BackBtn()
        {
            main.SetViewModel(new HomePageViewModel(main));
        }


    }


}
