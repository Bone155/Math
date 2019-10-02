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
            Matrix3 matrix = new Matrix3(1, 2, 3, 4, 5, 6, 7, 8, 9);

            Console.Write(matrix*matrix);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
