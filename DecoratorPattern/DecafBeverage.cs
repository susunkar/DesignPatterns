using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class DecafBeverage : BeverageComponet
    {
        public DecafBeverage()
        {
            Description = "DecafBeverage Beverage";
        }
      
        public override float Cost()
        {
            return 2.5f;
        }
    }
}
