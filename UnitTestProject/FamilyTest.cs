using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns;

namespace UnitTestProject
{
    [TestClass]
    public class FamilyTest
    {
        [TestMethod]
        public void MallarDuck()
        {
            Duck duck = new MallardDuck();

            duck.Display();
            duck.SetFlyBehavior(new FlyNoWay());
            duck.SetQuackBehavior(new MuteQuack());
            duck.PerformFly();
            duck.PerformQuack();
        }
    }
}
