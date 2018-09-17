using System;

namespace StrategyPattern.Ducks.Behaviors
{
    public interface IFlyBehavior
    {
        void Fly();
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly.");
        }
    }

    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}