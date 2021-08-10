using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {

           //Create multiplication table using for loop
           for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i == 1)
                    {
                        if (i * j < 10)
                        {
                            Console.Write($" {i * j} ");
                        }
                        else
                        {
                            Console.Write($"{i * j} ");
                        }
                    }
                    else if (i > 1 && i < 10)
                    {
                        if (i * j < 10)
                        {
                            Console.Write($" {i * j} ");
                        }
                        else
                        {
                            Console.Write($"{i * j} ");
                        }
                    }
                    else
                    {
                        Console.Write($"{i * j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
