using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Duck
    {
        IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;

        internal IFlyBehavior FlyBehavior { get { return flyBehavior; } set { flyBehavior = value; } }
        internal IQuackBehavior QuackBehavior { get { return quackBehavior; } set { quackBehavior = value; } }

        public void Swim()
        {
            Console.WriteLine("I'm Swiming..");
        }
        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }
        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void SetQuackBehavior(IQuackBehavior qb)
        {
            QuackBehavior = qb;
        }
    }

    public class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("looks like Mallardduck.");
            
        }
    }
}
