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
                Console.Write("������� �����:");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                if (int.TryParse(input, out int number))
                {
                    Console.WriteLine($"����� ������������ �������: {Convert.ToChar(number)}");
                }

                double doubleNum = double.Parse(input);

                if (input.Contains(',') && Math.Abs(doubleNum - lastInput) < 1e-9)
                {
                    Console.WriteLine("����� �����");
                    break;
                }

                lastInput = Convert.ToDouble(input);
            }
        }
    }
}

