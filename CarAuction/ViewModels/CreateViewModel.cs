using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarAuction.Models;
using CarAuction.ConnectionHandlers;

namespace CarAuction.ViewModels
{
    public class CreateViewModel : ViewModelBase
    {
        private MainWindowViewModel main;
        private User user;
        public CreateViewModel(MainWindowViewModel main, User user)
        {
            this.main = main;
            this.user = user;
        }

        public CreateViewModel()
        {

        }
        public User User
        {
            get { return user; }
            set { user = value; }
        }

        /*        private string _UserNameInput;
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
                }*/


        private string _passwordAgain;
        public string PasswordAgain
        {
            get => _passwordAgain;
            set
            {
                this.RaiseAndSetIfChanged(ref _passwordAgain, value, nameof(PasswordAgain));
            }
        }


        //Til fejl ved adgangskode ikke er ens
        private string _error;
        public string Error
        {
            get => _error;
            set
            {
                this.RaiseAndSetIfChanged(ref _error, value, nameof(Error));
            }
        }

        public bool CorporateLogin()
        {
            return true;
        }

        public bool PrivateLogin()
        {
            return true;
        }


        public void CreateUser()
        {
            if (User.Password != PasswordAgain || User.Username == Error)//Database.UsernameExist istedet for Error)
            {
                Error = "[Username Is Already In Use] or [Password Does Not Match]";
            }
            else
            {
                Error = "Your Account Was Created";
                Database.NewUser(User);
                main.SetViewModel(new LoginViewModel(main));
            }

        }

        public void Cancel()
        {
            main.SetViewModel(new LoginViewModel(main));
        }

    }
}

