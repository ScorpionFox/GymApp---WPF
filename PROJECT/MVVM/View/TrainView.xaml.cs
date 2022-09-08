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
    /// Logika interakcji dla klasy TrainView.xaml
    /// </summary>
    public partial class TrainView : UserControl
    {
        public TrainView()
        {
            InitializeComponent();
            Komunikat3.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Tabela = Combo2.SelectedIndex;
            int index = int.Parse(Id.Text);

            using (var db = new MyDbContext())
            {
                try
                {
                    switch (Tabela)
                    {
                        case 0:
                            Trenerzy Trener = new Trenerzy() { Id = index };
                            db.Trenerzy.Attach(Trener);
                            db.Trenerzy.Remove(Trener);
                            db.SaveChanges();
                            Komunikat3.Text = "Usunięto pomyślnie";
                            break;
                        case 1:
                            Klienci Klient = new Klienci() { Id = index };
                            db.Klienci.Attach(Klient);
                            db.Klienci.Remove(Klient);
                            db.SaveChanges();
                            Komunikat3.Text = "Usunięto pomyślnie";
                            break;
                        case 2:
                            Rabat Rabat = new Rabat() { Id = index };
                            db.Rabat.Attach(Rabat);
                            db.Rabat.Remove(Rabat);
                            db.SaveChanges();
                            Komunikat3.Text = "Usunięto pomyślnie";
                            break;
                        case 3:
                            Karnet Karnet = new Karnet() { Id = index };
                            db.Karnet.Attach(Karnet);
                            db.Karnet.Remove(Karnet);
                            db.SaveChanges();
                            Komunikat3.Text = "Usunięto pomyślnie";
                            break;
                        default:
                            throw new Exception();
                            break;
                    }
                }
                catch
                {
                    Komunikat3.Text = "Wystąpił błąd";
                }
            }

            }
        }
    }  

