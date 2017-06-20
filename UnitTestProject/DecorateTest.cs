using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DecoratorPattern;

namespace UnitTestProject
{
    [TestClass]
    public class DecorateTest
    {
        [TestMethod]
        public void CustomDarkRoastBevarageOrder()
        {
            BeverageComponet beverage = new DarkRoastBeverage();

            beverage = new Milk(beverage);

            Console.WriteLine("{0}", beverage.GetDescription());
            Console.WriteLine("{0}", beverage.Cost());
        }
    }
}
