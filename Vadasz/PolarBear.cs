using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vadasz
{
    internal class PolarBear : Animal
    {
        const int basePrice = 100000;
        double ar;
        public double Ar
        {
            get { return ar; }
            set { ar = basePrice * 2.4; }
        }
        public override int GetPrice()
        {
            Ar = ar;
            return Convert.ToInt32(ar);
        }
    }
}
