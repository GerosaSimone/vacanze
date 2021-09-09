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

namespace progetto
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        Gestione g;
        Utenti ut;
        public MainWindow()
        {
            InitializeComponent();
            g = new Gestione("C:\\Users\\gero\\Desktop\\prova.txt");
            ut=g.leggi();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            err.Content = "";
            if (!vuoti())
            {
                Utente u = ut.trova(Username.Text, Password.Text);
                if (ut.Esiste(u))
                {
                    sportello a = new sportello(ut, u, g);
                    a.Show();
                    this.Hide();
                    
                }
                else {
                    err.Content = "utente inesistente, registrarsi";
                     }
            }
            else
            {
                err.Content = "inserire tutti i campi";
            }
        }

        public bool vuoti()
        {
            if (Username.Text == "")
                return true;
            if (Password.Text == "")
                return true;

            return false;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            err.Content = "";
            if (!vuoti())
            {
                Utente u = new Utente(Username.Text, Password.Text);
                if (!ut.Esiste(u)&&!ut.ibanEsiste(u))
                {
                    ut.add(u);
                    g.aggiungiUtente(u);
                    Username.Text = "";
                    Password.Text = "";
                    sportello a = new sportello(ut, u, g);
                    a.Show();
                    this.Hide();
                }
                else
                {
                    err.Content = "utente gia esistente premere login se gia in possesso di un account oppure cambiare username o password";
                }
            }
            else
            {
                err.Content = "inserire tutti i campi";
            }
        }

       
    }
}
