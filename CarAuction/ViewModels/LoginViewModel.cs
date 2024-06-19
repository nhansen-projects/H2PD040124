using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarAuction.ConnectionHandlers;
using CarAuction.Models;
using ReactiveUI;

namespace CarAuction.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private MainWindowViewModel main;
        private User user = new User();
        public LoginViewModel(MainWindowViewModel main)
        {
            this.main = main;
        }

        public LoginViewModel()
        {

        }
        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public void CreateUser()
        {
            main.SetViewModel(new CreateViewModel(main, new User()));
        }


        public void HomePage()
        {
            Handlers();
        }

        private string _error;
        public string Error
        {
            get => _error;
            set
            {
                this.RaiseAndSetIfChanged(ref _error, value, nameof(Error));
            }
        }


        MyProfileViewModel profile = new();
        public void Handlers()
        {
            if (Database.Login(user.Username, user.Password))
            {
                main.SetViewModel(new HomePageViewModel(main, profile));
            }
            else
            {
                Error = "Invalid Username Or Password";
            }
        }
    }
}