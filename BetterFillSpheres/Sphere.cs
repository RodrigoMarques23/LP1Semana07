using System;

namespace FillSpheres
{
    public class Sphere
    {
        private int throws;
        //proprieties
        public Color color { get; set; }
        public int raio { get; set; }

        public int Throws { get { return throws; } set { throws = 0; } }


        /// <summary>
        /// Pop the ball
        /// </summary>
        public void Pop()
        {
            Console.WriteLine("Popped ball");
            raio = 0;
        }

        /// <summary>
        /// Throw the ball
        /// </summary>
        public void Throw()
        {
            if (raio > 0)
            {
                Console.WriteLine("Ball Thrown");
                throws += 1;
            }
            else
            {
                Console.WriteLine("Can't Throw");
            }
        }
        /// <summary>
        /// Get throws number
        /// </summary>
        /// <returns></returns>
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