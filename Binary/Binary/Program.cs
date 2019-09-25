using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Exercises
    {
        public string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

        public void DecToBin(uint n)
        {
            string binary = "";
            while (n >= 1)
            {
                if (n % 2 == 0)
                {
                    binary += "0";
                }
                else if (n % 2 == 1)
                {
                    binary += "1";
                }
                n /= 2;
            }
            Console.WriteLine(Reverse(binary));
        }

        public uint BinToDec(string bin)
        {
            char[] array = bin.ToCharArray();
            Array.Reverse(array);
            uint sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Method uses raising 2 to the power of the index. 
                    if (i == 0)
                    {
                        sum += 1;
                    }
                    else
                    {
                        sum += (uint)Math.Pow(2, i);
                    }
                }
            }
            return sum;
        }

        public bool IsLeftMost(string value)
        {
            char[] array = value.ToCharArray();
            bool isLeft = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[0] >= '1')
                    isLeft = true;
            }
            return isLeft;
        }

        public bool IsRightMost(string value)
        {
            char[] array = value.ToCharArray();
            Array.Reverse(array);
            bool isRight = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[0] == '1')
                    isRight = true;
            }
            return isRight;
        }

        public bool IsBitSet(string value)
        {
            char[] array = value.ToCharArray();
            char[] array2 = value.ToCharArray();
            Array.Reverse(array2);
            bool isSet = false;
            for (int i = 0; i < array.Length && i < array2.Length; i++)
            {
                if (array[0] == '1' && array2[0] == '1')
                    isSet = true;
            }
            return isSet;
        }

        public int GetRightMost(uint value)
        {
            int setRight = 0;
            for (int i = 0; i < ; i++)
            {
                if (value ==  1)
                     ;
                //else
                //    setRight = -1;
            }
            return setRight;
        }
    }

    class Program
    {
        static void Main()
        {
            Exercises ex = new Exercises();
            uint.TryParse(Console.ReadLine(), out uint num);
            uint bin = 0100101110;
            //ex.DecToBin(num);
            Console.WriteLine();

            //Console.Write(ex.BinToDec(Console.ReadLine()));
            Console.WriteLine();

            //Console.Write(ex.IsLeftMost(Console.ReadLine()));
            Console.WriteLine();

            //Console.Write(ex.IsRightMost(Console.ReadLine()));
            Console.WriteLine();

            //Console.Write(ex.IsBitSet(Console.ReadLine()));
            Console.WriteLine();

            Console.Write(ex.GetRightMost(bin));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
