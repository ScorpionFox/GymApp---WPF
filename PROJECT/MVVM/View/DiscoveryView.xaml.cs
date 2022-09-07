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
    /// Logika interakcji dla klasy DiscoveryView.xaml
    /// </summary>
    public partial class DiscoveryView : UserControl
    {
        public DiscoveryView()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Tabela = Combo.SelectedIndex;

            using (var db = new MyDbContext())
            {
                switch (Tabela)
                {
                    case 0:
                        var query1 = (from T in db.Trenerzy
                                    select T).ToList();
                        DataGrid.ItemsSource = query1;
                        break;
                    case 1:
                        var query2 = (from T in db.Klienci
                                     select T).ToList();
                        DataGrid.ItemsSource = query2;
                        break;
                    case 2:
                        var query3 = (from T in db.Rabat
                                     select T).ToList();
                        DataGrid.ItemsSource = query3;
                        break;
                    case 3:
                        var query4 = (from T in db.Karnet
                                     select T).ToList();
                        DataGrid.ItemsSource = query4;
                        break;
                    default:
                        throw new Exception();
                        break;
                }

            }
        }
    }
}
