using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var lines = File.ReadAllLines("products.txt");
        var products = lines.Select(line => line.Split(',')).ToArray();

        var groupedProducts = products.GroupBy(product => double.Parse(product[2]));

        Console.WriteLine("Продукти, згрупованi за цiною:");
        foreach (var group in groupedProducts)
        {
            Console.WriteLine($"Цiна: {group.Key}");
            foreach (var product in group)
            {
                Console.WriteLine($" - {product[0]} ({product[1]})");
            }
        }
    }
}









