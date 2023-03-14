using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            string key = "Key" + i;
            int value = random.Next(-50, 50);
            dictionary.Add(key, value);
        }

        foreach (var pair in dictionary)
        {
            Console.WriteLine(pair.Key + " : " + pair.Value);
        }

        Console.WriteLine("----------------------");

        int sum = 0;
        foreach (var value in dictionary.Values)
        {
            sum += value;
        }

        foreach (var key in dictionary.Keys)
        {
            dictionary[key] = sum;
        }

        foreach (var pair in dictionary)
        {
            Console.WriteLine(pair.Key + " : " + pair.Value);
        }

        string json = JsonSerializer.Serialize(dictionary);
        Console.WriteLine(json);

        string file = "C:\\Users\\Vlad\\json.txt";
        StreamWriter sw = new StreamWriter(file);
        sw.Write(json);
        sw.Close();

        Console.WriteLine("Результат збережено у файлi result.json");

        Console.ReadKey();
    }
}