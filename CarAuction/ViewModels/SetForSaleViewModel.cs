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

    }
}
