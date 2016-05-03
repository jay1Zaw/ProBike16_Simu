using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProBike16_Simu
{
    class PurchasePart : PEK
    {
        public PurchasePart(uint id, int quantity = 0) : base(id, quantity)
        {
            prefix = 'K';
        }
    }
}
