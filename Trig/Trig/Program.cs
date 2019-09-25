using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trig
{
    class Exercises
    {
        public double DegToRad(double x)
        {
            return Math.PI * x / 180.0;
        }

        public double RadToDeg(double x)
        {
            return x * (180.0 / Math.PI);
        }

        public double Cos(float a, float h)
        {
            return Math.Cos(a / h);
        }

        public double Sin(float o, float h)
        {
            return Math.Sin(o / h);
        }

        public double Tan(float o, float a)
        {
            return Math.Tan(o / a);
        }

        public double LawSin(double Aside, double angleA, double Bside, double angleB)//Aside = (13 * Sin(79)) / Sin(37)
        {
            double a = Math.Sin(angleA);
            double b = Math.Sin(angleB);
            if (Aside == 0)
            {
                Aside = (Bside * a) / b;
                return Aside;
            }
            else if (Bside == 0)
            {
                Bside = (Aside * a) / b;
                return Bside;
            }
            else if (a == 0)
            {
                a = (Aside * b) / Bside;
                Math.Asin(a);
                return a;
            }
            else if (b == 0)
            {
                b = (Bside * a) / Aside;
                return b;
            }
            else
            {
                return (Aside*b);
            }
        }

        public double LawCos(double angleC, double Aside, double Bside, double Cside)//8^2 = 6^2 + 9^2 - 2(6)(9)cos(C)
        {
            if (angleC == 0)
            {
                angleC = (Math.Pow(Aside, 2) + Math.Pow(Bside, 2) - Math.Pow(Cside, 2)) / (2 * Bside * Aside);
                double a = Math.Acos(angleC);
                return RadToDeg(a);
            }
            else if (Aside == 0)
            {
                Aside = Math.Pow(Bside, 2) + Math.Pow(Cside, 2) - 2*Bside*Cside*Math.Cos(angleC);
                return Aside;
            }
            else if (Bside == 0)
            {
                Bside = Math.Pow(Aside, 2) + Math.Pow(Cside, 2) - 2 * Aside * Cside * Math.Cos(angleC);
                return Bside;
            }
            else if (Cside == 0)
            {
                Cside = Math.Pow(Bside, 2) + Math.Pow(Aside, 2) - 2 * Bside * Aside * Math.Cos(angleC);
                return Cside;
            }
            else
            {
                double angleA = 0;
                LawSin(Cside, angleC, Aside, angleA);
                return 180 - (angleC - angleA);
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Exercises ex = new Exercises();

            //Console.Write(ex.getRad(57));
            Console.WriteLine();

            //Console.Write(ex.getDeg(1));
            Console.WriteLine();

            //Console.Write(ex.LawSin(0, 1.37881, 13, 0.645772));//Aside = (13 * Sin(79)) / Sin(37)
            Console.WriteLine();

            Console.Write(ex.LawCos(0, 6, 9, 8));//8^2 = 6^2 + 9^2 - 2(6)(9)cos(C)
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
