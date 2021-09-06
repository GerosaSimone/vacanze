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
        
        
        public MainWindow()
        {
            InitializeComponent();
            Utenti utenti = new Gestione(/*file testo*/).leggi();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!vuoti())
            {
                Utente u = new Utente(Username.Text,Password.Text);
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
    }
}
