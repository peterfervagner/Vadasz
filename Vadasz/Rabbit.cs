using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vadasz
{
    internal class Rabbit : Animal
    {
        const int basePrice = 100000;
        double ar;
        public double Ar
        {
            get { return ar; }
            set { ar = basePrice * 0.3; }
        }
        public override int GetPrice()
        {
            Ar = ar;
            return Convert.ToInt32(ar);
        }
    }
}
