using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{

    struct Matrix2
    {
        float m1, m2, m3, m4;

        public Matrix2(float Xx, float Xy, float Yx, float Yy)
        {
            //X
            m1 = Xx;
            m2 = Xy;

            //Y
            m3 = Yx;
            m4 = Yy;
        }

        public static Matrix2 operator *(Matrix2 lhs, Matrix2 rhs)
        {
            return new Matrix2
            (
                //X
                lhs.m1 * rhs.m1 + lhs.m2 * rhs.m3,
                lhs.m1 * rhs.m2 + lhs.m2 * rhs.m4,

                //Y
                lhs.m3 * rhs.m1 + lhs.m4 * rhs.m2,
                lhs.m3 * rhs.m2 + lhs.m4 * rhs.m4
            );
        }

        public void Print()
        {
            Console.WriteLine(m1.ToString() + ", " + m2.ToString());
            Console.WriteLine(m3.ToString() + ", " + m4.ToString());
        }

        public static Vector2 operator *(Matrix2 lhs, Vector2 rhs)
        {
            return new Vector2((lhs.m1 * rhs.x) + (lhs.m2 * rhs.y),
                                (lhs.m3 * rhs.x) + (lhs.m4 * rhs.y));
        }

        public Matrix2 GetTansposed()
        {
            // flip row and column
            return new Matrix2
            (
                m1, m2,
                m3, m4
            );
        }

        public Vector2 GetXAxis()
        {
            return new Vector2(m1, m2);
        }

        public Vector2 GetYAxis()
        {
            return new Vector2(m3, m4);
        }

        public static Matrix2 Indentity()
        {
            //Flat identity
            return new Matrix2
            (
                1, 0,
                0, 1
            );
        }

        public Matrix2 Set(Matrix2 matrix)
        {
            return matrix;
        }

        public void SetScaled(Vector2 v)
        {
            m1 = v.x; m3 = 0;
            m2 = 0; m4 = v.y;
        }

        public void SetRotateX(double radians)
        {
            Matrix2 m = new Matrix2((float)Math.Cos(radians), (float)-Math.Sin(radians), (float)Math.Sin(radians), (float)Math.Cos(radians));
            Set(m);
        }

        public void SetRotateY(double radians)
        {
            Matrix2 m = new Matrix2((float)Math.Cos(radians), (float)Math.Sin(radians), (float)-Math.Sin(radians), (float)Math.Cos(radians));
            Set(m);
        }
    }

    class Program
    {
        static void Main()
        {
            //int.TryParse(Console.ReadLine(), out int input);
            Matrix3 mat1 = new Matrix3(1, 4, 7, 2, 5, 8, 3, 6, 9);
            Matrix3 matrix1 = new Matrix3(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Matrix3 matrix2 = new Matrix3(9, 8, 7, 6, 5, 4, 3, 2, 1);
            Matrix3 matrix3 = matrix1 * matrix2;

            Matrix3 matrix4 = new Matrix3(1, 1, 1, 1, 1, 1, 1, 1, 1);
            Vector3 vec3 = new Vector3(2, 4, 6);
            Vector3 matrix5 = matrix3 * vec3;

            //Console.Write(matrix*matrix);
            //Console.WriteLine("Matrix 3 * Matrix 3");
            //matrix3.Print();

            //Console.WriteLine("\n\nVector 3 * Matrix 3");
            //Console.WriteLine(matrix5.x + ", \n" + matrix5.y + ", \n" + matrix5.z);

            //Console.WriteLine("\n\nIdentity of Matrix 3");
            //Matrix3 mat3 = Matrix3.Indentity();
            //mat3.Print();

            //Console.WriteLine("\n\nGet X Axis of Matrix Identity");
            //mat3.GetXAxis().Print();

            //Console.WriteLine("\n\nGet Y Axis of Matrix Identity");
            //mat3.GetYAxis().Print();

            //Console.WriteLine("\n\nGet Z Axis of Matrix Identity");
            //mat3.GetZAxis().Print();

            //Console.WriteLine("\n\nNon Transposed Example");
            //mat1.Print();

            //Console.WriteLine("\nTransposed Example");
            //mat1.GetTansposed().Print();

            Console.WriteLine();

            //Matrices transformed


            Console.ReadKey();
        }
    }
}
