using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiDan
{
    class Vozilo:GameObject
    {
        
        public Vozilo()
        {
            x = 0;
            y = 0;
        }
        public virtual void IspisiLokaciju() {
            Console.WriteLine(x);
            Console.WriteLine(y);

        }
        

    }
}
