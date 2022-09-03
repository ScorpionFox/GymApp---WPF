using PROJECT.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT.MVVM.MainViewModel
{
    class MGW : ObservableObject
    {

        public HomeViewModel HomeVm { get; set; }
        private object _obecnyWidok;
            
        public object ObecnyWidok
        {
            get { return _obecnyWidok; }
            set { _obecnyWidok = value;
                OnPropertyChanged();
            }
        }
        public MGW() 
        {
            HomeVm = new HomeViewModel();
            ObecnyWidok = HomeVm;
        }
    }
}
