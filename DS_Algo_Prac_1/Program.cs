using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algo_Prac_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rad, height;
            double area;
            Console.WriteLine("Enter radius of Cylinder:");
            rad = Convert.ToInt32(Console.ReadLine());

            if (rad <= 0)
            {
                do
                {
                    Console.WriteLine("Radius cannot be 0 or negative. Please enter correct radius:");
                    rad = Convert.ToInt32(Console.ReadLine());
                } while (rad <= 0);
            }

            Console.WriteLine("Enter height of Cylinder:");
            height = Convert.ToInt32(Console.ReadLine());

            if (height <= 0)
            {
                do
                {
                    Console.WriteLine("Height cannot be 0 or negative. Please enter correct height:");
                    height = Convert.ToInt32(Console.ReadLine());
                } while (height <= 0);
            }

            area = VolumeOfCylinder(rad, height);

            Console.WriteLine("Area of Cylinder is {0}", area);
            Console.ReadLine();

        }

        public static double VolumeOfCylinder(int radius, int height)
        {
            int radSq = radius * radius;
            double pi = Math.PI;

            double area = pi * radSq * height;
            return area;
        }
    }
}
