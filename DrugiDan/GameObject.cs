using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiDan
{
    class GameObject
    {
        public int x;
        public int y;
        public int Energija;


        public void PomakniseGore() {

            y++;
        }
        public void PomakniseDolje()
        {
            y--;

        }
        public void PomakniseLijevo()
        {

            x++;
        }
        public void PomakniseDesno()
        {
            x--;

        }


    }

}


    

