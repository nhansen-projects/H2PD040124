﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReactiveUI;

namespace CarAuction.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private MainWindowViewModel main;
        LoginViewModel login = new();
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

        public void Handlers()
        {
            //Check om det findes
            string DummyUSERNAME = "DUMMYDATA";
            string DummyPASSWORD = "DUMMYDATA";


            if (UserNameInput == DummyUSERNAME && PasswordInput == DummyPASSWORD)
            {
                main.SetViewModel(new HomePageViewModel(main, login));
            }
            else
            {
                Error = "Invalid Username Or Password";
                //Slettes når databasen er koblet til
                main.SetViewModel(new HomePageViewModel(main, login));
            }
                

            
      

        }





    }
}