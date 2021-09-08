using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            ExploreIf();
            WorkWithLoops();
            SumIntegersFromOneToTwentyDivisibleByThree();

            void SumIntegersFromOneToTwentyDivisibleByThree()
            {
                int sum = 0;

                for (int i = 1; i < 21; i++)
                {
                    if (i % 3 == 0)
                    {
                        sum += i;
                    }
                }
                Console.WriteLine($"Sum of all integers 1 through 20 divisible by 3 is {sum}.");
            }

            void WorkWithLoops()
            {
                int counter = 0;
                do
                {
                    Console.WriteLine($"Hello World! The counter is {counter}");
                    counter++;
                }
                while (counter < 10);

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Hello World! The index is {i}");
                }

                for (int row = 1; row < 11; row++)
                {
                    for (char column = 'a'; column < 'k'; column++)
                    {
                        Console.WriteLine($"The row is {row}, {column}");
                    }
                }
            }

            void ExploreIf()
            {
                int a = 5;
                int b = 3;
                int c = 4;

                if (a + b > 10)
                {
                    Console.WriteLine("The answer is grater than 10.");
                }
                else
                {
                    Console.WriteLine("The answer is not greater then 10");
                }

                if ((a + b + c > 10) && (a == b))
                {
                    Console.WriteLine("The answer is greater then 10");
                    Console.WriteLine("And the first number is equal to the second");
                }
                else
                {
                    Console.WriteLine("The answer is not greater than 10");
                    Console.WriteLine("Or the first number is not equal to the second");
                }

                if ((a + b + c > 10) || (a == b))
                {
                    Console.WriteLine("The answer is greader than 10");
                    Console.WriteLine("Or the first number is equal to the second");
                }
                else
                {
                    Console.WriteLine("THe answer is not greater than 10");
                    Console.WriteLine("And the first number is not equals to the second");
                }
            }


        }
    }
}
