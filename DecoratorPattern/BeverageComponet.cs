using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class BeverageComponet
    {
        public string Description = "Unknown Beverage.";
       
        public string GetDescription()
        {
            return this.Description;
        }
        public abstract float Cost();
    }
}
