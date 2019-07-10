using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiDan
{


    class Vojnik :GameObject
    {
       
        public int BrzinaKretanja;
       

        public Vojnik()
        {
            x = 0;
            y = 0;
            Energija = 100;
        }

        public virtual void IspisiEnergijuILokaciju() {

            Console.WriteLine(Energija + y + x );
        }
        public void Pucaj() {

            Console.WriteLine("Pucam");
        }

      

    }
}
