// SV: Le The Duy - 2415053122208
using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name;
    public double Score;
}

class Bai18
{
    static void Main()
    {
        List<Student> list = new List<Student>()
        {
            new Student{Name="An", Score=8.5},
            new Student{Name="Binh", Score=7.0},
            new Student{Name="Chi", Score=9.2}
        };

        var max = list.OrderByDescending(s => s.Score).First();

        Console.WriteLine("Sinh vien diem cao nhat:");
        Console.WriteLine($"{max.Name} - {max.Score}");
    }
}