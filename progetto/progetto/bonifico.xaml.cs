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
    /// Logica di interazione per bonifico.xaml
    /// </summary>
    public partial class bonifico : Window
    {
        Gestione g;
        Utenti ut;
        Utente u;
        public bonifico(Utenti a, Utente b, Gestione c)
        {
            InitializeComponent();
            ut = a;
            u = b;
            g = c;
        }

        public bool vuoto()
        {
            int i = 0;
            if (iban.Text == ""||int.TryParse(iban.Text,out i))
                return true;
            return false;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (!vuoto()&&ut.ibanEsiste2(iban.Text))
            {
                if (u.saldo >= 50)
                {
                    err.Content = "";
                    ut.trovaEaggiungi(iban.Text, 50);
                    u.saldo -= 50;
                    ut.aggiorna(u);
                    g.salva(ut);
                    MessageBox.Show("Bonifico effettuato correttamente");
                    home();
                }
                else
                {
                    err.Content = "saldo insufficente";
                }
            }
            else
            {
                err.Content = "inserire un'IBAN correto";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!vuoto() && ut.ibanEsiste2(iban.Text))
            {
                if (u.saldo >= 100)
                {
                    err.Content = "";
                    ut.trovaEaggiungi(iban.Text, 100);
                    u.saldo -= 100;
                    ut.aggiorna(u);
                    g.salva(ut);
                    MessageBox.Show("Bonifico effettuato correttamente");
                    home();
                }
                else
                {
                    err.Content = "saldo insufficente";
                }
            }
            else
            {
                err.Content = "inserire un'IBAN correto";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!vuoto() && ut.ibanEsiste2(iban.Text))
            {
                if (u.saldo >= 250)
                {
                    err.Content = "";
                    ut.trovaEaggiungi(iban.Text, 250);
                    u.saldo -= 250;
                    ut.aggiorna(u);
                    g.salva(ut);
                    MessageBox.Show("Bonifico effettuato correttamente");
                    home();
                }
                else
                {
                    err.Content = "saldo insufficente";
                }
            }
            else
            {
                err.Content = "inserire un'IBAN correto";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (!vuoto() && ut.ibanEsiste2(iban.Text))
            {
                if (u.saldo >= 500)
                {
                    err.Content = "";
                    ut.trovaEaggiungi(iban.Text, 500);
                    u.saldo -= 500;
                    ut.aggiorna(u);
                    g.salva(ut);
                    MessageBox.Show("Bonifico effettuato correttamente");
                    home();
                }
                else
                {
                    err.Content = "saldo insufficente";
                }
            }
            else
            {
                err.Content = "inserire un'IBAN correto";
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        { 

            int i = 0;
            if (int.TryParse(soldi.Text, out i))
            {
                if (!vuoto() && ut.ibanEsiste2(iban.Text))
                {
                    if (u.saldo >= Convert.ToInt32(soldi.Text))
                    {
                        err.Content = "";
                        ut.trovaEaggiungi(iban.Text, Convert.ToInt32(soldi.Text));
                        u.saldo -= Convert.ToInt32(soldi.Text);
                        ut.aggiorna(u);
                        g.salva(ut);
                        MessageBox.Show("Bonifico effettuato correttamente");
                        home();
                    }
                    else
                    {
                        err.Content = "saldo insufficente";
                    }
                }
                else
                {
                    err.Content = "inserire un'IBAN correto";
                }
            }
            else
            {
                err.Content="inserire solo numeri";
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

