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
            //controllo che nel testo ci siano solo numeri
            if (iban.Text == "")
                return true;
            return false;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!vuoto()&&ut.ibanEsiste2(iban.Text))
            {
                ut.trovaEaggiungi(iban.Text, 50);
            }
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

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
}
