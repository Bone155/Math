﻿using System;
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

        public string DecToBin(uint n)
        {
            int mask = 1;
            var binary = string.Empty;
            while (n > 0)
            {
                binary = (n & mask) + binary;
                n = n >> 1;
            }
            binary = binary.PadLeft(8, '0');
            return binary;
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

        public uint GetRightMost(string A, string B)
        {
            char[] array = A.ToCharArray();
            char[] array2 = B.ToCharArray();
            Array.Reverse(array);
            Array.Reverse(array2);
            uint result;
            for (int i = 0; i < A.Length && i < B.Length; i++)
            {
                if (array[i] == '1' && array2[i] == '0')//A&B == B
                    result = '0';//A & B

                else if (array[i] == '0' && array2[i] == '1')
                    result = '0';

                else if (array[i] == '1' && array2[i] == '1')
                    result = '1';

                else
                    result = '0';
                
                return result;
            }
            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            Exercises ex = new Exercises();
            uint.TryParse(Console.ReadLine(), out uint num);
            string bin = "0100101110";
            string bin2 = "0000001000";
            ex.DecToBin(num);
            Console.WriteLine();

            //Console.Write(ex.BinToDec(Console.ReadLine()));
            Console.WriteLine();

            //Console.Write(ex.IsLeftMost(Console.ReadLine()));
            Console.WriteLine();

            //Console.Write(ex.IsRightMost(Console.ReadLine()));
            Console.WriteLine();

            //Console.Write(ex.IsBitSet(Console.ReadLine()));
            Console.WriteLine();

            //Console.Write(ex.GetRightMost(bin, bin2));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
