using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PROJECT.Entities;
using System.Diagnostics;

namespace PROJECT.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine(Pesel.Text);
            //int P = int.Parse(Pesel.Text.ToString());
            test(207);
        }

        private void test(int Pesel)
        {
            using (var db = new MyDbContext())
            {
                //var query = //(from T in db.Klienci
                          //   join K in db.Karnet on T.Pesel equals K.ID_Klient
                           //  where T.Pesel == Pesel
                           //  select new { Name = T.Imie, Surname = T.Nazwisko, Date = K.Data_waznosci }).ToList();
              //    DataGrid.ItemsSource = query;

            }
        }
    }
}
