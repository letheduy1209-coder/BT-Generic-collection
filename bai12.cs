// SV: Le The Duy - 2415053122208
using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id;
    public string Name;
}

class Bai12
{
    static void Main()
    {
        List<Student> list = new List<Student>()
        {
            new Student{Id=1, Name="An"},
            new Student{Id=2, Name="Binh"}
        };

        Console.Write("Nhap ten: ");
        string x = Console.ReadLine();

        var kq = list.Where(s => s.Name.Contains(x));

        foreach (var s in kq)
            Console.WriteLine($"{s.Id} - {s.Name}");
    }
}