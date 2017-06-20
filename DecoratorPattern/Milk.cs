using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Milk : CondimentDecorator
    {
        BeverageComponet Beverage;

        public Milk(BeverageComponet bc)
        {
            Beverage = bc;
        }

        public override float Cost()
        {
            return this.Beverage.Cost() + 4.0f;
        }

      
        public override string GetDescription()
        {
            return this.Beverage.GetDescription()+ " Milk";
        }
    }
}