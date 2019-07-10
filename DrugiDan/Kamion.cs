using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiDan
{
    class Kamion:Vozilo
    {
        public int BrojVojnika;
        public int Brzina;
        public Kamion()
        {
            BrojVojnika = 5;
            Brzina = 10;

        }

        public override void IspisiLokaciju()
        {
            Console.WriteLine("Lokacija kamiona");
            Console.WriteLine(x);
            Console.WriteLine(y);

        }

        public void Uspori() {

            Brzina--;
        }

    }
}
