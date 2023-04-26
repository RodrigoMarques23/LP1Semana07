using System;

namespace FillSpheres
{
    public class Sphere
    {
        private Color color;
        private int raio;
        private int throws;
        public Sphere(Color Color, int Raio)
        {
            color = Color;
            raio = Raio;
            throws = 0;
        }
        public void Pop()
        {
            Console.WriteLine("Popped ball");
            raio = 0;
        }
        public void Throw()
        {
            if (raio > 0)
            {
                Console.WriteLine("Ball Thrown");
                throws += 1;
            }
            else
            {
                Console.WriteLine("Cant Throw");
            }
        }
        public int GetTimesThrown()
        {
            return throws;
        }
        public override string ToString()
        {
            return color.ToString() + $"Raio: {raio}, Throws Number: {throws}";
        }
    }
}