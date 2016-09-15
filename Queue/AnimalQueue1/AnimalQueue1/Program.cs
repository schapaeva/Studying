using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalQueue1
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class AnimalQueue
    {
        LinkedList<Dog> dogQueue = new LinkedList<Dog>();
        LinkedList<Cat> catQueue = new LinkedList<Cat>();
        private int order = 0;
        
        public void Enqueue(Animal a)
        {
            a.SetOrder(order);
            order++;

            if(a is Dog)
            {
                dogQueue.AddLast((Dog)a);
            }
            if(a is Cat)
            {
                catQueue.AddLast((Cat)a);
            }
        } 

        public Animal DequeueAny()
        {

        }

        public Dog DequeuDog()
        {
            if (dogQueue.Last != null)
            {
                Dog dequeuedDog = dogQueue.Last;
                dogQueue.RemoveLast();
                return dequeuedDog;
            }                
            return null;
        }

        public Cat DequeueCat()
        {

        }
    }

    public abstract class Animal
    {
        private int order;
        protected string name;

        public abstract string Name();

        public Animal(string n)
        {
            name = n;
        }

        public int GetOrder()
        {
            return order;
        }

        public void SetOrder(int ord)
        {
            order = ord;
        }

        public bool IsOlderThan(Animal a)
        {
            return a.GetOrder() > this.order;
        }
    }

    public class Dog : Animal
    {
        public Dog(string n) : base(n)
        { }

        public override string Name()
        {
            return "Dog: " + name;
        }
    }

    public class Cat : Animal
    {
        public Cat(string n) : base(n) { }

        public override string Name()
        {
            return "Cat: " + name;
        }
    }
}
