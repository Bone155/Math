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
    }

    class Matrix3
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9;

        public Matrix3(float m1, float m4, float m7, float m2, float m5, float m8, float m3, float m6, float m9)
        {
            this.m1 = m1;
            this.m4 = m4;
            this.m7 = m7;
            this.m2 = m2;
            this.m5 = m5;
            this.m8 = m8;
            this.m3 = m3;
            this.m6 = m6;
            this.m9 = m9;
        }

        public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
        {
            return new Matrix3(lhs.m1 * rhs.m1 + lhs.m4 * rhs.m2 + lhs.m7 * rhs.m3,
                                lhs.m1 * rhs.m4 + lhs.m4 * rhs.m5 + lhs.m7 * rhs.m6,
                                lhs.m1 * rhs.m7 + lhs.m4 * rhs.m8 + lhs.m7 * rhs.m9,
                                lhs.m2 * rhs.m1 + lhs.m5 * rhs.m2 + lhs.m8 * rhs.m3,
                                lhs.m2 * rhs.m4 + lhs.m5 * rhs.m5 + lhs.m8 * rhs.m6,
                                lhs.m2 * rhs.m7 + lhs.m5 * rhs.m8 + lhs.m8 * rhs.m9,
                                lhs.m3 * rhs.m1 + lhs.m6 * rhs.m2 + lhs.m9 * rhs.m3,
                                lhs.m3 * rhs.m4 + lhs.m6 * rhs.m5 + lhs.m9 * rhs.m6,
                                lhs.m3 * rhs.m7 + lhs.m6 * rhs.m8 + lhs.m9 * rhs.m9);
        }

        public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
        {
            return new Vector3((lhs.m1 * rhs.x) + (lhs.m2 * rhs.y) + (lhs.m3 * rhs.z),
                                (lhs.m4 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m6 * rhs.z),
                                (lhs.m7 * rhs.x) + (lhs.m8 * rhs.y) + (lhs.m9 * rhs.z));
        }

        public Matrix3 GetTansposed()
        {
            // flip row and column
            return new Matrix3(m1, m4, m7,
                                m2, m5, m8,
                                m3, m6, m9);
        }
    }
}
