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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Tabela = Combo.SelectedItem.ToString();

            using (var db = new MyDbContext())
            {
                switch (Tabela)
                {
                    case "Trenerzy":
                        var query = (from T in db.Trenerzy
                                    select T).ToList();
                        DataGrid.ItemsSource = query;
                        break;
                    case "Klienci":
                        var query = (from T in db.Klienci
                                     select T).ToList();
                        DataGrid.ItemsSource = query;
                        break;
                    case "Karnet":
                        var query = (from T in db.Karnet
                                     select T).ToList();
                        DataGrid.ItemsSource = query;
                        break;
                    case "Rabat":
                        var query = (from T in db.Rabat
                                     select T).ToList();
                        DataGrid.ItemsSource = query;
                        break;
                }

            }
        }
    }
}
