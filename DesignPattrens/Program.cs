using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck =new MallardDuck();
            duck.performFly();
            duck.performQuck();
            duck.SetFlyBehavior(new flyWithRocket());
            duck.performFly();
            Console.ReadKey();
        }
    }
    public interface FlyBehavior 
    {
        void fly();
    }
    public interface QuackBehavior 
    {
        void quack();
    }

    class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("fly with wings ");
        }
    }
    class flyWithNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly ");
        }
    }
    class flyWithRocket : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("fly with rocket ");
        }
    }

    class Quack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<<Quack>>");
        }
    }
    class Sqack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Squack >>");
        }
    }

    abstract class Duck
    {
        public FlyBehavior flyBehavior { get; set; }
        public QuackBehavior quackBehavior { get; set; }

        abstract public void display();
        public void swim()
        {
            Console.WriteLine("All Quack can swim ");
        }
        public void performQuck()
        {
            this.quackBehavior.quack();
        }
        public void performFly()
        {
            this.flyBehavior.fly();
        }

        public void SetFlyBehavior(FlyBehavior fb)
        {
            this.flyBehavior = fb;
        }
        public void SetQuackBehavior( QuackBehavior qb)
        {
            this.quackBehavior= qb;
        }
    }
    class MallardDuck : Duck    
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("Iam Mallard dack");
        }
    }
    class RedheadDuck : Duck
    {
        public override void display()
        {
            
        }
    }
    class RubberDuck : Duck 
    {
        public override void display()
        {
            
        }
    }
    class WoodenDuck : Duck
    {
        public override void display()
        {
             
        }
    }


     
}
