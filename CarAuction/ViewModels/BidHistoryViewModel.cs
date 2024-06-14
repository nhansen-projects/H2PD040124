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
        private LoginViewModel login;
        public BidHistoryViewModel(MainWindowViewModel main, LoginViewModel login)
        {
            this.main = main;
            this.login = login;
        }

        public BidHistoryViewModel()
        {

        }


        public void HistoryList()
        {

        }

        public void BackBtn()
        {
            main.SetViewModel(new HomePageViewModel(main, login));
        }


    }


}
