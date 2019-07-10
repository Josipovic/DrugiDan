using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiDan
{
    class Tenk:Vozilo
    {
        public int BrojGranata;
        public int SnagaStita;
        public Tenk()
        {
            BrojGranata = 20;
            SnagaStita = 100;

        }
        public void PovecajSnaguStita(int x) {

            SnagaStita = SnagaStita + x;
        }
        public void SmanjiSnaguStita() {

            SnagaStita--;
        }
        public override  void IspisiLokaciju()
        {
            Console.WriteLine("Lokacija tenka");
            Console.WriteLine(x);
            Console.WriteLine(y);

        }

    }
}
