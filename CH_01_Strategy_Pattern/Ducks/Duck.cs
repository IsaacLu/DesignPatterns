using StrategyPattern.Ducks.Behaviors;
using System;

namespace StrategyPattern.Ducks
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        public Duck()
        {
        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}