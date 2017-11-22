﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            //  Console.Write("Enter your number: ");
            //long number = long.Parse(Console.ReadLine());

            // Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            int fakeBitOne = int.Parse(Console.ReadLine());
            int fakeBitTwo = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                uint maskOne = (uint)(number & (1 << fakeBitOne)) >> fakeBitOne;
                uint maskTwo = (uint)(number & (1 << fakeBitTwo)) >> fakeBitTwo;

                //mask one
                if (maskOne == 0)
                {
                    number = (uint)(number & (~(1 << fakeBitTwo)));
                }
                else if (maskOne == 1)
                {
                    number = (uint)(number | (1 << fakeBitTwo));
                }

                //mask two
                if (maskTwo == 0)
                {
                    number = (uint)(number & (~(1 << fakeBitOne)));
                }
                else if (maskTwo == 1)
                {
                    number = (uint)(number | (1 << fakeBitOne));
                }

                fakeBitOne++;
                fakeBitTwo++;
            }

            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine(number);

        }
    }
}
