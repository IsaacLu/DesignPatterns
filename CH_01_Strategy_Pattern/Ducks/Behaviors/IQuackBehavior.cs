using System;

namespace StrategyPattern.Ducks.Behaviors
{
    public interface IQuackBehavior
    {
        void Quack();
    }

    public class NormallyQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }

    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }

    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}