using System;

namespace Microwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());   // ЗАДАЧА 1
            Console.WriteLine(x * x);




            Console.WriteLine(int.TryParse(Console.ReadLine(), out int с));
            Console.WriteLine(double.TryParse(Console.ReadLine(), out double y)); // ЗАДАЧА 2
            Console.WriteLine(bool.TryParse(Console.ReadLine(), out bool z));




            int sum = 0;    // ЗАДАЧА 3
            int amountOfNumbers = 0;
            int min = 1001;
            int max = -1001;
            while (true)
            {
                string m = Console.ReadLine();
                if (int.TryParse(m, out int j))
                {
                    sum += j;
                    amountOfNumbers++;
                    if (j > max)
                    {
                        max = j;
                    }
                    if (j < min)
                    {
                        min = j;
                    }

                }
                else
                {
                    Console.WriteLine(sum + " " + min + " " + max + " " + amountOfNumbers + " " + sum / amountOfNumbers);
                    break;
                }
            }
        }
    }
}
