using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DarkRoastBeverage : BeverageComponet
    {
        public DarkRoastBeverage()
        {
            Description = "DarkRoastBeverage Beverage";
        }
      
        public override float Cost()
        {
            return 1f;
        }
    }
}
