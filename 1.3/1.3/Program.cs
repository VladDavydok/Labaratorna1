using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        float[] numbers = new float[5];
        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1001);
            Console.WriteLine(numbers[i]);
        }

        double result = numbers.Aggregate(1.0, (acc, x) => acc * (x % 10));

        Console.WriteLine("Твiр останнiх цифр всiх елементiв послiдовностi: {0}", result);
      
        Console.ReadLine();
    }
}