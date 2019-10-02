using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main()
        {
            //int.TryParse(Console.ReadLine(), out int input);
            Matrix3 mat1 = new Matrix3(1, 4, 7, 2, 5, 8, 3, 6, 9);
            Matrix3 matrix1 = new Matrix3(1, 1, 1, 1, 1, 1, 1, 1, 1);
            Matrix3 matrix2 = new Matrix3(1, 1, 1, 1, 1, 1, 1, 1, 1);
            Matrix3 matrix3 = matrix1 * matrix2;

            Matrix3 matrix4 = new Matrix3(1, 1, 1, 1, 1, 1, 1, 1, 1);
            Vector3 vec3 = new Vector3(2, 2, 2);
            Vector3 matrix5 = matrix4 * vec3;

            //Console.Write(matrix*matrix);
            Console.WriteLine("Matrix 3 * Matrix 3");
            matrix3.Print();
            Console.WriteLine("\n\nVector 3 * Matrix 3");
            Console.WriteLine(matrix5.x + ", " + matrix5.y + ", " + matrix5.z);

            Console.WriteLine("\n\nIdentity of Matrix 3");
            Matrix3 mat3 = Matrix3.Indentity();
            mat3.Print();

            Console.WriteLine("\n\nGet X Axis of Matrix Identity");
            mat3.GetXAxis().Print();

            Console.WriteLine("\n\nGet Y Axis of Matrix Identity");
            mat3.GetYAxis().Print();

            Console.WriteLine("\n\nGet Z Axis of Matrix Identity");
            mat3.GetZAxis().Print();

            Console.WriteLine("\n\nNon Transposed Example");
            mat1.Print();
            Console.WriteLine("\nTransposed Example");
            mat1.GetTansposed().Print();

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
