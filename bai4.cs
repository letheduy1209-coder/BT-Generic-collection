// SV: Le The Duy - 2415053122208
using System;
using System.Collections.Generic;
using System.Linq;

class Bai4
{
    static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
        Console.WriteLine("So chan = " + list.Count(x => x % 2 == 0));
    }
}