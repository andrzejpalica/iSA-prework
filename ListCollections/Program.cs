using System;
using System.Collections.Generic;

namespace ListCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //WorkWithStrings();

            var fibonacciNumbers = new List<int> { 1, 1 };

            for (int i = 3; i <= 20; i++)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
                
            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
            
            void WorkWithStrings()
            {
                var names = new List<string> { "Andrzej", "Ana", "Felipe" };

                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}!");
                }

                Console.WriteLine();

                names.Add("Maria");
                names.Add("Bill");
                names.Remove("Ana");

                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}!");
                }

                Console.WriteLine();

                Console.WriteLine($"My name is {names[0]}.");
                Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");

                Console.WriteLine();

                Console.WriteLine($"The list has {names.Count} people in it.");

                Console.WriteLine();

                var index = names.IndexOf("Felipe");

                if (index == -1)
                {
                    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
                }
                else
                {
                    Console.WriteLine($"The name {names[index]} is an index {index}");
                }

                index = names.IndexOf("Not Found");

                if (index == -1)
                {
                    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
                }
                else
                {
                    Console.WriteLine($"The name {names[index]} is an index {index}");
                }

                Console.WriteLine();

                names.Sort();

                foreach (var name in names)
                {
                    Console.WriteLine($"Hello {name.ToUpper()}!");
                }
            }
        }
    }
}
