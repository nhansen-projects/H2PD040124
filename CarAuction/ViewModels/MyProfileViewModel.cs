using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuction.ViewModels
{
    public class MyProfileViewModel : ViewModelBase
    {
        private MainWindowViewModel main;
        private MyProfileViewModel user;
        public MyProfileViewModel(MainWindowViewModel main, MyProfileViewModel user)
        {
            this.main = main;
            this.user = user;
        }

        public MyProfileViewModel()
        {

        }

        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                this.RaiseAndSetIfChanged(ref _username, value, nameof(Username));
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                this.RaiseAndSetIfChanged(ref _password, value, nameof(Password));
            }
        }


        //Høre til ChangePassword
        private string _newPassword;
        public string NewPassword
        {
            get => _newPassword;
            set
            {
                this.RaiseAndSetIfChanged(ref _newPassword, value, nameof(NewPassword));
            }
        }

        private string _balance;
        public string Balance
        {
            get => _balance;
            set
            {
                this.RaiseAndSetIfChanged(ref _balance, value, nameof(Balance));
            }
        }

        private string _newBalance;
        public string NewBalance
        {
            get => _newBalance;
            set
            {
                this.RaiseAndSetIfChanged(ref _newBalance, value, nameof(NewBalance));
            }
        }


        public void ChangeBalanceBtn()
        {

        }
        private string _myAuctions;
        public string MyAuctions
        {
            get => _myAuctions;
            set
            {
                this.RaiseAndSetIfChanged(ref _myAuctions, value, nameof(MyAuctions));
            }
        }

        private string _auctionsWon;
        public string AuctionsWon
        {
            get => _auctionsWon;
            set
            {
                this.RaiseAndSetIfChanged(ref _auctionsWon, value, nameof(AuctionsWon));
            }
        }

        public void ChangePasswordBtn()
        {
            //Noget der kan lave et pop up vindue der kan ændre adganskoden
        }



        public void BackBtn()
        {
            main.SetViewModel(new HomePageViewModel(main, user));
        }
    }
}
