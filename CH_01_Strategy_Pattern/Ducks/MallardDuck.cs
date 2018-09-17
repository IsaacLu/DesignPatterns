using StrategyPattern.Ducks.Behaviors;
using System;

namespace StrategyPattern.Ducks
{
    public class MallardDuck : Duck

    {
        public MallardDuck()
        {
            quackBehavior = new NormallyQuack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard duck.");
        }
    }
}