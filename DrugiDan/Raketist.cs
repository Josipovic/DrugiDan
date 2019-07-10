using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiDan
{
    class Raketist:Vojnik
    {
        public int SnagaRakete;
        public int DometRakete;
        public int PreciznostRakete;
        public int BrojRaketa;
        public Raketist()
        {
            SnagaRakete = 100;
            DometRakete = 100;
            PreciznostRakete = 100;
            BrojRaketa = 100;
        }

        public void PovecajBrojRaketa(int BrojRaketa1) {

            BrojRaketa += BrojRaketa1;
        }
        public void IspaliRaketu() {
            Console.WriteLine("Raketa Ispaljena");
            BrojRaketa--;
        }
        public int DohvatiEnergiju() {

            return Energija;
        }

        public void PovecajEnergiju() {

            Energija++;
        }

        public override void IspisiEnergijuILokaciju()
        {
            Console.WriteLine("Podaci o raketistu");
            Console.WriteLine(Energija + y + x);
        }
    }
}
