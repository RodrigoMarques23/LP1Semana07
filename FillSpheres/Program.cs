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
        }
    }
}
