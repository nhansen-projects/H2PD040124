using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarAuction.Models;
using DynamicData.Kernel;
using ReactiveUI;

namespace CarAuction.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private MainWindowViewModel main;

        
        public LoginViewModel(MainWindowViewModel main)
        {
            this.main = main;
        }

        public LoginViewModel()
        {

        }

        public void CreateUser()
        {
            main.SetViewModel(new CreateViewModel(main));
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

        private string _UserNameInput;
        public string UserNameInput
        {
            get => _UserNameInput;
            set
            {
                this.RaiseAndSetIfChanged(ref _UserNameInput, value, nameof(UserNameInput));
            }
        }

        private string _PasswordInput;
        public string PasswordInput
        {
            get => _PasswordInput;
            set
            {
                this.RaiseAndSetIfChanged(ref _PasswordInput, value, nameof(PasswordInput));
            }
        }


        MyProfileViewModel user = new();
        public void Handlers()
        {
            //Check om det findes
            string DummyUSERNAME = "A";
            string DummyPASSWORD = "S";

            if (UserNameInput == DummyUSERNAME && PasswordInput == DummyPASSWORD)
            {
                user.Username = UserNameInput;
                user.Password = PasswordInput;


                main.SetViewModel(new HomePageViewModel(main, user));
            }
            else
            {
                Error = "Invalid Username Or Password";
            }
        }
    }
}