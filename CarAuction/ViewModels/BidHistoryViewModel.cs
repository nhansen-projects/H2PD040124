using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAuction.Models;

namespace CarAuction.ViewModels
{
    internal class BidHistoryViewModel : ViewModelBase
    {
        private MainWindowViewModel main;
        private MyProfileViewModel userProfileView;
        private User user;
        
        public BidHistoryViewModel(MainWindowViewModel main, MyProfileViewModel userProfileView, User user)
        {
            this.main = main;
            this.userProfileView = userProfileView;
            this.user = user;
        }
         
        public BidHistoryViewModel()
        {

        }


        public void HistoryList()
        {

        }

        public void BackBtn()
        {
            main.SetViewModel(new HomePageViewModel(main, userProfileView, user));
        }


    }


}
