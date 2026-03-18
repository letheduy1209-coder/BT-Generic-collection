// SV: Le The Duy - 2415053122208
using System;
using System.Collections.Generic;

class Bai15
{
    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            {"hello","xin chao"},
            {"book","sach"},
            {"cat","con meo"}
        };

        Console.Write("Nhap tu tieng Anh: ");
        string eng = Console.ReadLine();

        if (dict.ContainsKey(eng))
            Console.WriteLine("Nghia: " + dict[eng]);
        else
            Console.WriteLine("Khong tim thay");
    }
}