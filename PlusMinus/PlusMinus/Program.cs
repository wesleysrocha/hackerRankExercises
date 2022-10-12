//exercicio 1
using System;
using static System.Console;

class Solution
{
    static void Main(String[] args)
    {
        var positive = 0;
        var negative = 0;
        var zero = 0;
        ReadLine();
        var arr_temp = ReadLine().Split(' ');
        var arr = Array.ConvertAll(arr_temp, Int32.Parse);

        for (int arr_i = 0; arr_i < arr.Length; arr_i++)
        {
            if (arr[arr_i] > 0)
                ++positive;
            else if (arr[arr_i] < 0)
                ++negative;
            else
                ++zero;
        }

        WriteLine((double)positive / arr.Length);
        WriteLine((double)negative / arr.Length);
        WriteLine((double)zero / arr.Length);
    }
}

