using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class BeverageComponet
    {
        public string desc = "Unknown Beverage.";

        //public abstract string GetDescription();

        public virtual string Description
        {
            get { return desc; }
            set { desc = value; }
        }

        //public string GetDescription()
        //{
        //    return Description
        //}

        public abstract float Cost();
    }
}
