using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {

            Sphere bola = new Sphere(new Color(120, 0, 0), 5);
            bola.Throw();
            bola.Throw();
            bola.Pop();
            bola.Throw();
            Console.WriteLine(bola.ToString());

            Sphere ozi = new Sphere(new Color(120, 89, 56, 80), 2);
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
