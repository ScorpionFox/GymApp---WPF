using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PROJECT.MVVM.ViewModel;

namespace PROJECT.Core
{
    /// <summary>
    /// Klasa umożliwiająca zmianę widoku
    /// </summary>
    class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Metoda umożliwiająca zmianę widoku
        /// </summary>
        
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
