using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var lines = File.ReadAllLines("students.txt");
        var students = lines.Select(line => line.Split(',')).ToArray();

        var lowPerformingStudents = students.Where(student => int.Parse(student[2]) < 80);

        Console.WriteLine("Студенти з оцiнкою менше 80:");
        foreach (var student in lowPerformingStudents)
        {
            Console.WriteLine($"{student[0]} {student[1]}: {student[2]}");
        }
    }
}


