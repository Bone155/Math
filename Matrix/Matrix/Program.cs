using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    struct Vector4
    {
        public float x, y, z, w;

        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z + w * w);
        }

        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z + w * w);
        }

        public void Normalize()
        {
            float m = Magnitude();
            x /= m;
            y /= m;
            z /= m;
            w /= m;
        }

        public Vector4 GetNormalised()
        {
            Normalize();
            return new Vector4(x, y, z, w);
        }

        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
           lhs.x + rhs.x,
           lhs.y + rhs.y,
           lhs.z + rhs.z,
           lhs.w + rhs.w);
        }

        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
           lhs.x - rhs.x,
           lhs.y - rhs.y,
           lhs.z - rhs.z,
           lhs.w - rhs.w);
        }

        public static Vector4 operator *(Vector4 lhs, float rhs)
        {
            return new Vector4(
           lhs.x * rhs,
           lhs.y * rhs,
           lhs.z * rhs,
           lhs.w * rhs);
        }

        public static Vector4 operator /(Vector4 lhs, float rhs)
        {
            return new Vector4(
           lhs.x / rhs,
           lhs.y / rhs,
           lhs.z / rhs,
           lhs.w / rhs);
        }

        public Vector4 Cross(Vector4 rhs)
        {
            return new Vector4(
           y * rhs.z - z * rhs.y,
           z * rhs.x - x * rhs.z,
           x * rhs.y - y * rhs.x,
           0);
        }

        public float Dot(Vector4 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z + w * rhs.w;
        }
    }

    struct Vector3
    {
        public float x, y, z;
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

        public void Print()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
    }

    struct Vector2
    {
        public float x, y;
        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine(x + ", " + y);
        }
    }

    struct Matrix4
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16;
        public Matrix4(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9, float m10, float m11, float m12, float m13, float m14, float m15, float m16)
        {
            //X
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
            this.m4 = m4;

            //Y
            this.m5 = m5;
            this.m6 = m6;
            this.m7 = m7;
            this.m8 = m8;
            
            //Z
            this.m9 = m9;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            
            //W
            this.m13 = m13;
            this.m14 = m14;
            this.m15 = m15;
            this.m16 = m16;
        }

        public static Matrix4 operator *(Matrix4 lhs, Matrix4 rhs)
        {
            return new Matrix4
            (
                //X
                rhs.m1 * lhs.m1 + rhs.m2 * lhs.m5 + rhs.m3 * lhs.m9 + rhs.m4 * lhs.m13,
                rhs.m1 * lhs.m2 + rhs.m2 * lhs.m6 + rhs.m3 * lhs.m10 + rhs.m4 * lhs.m14,
                rhs.m1 * lhs.m3 + rhs.m2 * lhs.m7 + rhs.m3 * lhs.m11 + rhs.m4 * lhs.m15,
                rhs.m1 * lhs.m4 + rhs.m2 * lhs.m8 + rhs.m3 * lhs.m12 + rhs.m4 * lhs.m16,

                //Y
                rhs.m5 * lhs.m1 + rhs.m6 * lhs.m5 + rhs.m7 * lhs.m9 + rhs.m8 * lhs.m13,
                rhs.m5 * lhs.m2 + rhs.m6 * lhs.m6 + rhs.m7 * lhs.m10 + rhs.m8 * lhs.m14,
                rhs.m5 * lhs.m3 + rhs.m6 * lhs.m7 + rhs.m7 * lhs.m11 + rhs.m8 * lhs.m15,
                rhs.m5 * lhs.m4 + rhs.m6 * lhs.m8 + rhs.m7 * lhs.m12 + rhs.m8 * lhs.m16,

                //Z
                rhs.m9 * lhs.m1 + rhs.m10 * lhs.m5 + rhs.m11 * lhs.m9 + rhs.m12 * lhs.m13,
                rhs.m9 * lhs.m2 + rhs.m10 * lhs.m6 + rhs.m11 * lhs.m10 + rhs.m12 * lhs.m14,
                rhs.m9 * lhs.m3 + rhs.m10 * lhs.m7 + rhs.m11 * lhs.m11 + rhs.m12 * lhs.m15,
                rhs.m9 * lhs.m4 + rhs.m10 * lhs.m8 + rhs.m11 * lhs.m12 + rhs.m12 * lhs.m16,

                //W
                rhs.m13 * lhs.m1 + rhs.m14 * lhs.m5 + rhs.m15 * lhs.m9 + rhs.m16 * lhs.m13,
                rhs.m13 * lhs.m2 + rhs.m14 * lhs.m6 + rhs.m15 * lhs.m10 + rhs.m16 * lhs.m14,
                rhs.m13 * lhs.m3 + rhs.m14 * lhs.m7 + rhs.m15 * lhs.m11 + rhs.m16 * lhs.m15,
                rhs.m13 * lhs.m4 + rhs.m14 * lhs.m8 + rhs.m15 * lhs.m12 + rhs.m16 * lhs.m16
            );
        }

        public static Vector4 operator *(Matrix4 lhs, Vector4 rhs)
        {
            return new Vector4
            (
                //X
                (rhs.x * lhs.m1) + (rhs.y * lhs.m5) + (rhs.z * lhs.m9) + (rhs.w * lhs.m13),

                //Y
                (rhs.x * lhs.m2) + (rhs.y * lhs.m6) + (rhs.z * lhs.m10) + (rhs.w * lhs.m14),

                //Z
                (rhs.x * lhs.m3) + (rhs.y * lhs.m7) + (rhs.z * lhs.m11) + (rhs.w * lhs.m15),

                //W
                (rhs.x * lhs.m4) + (rhs.y * lhs.m8) + (rhs.z * lhs.m12) + (rhs.w * lhs.m16)
            );
        }

        public static Matrix4 CreateIdentity()
        {
            return new Matrix4(1.0f, 0.0f, 0.0f, 0.0f,
                               0.0f, 1.0f, 0.0f, 0.0f,
                               0.0f, 0.0f, 1.0f, 0.0f,
                               0.0f, 0.0f, 0.0f, 1.0f);
        }

        public Matrix4 Set(Matrix4 matrix)
        {
            return matrix;
        }

        public void SetScaled(float x, float y, float z)
        {
            m1 = x; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = y; m7 = 0; m8 = 0;
            m9 = 0; m10 = 0; m11 = z; m12 = 0;
            m13 = 0; m14 = 0; m15 = 0; m16 = 1;
        }

        public void SetRotateX(double radians)
        {
            Matrix4 m = new Matrix4(1, 0, 0, 0, 
                                    0, (float)Math.Cos(radians), (float)Math.Sin(radians), 0, 
                                    0, (float)-Math.Sin(radians), (float)Math.Cos(radians), 0, 
                                    0, 0, 0, 1);
            Set(m);
        }

        public void SetRotateY(double radians)
        {
            Matrix4 m = new Matrix4((float)Math.Cos(radians), 0, (float)Math.Sin(radians), 0, 
                                    0, 1, 0, 0,
                                    (float)Math.Sin(radians), 0, (float)Math.Cos(radians), 0, 
                                    0, 0, 0, 1);
            Set(m);
        }

        public void SetRotateZ(double radians)
        {
            Matrix4 m = new Matrix4((float)Math.Cos(radians), (float)-Math.Sin(radians), 0, 0,
                                    (float)-Math.Sin(radians), (float)Math.Cos(radians), 0, 0, 
                                    0, 0, 1, 0, 
                                    0, 0, 0, 1);
            Set(m);
        }

        public void Scale(float x, float y, float z)
        {
            Matrix4 m = new Matrix4();
            m.SetScaled(x, y, z);
            Set(m);
        }

        public void RotateX(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateX(radians);
            Set(m);
        }

        public void RotateY(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateY(radians);
            Set(m);
        }

        public void RotateZ(double radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateZ(radians);
            Set(m);
        }

        public void SetTranslation(float x, float y, float z)
        {
            m13 = x; m14 = y; m15 = z; m16 = 1;
        }

        void Translate(float x, float y, float z)
        {
            // apply vector offset
            m13 += x; m14 += y; m15 += z;
        }
    }

    struct Matrix3
    {
        //float[,] m = new float[3, 3];
        float m1, m2, m3, m4, m5, m6, m7, m8, m9;

        public Matrix3(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;

            this.m4 = m4;
            this.m5 = m5;
            this.m6 = m6;

            this.m7 = m7;
            this.m8 = m8;
            this.m9 = m9;
        }

        public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
        {
            return new Matrix3
            (
                //X
                lhs.m1 * rhs.m1 + lhs.m4 * rhs.m2 + lhs.m7 * rhs.m3,
                lhs.m1 * rhs.m4 + lhs.m4 * rhs.m5 + lhs.m7 * rhs.m6,
                lhs.m1 * rhs.m7 + lhs.m4 * rhs.m8 + lhs.m7 * rhs.m9,

                //Y
                lhs.m2 * rhs.m1 + lhs.m5 * rhs.m2 + lhs.m8 * rhs.m3,
                lhs.m2 * rhs.m4 + lhs.m5 * rhs.m5 + lhs.m8 * rhs.m6,
                lhs.m2 * rhs.m7 + lhs.m5 * rhs.m8 + lhs.m8 * rhs.m9,

                //Z
                lhs.m3 * rhs.m1 + lhs.m6 * rhs.m2 + lhs.m9 * rhs.m3,
                lhs.m3 * rhs.m4 + lhs.m6 * rhs.m5 + lhs.m9 * rhs.m6,
                lhs.m3 * rhs.m7 + lhs.m6 * rhs.m8 + lhs.m9 * rhs.m9
            );
        }

        public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
        {
            return new Vector3((lhs.m1 * rhs.x) + (lhs.m2 * rhs.y) + (lhs.m7 * rhs.z),
                                (lhs.m4 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m8 * rhs.z),
                                (lhs.m7 * rhs.x) + (lhs.m6 * rhs.y) + (lhs.m9 * rhs.z));
        }

        public void Print()
        {
            Console.WriteLine(m1.ToString() + ", " + m4.ToString() + ", " + m7.ToString());
            Console.WriteLine(m2.ToString() + ", " + m5.ToString() + ", " + m8.ToString());
            Console.WriteLine(m3.ToString() + ", " + m6.ToString() + ", " + m9.ToString());
        }

        public Matrix3 GetTansposed()
        {
            // flip row and column
            return new Matrix3
            (
                m1, m2, m3,
                m4, m5, m6,
                m7, m8, m9
            );
        }

        public Vector3 GetXAxis()
        {
            return new Vector3(m1, m4, m7);
        }

        public Vector3 GetYAxis()
        {
            return new Vector3(m2, m5, m8);
        }

        public Vector3 GetZAxis()
        {
            return new Vector3(m3, m6, m9);
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

        public Matrix3 Set(Matrix3 matrix)
        {
            return matrix;
        }

        public void SetScaled(float x, float y, float z)
        {
            m1 = x; m2 = 0; m3 = 0;
            m4 = 0; m5 = y; m6 = 0;
            m7 = 0; m8 = 0; m9 = z;
        }

        public void SetRotateX(double radians)
        {
            Matrix3 m = new Matrix3(1, 0, 0, 0, (float)Math.Cos(radians), (float)Math.Sin(radians), 0, (float)-Math.Sin(radians), (float)Math.Cos(radians));
            Set(m);
        }

        public void SetRotateY(double radians)
        {
            Matrix3 m = new Matrix3((float)Math.Cos(radians), 0, (float)Math.Sin(radians), 0, 1, 0, (float)-Math.Sin(radians), 0, (float)Math.Cos(radians));
            Set(m);
        }

        public void SetRotateZ(double radians)
        {
            Matrix3 m = new Matrix3((float)Math.Cos(radians), (float)-Math.Sin(radians), 0, (float)Math.Sin(radians), (float)Math.Cos(radians), 0, 0, 0, 1);
            Set(m);
        }

        public void Scale(float x, float y, float z)
        {
            Matrix3 m = new Matrix3();
            m.SetScaled(x, y, z);
            Set(m);
        }

        public void RotateX(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateX(radians);
            Set(m);
        }

        public void RotateY(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateY(radians);
            Set(m);
        }

        public void RotateZ(double radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateZ(radians);
            Set(m);
        }

        public void SetTranslation(float x, float y)
        {
            m7 = x; m8 = y; m9 = 1;
        }

        public void Translate(float x, float y)
        {
            // apply vector offset
            m7 += x; m8 += y;
        }
    }

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
