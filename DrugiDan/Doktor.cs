using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiDan
{
    class Doktor
    {
       private  string Ime;
       private  string Prezime;
       private int Godine;

        public virtual void PredstaviSe() {

            Console.WriteLine("Moje ime je" + Ime + " " + Prezime + " " + Godine  + " i ja sam doktor");
        }

        public void SetIme(string ime)
        {
            if (string.IsNullOrEmpty(ime) == false)
            {
                this.Ime = ime;
            }
            else {
                Console.WriteLine("ime ne smije biti prazno");
            }

        }
        public string GetIme() {
            return Ime;
            }

        
        public void SetPrezime(string prezime)
        {
            if (string.IsNullOrEmpty(prezime) == false)
            {
                this.Prezime = prezime;
            }
            else
            {
                Console.WriteLine("ime ne smije biti prazno");
            }

        }
        public string GetPrezime()
        {
            return Prezime;
        }
        public void SetGodine(int godine) {
            if (godine >= 0 && godine<=100)
            {
                this.Godine = godine;
            }
            else {
                Console.WriteLine( "error");
            }

        }
        public int GetGodine() {
            return Godine;
        }
    }
}
