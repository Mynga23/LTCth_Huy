using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diemdanh2
{
    public abstract class animal
    {

            public abstract void Eat();
            public abstract void makeSound();
        
        public class Cat : animal
        {
            public Cat()
            {

            }
            public override void Eat()
            {
                Console.WriteLine("Meo meo meo meo meo");
            }
            public override void makeSound()
            {
                Console.WriteLine("Meo dang tam, dung lam phien!!!");
            }

            public void Run()
            {
                Console.WriteLine("Meo co bon chan");
            }

        }

        public class Bird : animal
        {
            public Bird()
            {

            }
            public override void Eat()
            {
                Console.WriteLine("Meo meo meo meo meo");
            }
            public override void makeSound()
            {
                Console.WriteLine("Meo dang tam, dung lam phien!!!");
            }

            public void Fly()
            {
                Console.WriteLine("Chim co hai canh de bay !!!");
            }

        }
    }

}
