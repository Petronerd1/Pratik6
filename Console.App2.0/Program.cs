using System;

namespace AnimalSound
{
    abstract class Animal
    {
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat says: Meow Meow");
        }
    }
    class Program
    {
        

        static void Main(string[] args)
        {
            Cat mycat = new Cat();
            mycat.animalSound();
            mycat.sleep();
            Console.ReadKey();
        }
        
    }
}
