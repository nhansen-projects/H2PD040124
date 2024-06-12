using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;

namespace CarAuction.ViewModels
{
    public class SetForSaleViewModel : ViewModelBase
    {
        private MainWindowViewModel main;

        public SetForSaleViewModel(MainWindowViewModel main)
        {
            this.main = main;
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


        public void CreateAuctionBtn()
        {
            //All missing are in dummy strings
            string Year = "MISSING";
            string CloseAuction = "MISSING";
            string VehicleType = "MISSING";
            string TowBar = "MISSING";

            List<string> CreateSaleList = new List<string> { SaleName, SaleMilage, SaleRegnr, Year, SaleStarting, CloseAuction, VehicleType, SaleHeight, SaleLength, SaleWeight, SaleEngineSize, TowBar};
        }




        public void CancelBtn()
        {
            main.SetViewModel(new HomePageViewModel(main));
        }

    }
}
