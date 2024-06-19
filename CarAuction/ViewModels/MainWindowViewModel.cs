using CarAuction.ConnectionHandlers;
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

        private Database_Queries _queries;
        public Database_Queries Queries {get { return _queries; } }
    


        public MainWindowViewModel()
        {
            _contentViewModel = new LoginViewModel(this);
            _queries = new Database_Queries();
        }
    }
}
