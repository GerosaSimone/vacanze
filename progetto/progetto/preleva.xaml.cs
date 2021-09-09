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
    /// Logica di interazione per preleva.xaml
    /// </summary>
    public partial class preleva : Window
    {
        Gestione g;
        Utenti ut;
        Utente u;
        public preleva(Utenti a, Utente b, Gestione c)
        {
            InitializeComponent();
            ut = a;
            u = b;
            g = c;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (u.saldo >= 50)
            {
                u.saldo -= 50;
                ut.aggiorna(u);
                g.salva(ut);
                MessageBox.Show("Prelievo completato");
                home();
            }
            else
            {
                err.Content = "saldo insufficente";
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (u.saldo >= 50)
            {
                u.saldo -= 50;
                ut.aggiorna(u);
                g.salva(ut);
                MessageBox.Show("Prelievo completato");
                home();
            }
            else
            {
                err.Content = "saldo insufficente";
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (u.saldo >= 50)
            {
                u.saldo -= 50;
                ut.aggiorna(u);
                g.salva(ut);
                MessageBox.Show("Prelievo completato");
                home();
            }
            else
            {
                err.Content = "saldo insufficente";
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (u.saldo >= 50)
            {
                u.saldo -= 50;
                ut.aggiorna(u);
                g.salva(ut);
                MessageBox.Show("Prelievo completato");
                home();
            }
            else
            {
                err.Content = "saldo insufficente";
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int i = 0;
            if (int.TryParse(soldi.Text, out i))
            {
                if (u.saldo >= i)
                {
                    u.saldo -= i;
                    ut.aggiorna(u);
                    g.salva(ut);
                    MessageBox.Show("Prelievo completato");
                    home();
                }
                else
                {
                    err.Content = "saldo insufficente";
                }
            }
            else
            {
                err.Content = "inserire solo numeri";
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            sportello a = new sportello(ut, u, g);
            a.Show();
            this.Hide();
        }
        private void home()
        {
            sportello a = new sportello(ut, u, g);
            a.Show();
            this.Hide();
        }
    }
}
