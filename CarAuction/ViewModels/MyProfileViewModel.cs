using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuction.ViewModels
{
    internal class MyProfileViewModel : ViewModelBase
    {
        private MainWindowViewModel main;
        private LoginViewModel login;
        public MyProfileViewModel(MainWindowViewModel main, LoginViewModel login)
        {
            this.main = main;
            this.login = login;
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

        public void ChangePasswordBtn()
        {
            //Noget der kan lave et pop up vindue der kan ændre adganskoden
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

        public void BackBtn()
        {
            main.SetViewModel(new HomePageViewModel(main, login));
        }
    }
}
