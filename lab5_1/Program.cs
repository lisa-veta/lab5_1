using System;
namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double lastChar = double.NaN;

            while (true)
            {
                string input = Console.ReadLine();  

                if (int.TryParse(input, out int number)) 
                {
                    Console.WriteLine(Convert.ToChar(number));
                }

                if ((Convert.ToDouble(input) == lastChar) || input == "q")
                {
                    break;
                }
                else
                {
                    lastChar = Convert.ToDouble(input);
                }
                
            }
        }
    }
}
