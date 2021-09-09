using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace progetto
{
    public class Utenti
    {
        public List<Utente> utenti { get; set; }

        public Utenti()
        {
            utenti = new List<Utente>();
        }
        public void add(Utente a)
        {
            utenti.Add(a);
        }
        public int NumEl()
        {
            return utenti.Count;
        }
        public Utente GetUtente(int i)
        {
            return utenti[i];
        }
        public bool confronta(string s)
        {
            for(int i = 0; i < NumEl(); i++)
            {
                if (utenti[i].Dati() == s)
                    return true;
            }
            return false;
        }

        public bool Esiste(Utente tmp)
        {

            for (int i = 0; i < NumEl(); i++)
            {
                if (tmp.nome == GetUtente(i).nome && tmp.pass == GetUtente(i).pass)
                    return true;
            }
            return false;
        }

        public bool ibanEsiste(Utente tmp)
        {
            for (int i = 0; i < NumEl(); i++)
            {
                if (tmp.IBAN == GetUtente(i).IBAN)
                    return true;
            }
            return false;
        }
        public bool ibanEsiste2(String tmp)
        {
            for (int i = 0; i < NumEl(); i++)
            {
                if (Convert.ToInt32(tmp) == GetUtente(i).IBAN)
                    return true;
            }
            return false;
        }
        public void aggiorna(Utente tmp)
        {
            for (int i = 0; i < NumEl(); i++)
            {
                if (tmp.nome == GetUtente(i).nome && tmp.pass == GetUtente(i).pass)
                    GetUtente(i).saldo = tmp.saldo;
            }
        }
        public Utente trova(String n,String p)
        {
            for (int i = 0; i < NumEl(); i++)
            {
                if (n == GetUtente(i).nome && p == GetUtente(i).pass)
                    return utenti[i];
            }
            return new Utente();
        }

        public int saldoIban(string Iban)
        {
            for (int i = 0; i < NumEl(); i++)
            {
                if (Convert.ToInt32(Iban) == GetUtente(i).IBAN)
                    return GetUtente(i).saldo;               
            }
            return -1;
        }

        public void trovaEaggiungi(String tmp, int soldi)
        {
            for (int i = 0; i < NumEl(); i++)
            {
                if (Convert.ToInt32(tmp) == GetUtente(i).IBAN)
                {
                    GetUtente(i).saldo += soldi;
                }
                    
            }
        }


    }




}
