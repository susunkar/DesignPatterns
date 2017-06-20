using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        BeverageComponet Beverage;

        public Mocha(BeverageComponet bc)
        {
            this.Beverage = bc;
        }
        public override float Cost()
        {
            return this.Beverage.Cost() + 3.0f;
        }

        public override string GetDescription()
        {
            return this.Beverage.Description + " Mocha";
        }

    }
}
