using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CarAuction.Models;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Microsoft.VisualBasic;
using ReactiveUI;

namespace CarAuction.ViewModels
{
    public class SetForSaleViewModel : ViewModelBase
    {
        private MainWindowViewModel main;
        private LoginViewModel login;

        public SetForSaleViewModel(MainWindowViewModel main, LoginViewModel login)
        {
            this.main = main;
            this.login = login;
        }

        public SetForSaleViewModel()
        {

        }

        private string _SaleName;
        public string SaleName
        {
            get => _SaleName;
            set
            {
                this.RaiseAndSetIfChanged(ref _SaleName, value, nameof(SaleName));
            }
        }

        private string _SaleMilage;
        public string SaleMilage
        {
            get => _SaleMilage;
            set
            {
                this.RaiseAndSetIfChanged(ref _SaleMilage, value, nameof(SaleMilage));
            }
        }

        private string _SaleRegnr;
        public string SaleRegnr
        {
            get => _SaleRegnr;
            set
            {
                this.RaiseAndSetIfChanged(ref _SaleRegnr, value, nameof(SaleRegnr));
            }
        }

        private string _SaleStarting;
        public string SaleStarting
        {
            get => _SaleStarting;
            set
            {
                this.RaiseAndSetIfChanged(ref _SaleStarting, value, nameof(SaleStarting));
            }
        }

        private string _SaleHeight;
        public string SaleHeight
        {
            get => _SaleHeight;
            set
            {
                this.RaiseAndSetIfChanged(ref _SaleHeight, value, nameof(SaleHeight));
            }
        }

        private string _SaleLength;
        public string SaleLength
        {
            get => _SaleLength;
            set
            {
                this.RaiseAndSetIfChanged(ref _SaleLength, value, nameof(SaleLength));
            }
        }

        private string _SaleWeight;
        public string SaleWeight
        {
            get => _SaleWeight;
            set
            {
                this.RaiseAndSetIfChanged(ref _SaleWeight, value, nameof(SaleWeight));
            }
        }


        private string _SaleEngineSize;
        public string SaleEngineSize
        {
            get => _SaleEngineSize;
            set
            {
                this.RaiseAndSetIfChanged(ref _SaleEngineSize, value, nameof(SaleEngineSize));
            }
        }

        private string _towBar;
        public string TowBar
        {
            get => _towBar;
            set
            {
                this.RaiseAndSetIfChanged(ref _towBar, value, nameof(TowBar));
            }
        }

        public void HasTowBar()
        {
            TowBar = "Yes";
        }

        public void NoTowBar()
        {
            TowBar = "No";
        }


        private string _vehicleTypeIndex;
        public string VehicleTypeIndex
        {
            get => _vehicleTypeIndex;
            set
            {
                this.RaiseAndSetIfChanged(ref _vehicleTypeIndex, value, nameof(VehicleTypeIndex));
            }
        }


        private string vehicleType;

        public void TypeOfVehicle()
        {
            switch (VehicleTypeIndex)
            {
                case "0":
                    vehicleType = "So";
                    break;
                case "1":
                    vehicleType = "Truck";
                    break;
                case "2":
                    vehicleType = "Car";
                    break;
                case "3":
                    vehicleType = "Bike";
                    break;
                case "4":
                    vehicleType = "Bus";
                    break;
                case "5":
                    vehicleType = "ko";
                    break;
            }
        }


        private string _year;
        public string Year
        {
            get => _year;
            set
            {
                this.RaiseAndSetIfChanged(ref _year, value, nameof(Year));
            }
        }


        public string ConYear;
        public void ConvertToYear()
        {
            string ShowYear = @"\b\d{4}\b";

            Match match = Regex.Match(Year, ShowYear);
            if (match.Success)
            {
                string year = match.Value;
                ConYear = year;
            }
            else 
            {
                
            }
        }

        private string _closeAuction;
        public string CloseAuction
        {
            get => _closeAuction;
            set
            {
                this.RaiseAndSetIfChanged(ref _closeAuction, value, nameof(CloseAuction));
            }
        }


        public void CreateAuctionBtn()
        {
            TypeOfVehicle();
            ConvertToYear();
            List<string> CreateSaleList = new List<string> { SaleName, SaleMilage, SaleRegnr, ConYear, SaleStarting, CloseAuction, vehicleType, SaleHeight, SaleLength, SaleWeight, SaleEngineSize, TowBar};
            main.SetViewModel(new HomePageViewModel(main, login));
        }




        public void CancelBtn()
        {
            main.SetViewModel(new HomePageViewModel(main, login));
        }

    }
}
