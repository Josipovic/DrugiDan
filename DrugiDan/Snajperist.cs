using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiDan
{
    class Snajperist:Vojnik
    {
        public float Preciznost;
        public float Povecaj=0.1f;

        public Snajperist()
        {
            y = 1;
            x = 1;
            Preciznost = 2;
        }
        public void PovecajPreciznost() {

            Preciznost += Povecaj;
        }
        public void PovecajBrzinuKretanja(int Brzina) {

            BrzinaKretanja = +Brzina;

        }

        public void ZaustaviSe() {

            BrzinaKretanja = 0;
        }
        public override void IspisiEnergijuILokaciju()
        {
            Console.WriteLine("Podaci o snajperistu");
            Console.WriteLine(Energija + y + x);
        }
    }
}
