using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto
{
    public class Utente
    {
       
        public string nome { get; set; }
        public string pass { get; set; }
        public int saldo { get; set; }

        public int IBAN { get; set; }
        public Utente()
        {
            nome = "";
            pass = "";
            saldo = 0;
            IBAN = 0;
        }
        public Utente(string s)
        {
            string[] tmp = s.Split(';');
            nome = tmp[0];
            pass = tmp[1];
            saldo = Convert.ToInt32(tmp[2]);
            IBAN = Convert.ToInt32(tmp[3]);
        }
        public Utente(string n,string p)
        {
            nome = n;
            pass = p;
            saldo = 0;
            Random rnd = new Random();
            IBAN = rnd.Next(1000, 10000); 
        }

        public string to_string() {

            return nome + ";" + pass + ";" + saldo.ToString() + ";"+IBAN.ToString()+";";
        }
        public void from_string(string s)
        {
            string[] tmp = s.Split(';');
            nome = tmp[0];
            pass = tmp[1];
            saldo = Convert.ToInt32(tmp[2]);
            IBAN = Convert.ToInt32(tmp[3]);
        }
        public string Dati()
        {
            return nome + ";" + pass;
        }  
    }
}
