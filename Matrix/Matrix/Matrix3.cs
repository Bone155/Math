using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    struct Vector3
    {
        public float x, y, z;
        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Print()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
    }

    class Matrix3
    {
        float[,] m = new float[3, 3];

        public Matrix3(float Xx, float Xy, float Xz, float Yx, float Yy, float Yz, float Zx, float Zy, float Zz)
        {
            m[0, 0] = Xx;
            m[1, 0] = Xy;
            m[2, 0] = Xz;

            m[0, 1] = Yx;
            m[1, 1] = Yy;
            m[2, 1] = Yz;

            m[0, 2] = Zx;
            m[1, 2] = Zy;
            m[2, 2] = Zz;
        }

        public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
        {
            return new Matrix3
            ( 
                //X
                lhs.m[0, 0] * rhs.m[0, 0] + lhs.m[1, 0] * rhs.m[0, 1] + lhs.m[2, 0] * rhs.m[0, 2],
                lhs.m[0, 0] * rhs.m[1, 0] + lhs.m[1, 0] * rhs.m[1, 1] + lhs.m[2, 0] * rhs.m[1, 2],
                lhs.m[0, 0] * rhs.m[2, 0] + lhs.m[1, 0] * rhs.m[2, 1] + lhs.m[2, 0] * rhs.m[2, 2],

                //Y
                lhs.m[0, 1] * rhs.m[0, 0] + lhs.m[1, 1] * rhs.m[0, 1] + lhs.m[2, 1] * rhs.m[0, 2],
                lhs.m[0, 1] * rhs.m[1, 0] + lhs.m[1, 1] * rhs.m[1, 1] + lhs.m[2, 1] * rhs.m[1, 2],
                lhs.m[0, 1] * rhs.m[2, 0] + lhs.m[1, 1] * rhs.m[2, 1] + lhs.m[2, 1] * rhs.m[2, 2],

                //Z
                lhs.m[0, 2] * rhs.m[0, 0] + lhs.m[1, 2] * rhs.m[0, 1] + lhs.m[2, 2] * rhs.m[0, 2],
                lhs.m[0, 2] * rhs.m[1, 0] + lhs.m[1, 2] * rhs.m[1, 1] + lhs.m[2, 2] * rhs.m[1, 2],
                lhs.m[0, 2] * rhs.m[2, 0] + lhs.m[1, 2] * rhs.m[2, 1] + lhs.m[2, 2] * rhs.m[2, 2]
            );
        }
        
        public void Print()
        {
            Console.WriteLine(m[0, 0].ToString() + ", " + m[1, 0].ToString() + ", " + m[2, 0].ToString());
            Console.WriteLine(m[0, 1].ToString() + ", " + m[1, 1].ToString() + ", " + m[2, 1].ToString());
            Console.WriteLine(m[0, 2].ToString() + ", " + m[1, 2].ToString() + ", " + m[2, 2].ToString());
        }

        public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
        {
            return new Vector3((lhs.m[0, 0] * rhs.x) + (lhs.m[0, 1] * rhs.y) + (lhs.m[0, 2] * rhs.z),
                                (lhs.m[1, 0] * rhs.x) + (lhs.m[1, 1] * rhs.y) + (lhs.m[1, 2] * rhs.z),
                                (lhs.m[1, 0] * rhs.x) + (lhs.m[2, 1] * rhs.y) + (lhs.m[2, 2] * rhs.z));
        }

        public Matrix3 GetTansposed()
        {
            // flip row and column
            return new Matrix3
            (
                m[0, 0], m[0, 1], m[0, 2],
                m[1, 0], m[1, 1], m[1, 2],
                m[2, 0], m[2, 1], m[2, 2]
            );
        }

        public Vector3 GetXAxis()
        {
            return new Vector3(m[0, 0], m[1, 0], m[2, 0]);
        }
        public Vector3 GetYAxis()
        {
            return new Vector3(m[0, 1], m[1, 1], m[2, 1]);
        }

        public Vector3 GetZAxis()
        {
            return new Vector3(m[0, 2], m[1, 2], m[2, 2]);
        }

        public static Matrix3 Indentity()
        {
            //Flat identity
            return new Matrix3
            (
                1, 0, 0,
                0, 1, 0,
                0, 0, 1
            );
        }
    }
}
