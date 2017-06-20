using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class HouseBlend : BeverageComponet
    {
        public HouseBlend()
        {
            Description = "HouseBlend Beverage";
        }
        public override float Cost()
        {
            return 0.99f;
        }
    }
}
