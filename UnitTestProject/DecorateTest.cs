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
            // DarkRoastBeverage beverage1 = new DarkRoastBeverage();

            //  Console.WriteLine(" cost : {0}", beverage1.Cost());

            beverage = new Milk(new Mocha(beverage));
            
            Console.WriteLine("Name: {0}", beverage.Description);
            Console.WriteLine("Total cost: {0}", beverage.Cost());
        }
    }
}
