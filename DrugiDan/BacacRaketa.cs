using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiDan
{
    class BacacRaketa:Vozilo
    {
        public int MaksimalniDomet;
        public int BrojRaspolozivihRaketa;
        public int Domet;
        public BacacRaketa()
        {
            MaksimalniDomet = 300;
            BrojRaspolozivihRaketa = 50;
        }
        public void PovecajDomet(int domet) {
            this.Domet += domet;
        }
        public int DohvatiBrojRaketa() {

            return BrojRaspolozivihRaketa;
        }
        public void NadopuniRakete(int broj) {
            this.BrojRaspolozivihRaketa += broj;

        }
        public int DohvatiDomet() {
            return Domet;
        }


        public override void IspisiLokaciju()
        {
            Console.WriteLine("Lokacija bacaca raketa");
            Console.WriteLine(x);
            Console.WriteLine(y);

        }
    }
}
