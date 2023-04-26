using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {

            Sphere bola = new Sphere { color = new Color { red = 25, green = 0, blue = 0 }, raio = 5 };
            bola.Throw();
            bola.Throw();
            bola.Pop();
            bola.Throw();
            Console.WriteLine(bola.ToString());

            Sphere ozi = new Sphere { color = new Color { red = 120, green = 89, blue = 56, alpha = 80 }, raio = 2 };
            ozi.Throw();
            ozi.Throw();
            ozi.Throw();
            ozi.Throw();
            ozi.Throw();
            ozi.Throw();
            ozi.Throw();
            ozi.Pop();
            Console.WriteLine(ozi.ToString());
        }
    }
}
