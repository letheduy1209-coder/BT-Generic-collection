// SV: Le The Duy - 2415053122208
using System;
using System.Collections.Generic;

class Bai8
{
    static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4 };
        list.Reverse();

        foreach (var i in list)
            Console.Write(i + " ");
    }
}