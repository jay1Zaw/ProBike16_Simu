using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProBike16_Simu
{
    class Product : PEK
    {
        public Product(uint id, int quantity = 0) : base(id, quantity)
        {
            prefix = 'P';
        }
    }
}
