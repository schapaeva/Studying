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
            AnimalQueue shelterQueue = new AnimalQueue();
            shelterQueue.Enqueue(new Dog("Doggie1"));
            shelterQueue.Enqueue(new Dog("Doggie2"));
            shelterQueue.Enqueue(new Cat("Kitty1"));
            shelterQueue.Enqueue(new Dog("Doggie3"));
            shelterQueue.Enqueue(new Cat("Kitty2"));
            shelterQueue.Enqueue(new Cat("Kitty3")); 

            Console.WriteLine(shelterQueue.DequeuDog().Name());
            Console.WriteLine(shelterQueue.DequeueAny().Name());
            Console.WriteLine(shelterQueue.DequeueCat().Name());
            Console.ReadKey();
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
            if (dogQueue.Count != 0 && catQueue.Count != 0)
            {
                if (dogQueue.Count == 0)
                {
                    return DequeueCat();
                }

                if (catQueue.Count == 0)
                {
                    return DequeuDog();
                }

                Dog dogPeek = dogQueue.First();
                Cat catPeek = catQueue.First();

                if(dogPeek.IsOlderThan(catPeek))
                {
                    return DequeuDog();
                }
                else
                {
                    return DequeueCat();
                }
            }
            return null;
        }

        public Dog DequeuDog()
        {
            if (dogQueue.First != null)
            {
                Dog dequeuedDog = dogQueue.First();
                dogQueue.RemoveFirst();
                return dequeuedDog;
            }                
            return null;
        }

        public Cat DequeueCat()
        {
            if (catQueue.First != null)
            {
                Cat dequeuedCat = catQueue.First();
                catQueue.RemoveFirst();
                return dequeuedCat;
            }
            return null;
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
