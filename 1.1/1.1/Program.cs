using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int size = 10;
        List<int> numbers = new List<int>();
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            numbers.Add(random.Next(-50, 50));
        }

        numbers.Sort();
        numbers.Reverse();

        //List<int> positives = numbers.Where(x => x >= 0).ToList();
        //List<int> negatives = numbers.Where(x => x < 0).ToList();     
        //List<int> sortedNumbers = positives.Concat(negatives).ToList();
     
        Console.WriteLine("Вiдсортований список:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.ReadKey();
    }
}