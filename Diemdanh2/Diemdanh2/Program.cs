using System;
using static Diemdanh2.animal;

namespace Diemdanh2
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Class Cat: ");
                Cat cat_241 = new Cat();
                cat_241.Eat();
                cat_241.makeSound();
                cat_241.Run();
                Console.WriteLine("\n");

                Console.WriteLine("Class Bird: ");
                Bird bird_241 = new Bird();
                bird_241.Eat();
                bird_241.makeSound();
                bird_241.Fly();

                Console.ReadKey();
            }
        }
    }
