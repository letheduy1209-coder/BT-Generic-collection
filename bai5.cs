// SV: Le The Duy - 2415053122208
using System;
using System.Collections.Generic;

class Bai5
{
    static void Main()
    {
        List<string> list = new List<string>() { "An", "Binh", "Chi" };
        Console.Write("Nhap ten can xoa: ");
        string x = Console.ReadLine();

        list.Remove(x);

        foreach (var i in list)
            Console.WriteLine(i);
    }
}