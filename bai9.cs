// SV: Le The Duy - 2415053122208
using System;
using System.Collections.Generic;
using System.Linq;

class Bai9
{
    static void Main()
    {
        List<int> list = new List<int>() { 1, 2, 2, 3, 3 };

        var kq = list.Distinct();

        foreach (var i in kq)
            Console.Write(i + " ");
    }
}