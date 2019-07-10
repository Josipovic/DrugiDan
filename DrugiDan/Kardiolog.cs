using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiDan
{
    class Kardiolog:Doktor
    {
        public override void PredstaviSe()   //method hiding
        {

            Console.WriteLine("Moje ime je" + Ime + " " + Prezime + " " + Godine + " i ja sam doktor-kardiolog");
        }

    }
}
