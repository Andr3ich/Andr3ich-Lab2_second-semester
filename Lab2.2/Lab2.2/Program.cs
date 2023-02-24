using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var lines = File.ReadAllLines("employees.txt");
        var employees = lines.Select(line => line.Split(',')).ToArray();

        var sortedEmployees = employees.OrderBy(employee => int.Parse(employee[2]));

        Console.WriteLine("Вiдсортованi за зарплатнею спiвробiтники:");
        foreach (var employee in sortedEmployees)
        {
            Console.WriteLine($"{employee[0]} {employee[1]}: {employee[2]}");
        }
    }
}

