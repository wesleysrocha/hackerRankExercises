using System;
using static System.Console;

class Solution
{
    static void Main()
    {

        ulong num = ulong.Parse(Console.ReadLine());

        for (int i = 61; i >= 0; i--)
        {
            ulong threeeBits = (num >> i) & 7;//USING 7 BECAUSE IT IS 111
            if (threeeBits == 0 || threeeBits == 7)
            {
                num = num ^ (ulong)7 << i;
                i -= 2;
            }
        }
        Console.WriteLine(num);
    }
}

