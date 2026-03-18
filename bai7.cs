// SV: Le The Duy - 2415053122208
using System;
using System.Collections.Generic;

class Bai7
{
    static void Main()
    {
        List<int> list = new List<int>() { 9, 3, 6, 1 };
        list.Sort();

        foreach (var i in list)
            Console.Write(i + " ");
    }
}