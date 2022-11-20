using System;
namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double lastInput = double.NaN;

            while (true)
            {
                Console.Write("Введите число:");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    Console.WriteLine($"Число соответсвует символу: {Convert.ToChar(number)}");
                }

                double doubleNum = double.Parse(input);

                if (input.Contains(',') && Math.Abs(doubleNum - lastInput) < 1e-9)
                {
                    Console.WriteLine("Числа равны");
                    break;
                }

                lastInput = Convert.ToDouble(input);
            }
        }
    }
}

