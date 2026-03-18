// SV: Le The Duy - 2415053122208
using System;
using System.Collections.Generic;

class Bai16
{
    static void Main()
    {
        Console.Write("Nhap chuoi: ");
        string str = Console.ReadLine();

        Dictionary<char, int> dem = new Dictionary<char, int>();

        foreach (char c in str)
        {
            if (dem.ContainsKey(c))
                dem[c]++;
            else
                dem[c] = 1;
        }

        foreach (var item in dem)
            Console.WriteLine(item.Key + " : " + item.Value);
    }
}