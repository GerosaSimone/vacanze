using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto
{
    class Gestione
    {
        private string nomeFile;
        public Gestione(string nomeFile) => this.nomeFile = nomeFile;
        public void scriviTutto(string stringa) => File.WriteAllText(nomeFile, stringa);
        public string leggiTutto() { return File.ReadAllText(nomeFile); }
        public bool aggiungi(Utenti lista)
        {
            Utenti l = new Utenti();
            bool esito = false;
            string temp = "";
            for (int i = 0; i < l.NumEl(); i++)
            {
                temp += l.GetUtente(i).to_string() + "\n";
            }
            File.AppendAllText(nomeFile, temp);
            esito = true;
            return esito;
        }

        public void aggiungiUtente(Utente u)
        {
            string temp = "";
                temp += u.to_string() + "\n";
            
            File.AppendAllText(nomeFile, temp);
        }
        public Utenti leggi()
        {
            Utenti lista = new Utenti();
            using (StreamReader sr = File.OpenText(nomeFile))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Utente temp = new Utente();
                    temp.from_string(s);
                    lista.add(temp);
                }
            }
            return lista;
        }
        public bool salva(Utenti lista)
        {
            bool esito = false;
            string temp = "";
            for (int i = 0; i < lista.NumEl(); i++)
            {
                temp += lista.GetUtente(i).to_string() + "\n";
            }
            File.WriteAllText(nomeFile, temp);
            esito = true;
            return esito;
        }
    }
}
