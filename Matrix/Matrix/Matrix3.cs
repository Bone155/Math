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
        float[,] m = new float[3, 3];

        float Xx = m[0, 0];
        float Xy = m[0, 1];
        float Xz = m[0, 2];

        float Yx = m[1, 0];
        float Yy = m[1, 1];
        float Yz = m[1, 2];

        float Zx = m[2, 0];
        float Zy = m[2, 1];
        float Zz = m[2, 2];

        public Matrix3(float Xx, float Xy, float Xz, float Yx, float Yy, float Yz, float Zx, float Zy, float Zz)
        {
            this.Xx = Xx;
            this.Xy = Xy;
            this.Xz = Xz;

            this.Yx = Yx;
            this.Yy = Yy;
            this.Yz = Yz;

            this.Zx = Zx;
            this.Zy = Zy;
            this.Zz = Zz;
        }

        public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
        {
            return new Matrix3(lhs.Xx * rhs.Xx + lhs.Yx * rhs.Xy + lhs.Zx * rhs.Xz,
                                lhs.Xx * rhs.Yx + lhs.Yx * rhs.Yy + lhs.Zx * rhs.Yz,
                                lhs.Xx * rhs.Zx + lhs.Yx * rhs.Zy + lhs.Zx * rhs.Zz,
                                lhs.Xy * rhs.Xx + lhs.Yy * rhs.Xy + lhs.Zy * rhs.Xz,
                                lhs.Xy * rhs.Yx + lhs.Yy * rhs.Yy + lhs.Zy * rhs.Yz,
                                lhs.Xy * rhs.Zx + lhs.Yy * rhs.Zy + lhs.Zy * rhs.Zz,
                                lhs.Xz * rhs.Xx + lhs.Yz * rhs.Xy + lhs.Zz * rhs.Xz,
                                lhs.Xz * rhs.Yx + lhs.Yz * rhs.Yy + lhs.Zz * rhs.Yz,
                                lhs.Xz * rhs.Zx + lhs.Yz * rhs.Zy + lhs.Zz * rhs.Zz);
        }

        public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
        {
            return new Vector3((lhs.Xx * rhs.x) + (lhs.Xy * rhs.y) + (lhs.Xz * rhs.z),
                                (lhs.Yx * rhs.x) + (lhs.Yy * rhs.y) + (lhs.Yz * rhs.z),
                                (lhs.Zx * rhs.x) + (lhs.Zy * rhs.y) + (lhs.Zz * rhs.z));
        }

        public Matrix3 GetTansposed()
        {
            // flip row and column
            return new Matrix3(Xx, Yx, Zx,
                                Xy, Yy, Zy,
                                Xz, Yz, Zz);
        }
    }
}
