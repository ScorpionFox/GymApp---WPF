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
            Komunikat1.Text = "";
            Komunikat2.Text = "";
        }

        /// <summary>
        /// Dodawanie Klienta do bazy danych
        /// </summary>

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new MyDbContext())
                {
                    Klienci Klient = new Klienci();
                    Klient.Id = db.Klienci.Max(e => e.Id) + 1;
                    Klient.Imie = ImieK.Text;
                    Klient.Nazwisko = NazwiskoK.Text;
                    Klient.IdTrener = int.Parse(IdTrener.Text);
                    Klient.IdRabat = int.Parse(IdRabat.Text);
                    Klient.IdKarnet = int.Parse(IdKarnet.Text);

                    db.Klienci.Add(Klient);
                    db.SaveChanges();
                    Komunikat1.Text = "Dodano Pomyślnie";
                }
            }
            catch
            {
                Komunikat1.Text = "Wystąpił błąd";
            }
        }

        /// <summary>
        /// Dodawanie Trenera do bazy danych
        /// </summary>

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new MyDbContext())
                {
                    Trenerzy Trener = new Trenerzy();
                    Trener.Id = db.Trenerzy.Max(e => e.Id) + 1;
                    Trener.Imie = ImieT.Text;
                    Trener.Nazwisko = NazwiskoT.Text;
                    Trener.Specjalizacja = Specjalizacja.Text;

                    db.Trenerzy.Add(Trener);
                    db.SaveChanges();
                    Komunikat2.Text = "Dodano Pomyślnie";
                }
            }
            catch
            {
                Komunikat2.Text = "Wystąpił błąd";
            }
        }

        private void ImieK_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
