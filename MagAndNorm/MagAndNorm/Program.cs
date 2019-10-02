using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagAndNorm
{
    struct Vector3
    {
        float x, y, z;
        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z);
        }

        public float distance(Vector3 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);
        }

        public float distanceSqr(Vector3 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            return diffX * diffX + diffY * diffY + diffZ * diffZ;
        }

        public void Normalize()
        {
            float m = Magnitude();
            x /= m;
            y /= m;
            z /= m;
        }

        public Vector3 GetNormalised()
        {
            Normalize();
            return new Vector3(x, y, z);
        }

        public float Dot(Vector3 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z;
        }

        public Vector3 Cross(Vector3 rhs)
        {
            return new Vector3(
           y * rhs.z - z * rhs.y,
           z * rhs.x - x * rhs.z,
           x * rhs.y - y * rhs.x);
        }

        float AngleBetween(Vector3 other)
        {
            // normalise the vectors
            Vector3 a = GetNormalised();
            Vector3 b = other.GetNormalised();
            // calculate the dot product
            float d = a.x * b.x + a.y * b.y + a.z * b.z;
            // return the angle between them
            return (float)Math.Acos(d);
        }
    }

    struct Vector2
    {
        float x, y;
        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        //Vector2 GetPerpendicularRH()
        //{
        //    return { -y, x };
        //}
        //Vector2 GetPerpendicularLH()
        //{
        //    return { y, -x };
        //}

        public float distance(Vector2 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY);
        }

        public float distanceSqr(Vector2 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            return diffX * diffX + diffY * diffY;
        }

        public float Dot(Vector2 rhs)
        {
            return x * rhs.x + y * rhs.y;
        }
    }

    class Program
    {
        static void Main()
        {
            //int.TryParse(Console.ReadLine(), out int input);

            Vector3 magVec = new Vector3(0, 1, 2);

            Vector2 magVec2 = new Vector2(3, -2);


            Vector3 distVec = new Vector3(0, 1, 2);
            Vector3 distVec2 = new Vector3(9, -2, 7);

            Vector2 dotVec = new Vector2(1, 0);
            Vector2 dotVec2 = new Vector2(0, 1);

            Vector3 dotVec4 = new Vector3(2, 3, 1);
            Vector3 dotVec6 = new Vector3(-3, 1, 2);

            Vector3 angleVec = new Vector3(-0.5f, 0, 2);
            Vector3 angleVec2 = new Vector3(-1, 0, -1);

            Vector2 angleVec4 = new Vector2(1, 3);
            Vector2 angleVec6 = new Vector2(0.5f, -0.25f);


            //Magnitudes and Normalization
            //------------------------------------------------------------------------------------
            //Console.WriteLine(magVec.Magnitude());
            Console.WriteLine();

            //Console.WriteLine(magVec2.Magnitude());
            Console.WriteLine();
            
            //Console.WriteLine(magVec.GetNormalised());
            Console.WriteLine();

            //Console.Write(distVec.distance(distVec2));
            Console.WriteLine();

            //Console.WriteLine(distVec4.distance(distVec6));
            Console.WriteLine();

            //Dot Products
            //------------------------------------------------------------------------------------
            //Console.WriteLine(dotVec.Dot(dotVec2));
            Console.WriteLine();

            //Console.WriteLine(dotVec4.Dot(dotVec6));
            Console.WriteLine();

            //Console.WriteLine(angleVec.Dot(angleVec2));
            Console.WriteLine();

            //Console.WriteLine(angleVec4.Dot(angleVec6));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
