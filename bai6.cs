// SV: Le The Duy - 2415053122208
using System;
using System.Collections.Generic;

class Bai6
{
    static void Main()
    {
        List<string> list = new List<string>() { "An", "Binh", "Chi" };

        Console.Write("Nhap ten can tim: ");
        string x = Console.ReadLine();

        Console.WriteLine(list.Contains(x) ? "Co" : "Khong");
    }
}