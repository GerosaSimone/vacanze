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
using System.Windows.Shapes;

namespace progetto
{
    /// <summary>
    /// Logica di interazione per sportello.xaml
    /// </summary>
    public partial class sportello : Window
    {
        Gestione g;
        Utenti ut;
        Utente u;
        public sportello()
        {
            InitializeComponent();
        }
        public sportello(Utenti u,Utente ut,Gestione g)
        {
            InitializeComponent();
            this.g = g;
            this.ut = u;
            this.u = ut;
            saldo.Content = ut.saldo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
