using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MathForGames
{
    class Exercises
    {
        public float basicFunction(float x)
        {
            float result = (x*x) + (2*x) - 7;
            return result;
        }

        public void Quad(float a, float b, float c)
        {
            double s = (b * b) - (4 * a * c);
            double x1;
            double x2;
            if (s < 0)
            {
                x1 = double.NaN;
                x2 = double.NaN;
            }
            else
            {
                double sq = Math.Sqrt(s);
                x1 = (-b + sq) / (2 * a);
                x2 = (-b - sq) / (2 * a);
            }
            Console.WriteLine(x1 + " and " + x2);
        }

        public float Linear(float s, float e, float t)
        {
            float eq = s + (t * (e - s));
            return eq;
        }

        public double Distance(float x1, float y1, float x2, float y2)
        {
            double x = Math.Pow(x2 - x1, 2);
            double y = Math.Pow(y2 - y1, 2);
            double result = Math.Sqrt(x + y);
            return result;
        }

        public float Inner(float Px, float Qx, float Py, float Qy, float Pz, float Qz)
        {
            float result = (Px*Qx) + (Py*Qy) + (Pz*Qz);
            return result;
        }

        public double Plane(float ax, float by, float cz, float d, float a, float b, float c)
        {
            double num = ax + by + cz + d;
            double de = Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2);
            double result = num / (Math.Sqrt(de));
            return result;
        }

        public double Cubic(float t, float p0, float p1, float p2, float p3)
        {
            double result = (Math.Pow(1-t, 3)*p0) + 3 * (Math.Pow(1-t, 2)*t*p1) + 3 * (1-t) * (Math.Pow(t, 2))*p2 + (Math.Pow(t, 3))*p3;
            return result;
        }
    }
    class Program
    {
        static void Main()
        {
            Exercises ex = new Exercises();

            Console.Write(ex.basicFunction(5));
            Console.WriteLine();
            
            //Console.Write(ex.Quad(3, 4, 5));
            Console.WriteLine();

            Console.Write(ex.Linear(4, 8, 9));
            Console.WriteLine();

            Console.Write(ex.Distance(3,4,9,12));
            Console.WriteLine();

            Console.Write(ex.Inner(3,6,5,7,2,9));
            Console.WriteLine();

            Console.Write(ex.Plane(4,8,3,7,3,7,2));
            Console.WriteLine();

            Console.Write(ex.Cubic(3, 6, 8, 9,5));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
