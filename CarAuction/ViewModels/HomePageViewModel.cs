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
        public HomePageViewModel(MainWindowViewModel main)
        {
            this.main = main;
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
            main.SetViewModel(new SetForSaleViewModel(main));
        }

        public void MyProfile()
        {
            main.SetViewModel(new MyProfileViewModel(main));
        }

        public void BidHistory()
        {
            main.SetViewModel(new BidHistoryViewModel(main));
        } 
        
    }
}
