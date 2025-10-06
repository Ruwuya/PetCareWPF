using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace PetCareWPF.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private object _currentView;

        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        // ViewModels for each section
        public HomeViewModel HomeVM { get; set; }
        public PetsViewModel PetsVM { get; set; }
        public CustomersViewModel CustomersVM { get; set; }

        // Commands for switching views
        public ICommand HomeViewCommand { get; }
        public ICommand PetsViewCommand { get; }
        public ICommand CustomersViewCommand { get; }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            PetsVM = new PetsViewModel();
            CustomersVM = new CustomersViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(_ => CurrentView = HomeVM);
            PetsViewCommand = new RelayCommand(_ => CurrentView = PetsVM);
            CustomersViewCommand = new RelayCommand(_ => CurrentView = CustomersVM);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}