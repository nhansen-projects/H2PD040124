using ReactiveUI;
using System.ComponentModel;

namespace CarAuction.ViewModels
{
    public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
    {

        private ViewModelBase _contentViewModel;

         
        public ViewModelBase ContentViewModel
        {
            get => _contentViewModel;
            private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
        }

        public void SetViewModel(ViewModelBase model)
        {
            ContentViewModel = model;
        }


        public MainWindowViewModel()
        {
            _contentViewModel = new LoginViewModel(this);
        }
    }
}
