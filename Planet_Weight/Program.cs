using System;

namespace PlanetWeight
{
    enum Planet
    {
        MERCURY,
        VENUS,
        EARTH,
        MARS,
        JUPITER,
        SATURN,
        URANUS,
        NEPTUNE
    }

    class Program
    {
        static void Main(string[] args)
        {
            double[] gravity = { 0.38, 0.91, 1.0, 0.38, 2.34, 1.06, 0.92, 1.19 };

            Console.Write("Enter your weight on Earth: ");
            double earthWeight = Convert.ToDouble(Console.ReadLine());

            foreach (Planet p in Enum.GetValues(typeof(Planet)))
            {
                double weight = earthWeight * gravity[(int)p];
                Console.WriteLine("Weight on " + p + " = " + weight);
            }
        }
    }
}