using PROJECT.Core;
using PROJECT.MVVM.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.MVVM.ViewModel
{
    /// <summary>
    /// klasa widoku MainView zawierająca dane potrzebne do przełączania między widokami
    /// </summary>
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand DiscoveryViewCommand { get; set; }

        public RelayCommand TrainViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }

        public DiscoveryViewModel DiscoveryVM { get; set; }

        public TrainViewModel TrainVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set {
                _currentView = value;
                OnPropertyChanged();
                }
        }

        /// <summary>
        /// Przełączanie, zmiana obecnego widoku na inny
        /// </summary>
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            TrainVM = new TrainViewModel();
            CurrentView = DiscoveryVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });

            TrainViewCommand = new RelayCommand(o =>
            {
                CurrentView = TrainVM;
            });
        }
    }
}
