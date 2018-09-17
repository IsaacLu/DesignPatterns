using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Ducks.Behaviors;

namespace StrategyPattern.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new NormallyQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a model duck.");
        }
    }
}
