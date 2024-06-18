using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAuction.ViewModels
{
    public class CreateViewModel : ViewModelBase
    {
        private MainWindowViewModel main;
        public CreateViewModel(MainWindowViewModel main)
        {
            this.main = main;
        }

        public CreateViewModel()
        {

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


        private string _PasswordAgainInput;
        public string PasswordAgainInput
        {
            get => _PasswordAgainInput;
            set
            {
                this.RaiseAndSetIfChanged(ref _PasswordAgainInput, value, nameof(PasswordAgainInput));
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

        }

        public void Cancel()
        {
            main.SetViewModel(new LoginViewModel(main));
        }

    }
}

