using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class CondimentDecorator : BeverageComponet
    {
        public override string Description
        {
            get
            {
                return "Add on " + base.Description;
            }

            set
            {
                base.Description = value;
            }
        }

    }
}
