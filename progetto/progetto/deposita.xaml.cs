﻿using System;
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
    /// Logica di interazione per deposita.xaml
    /// </summary>
    public partial class deposita : Window
    {
        Gestione g;
        Utenti ut;
        Utente u;
        public deposita(Utenti a,Utente b,Gestione c)
        {
            InitializeComponent();
            ut = a;
            u = b;
            g = c;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            u.saldo += 50;
            ut.aggiorna(u);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            u.saldo += 100;
            ut.aggiorna(u);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            u.saldo += 250;
            ut.aggiorna(u);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            u.saldo += 500;
            ut.aggiorna(u);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            
            u.saldo += Convert.ToInt32(soldi.Text);
            ut.aggiorna(u);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            sportello a = new sportello(ut, u, g);
            a.Show();
            this.Hide();
        }
    }
}
