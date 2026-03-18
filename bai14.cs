// SV: Le The Duy - 2415053122208
using System;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
}

class Bai14
{
    static void Main()
    {
        List<Student> list = new List<Student>()
        {
            new Student{Id=1, Name="An"},
            new Student{Id=2, Name="Binh"}
        };

        Console.Write("Nhap ID: ");
        int id = int.Parse(Console.ReadLine());

        list.RemoveAll(s => s.Id == id);

        foreach (var s in list)
            Console.WriteLine($"{s.Id} - {s.Name}");
    }
}