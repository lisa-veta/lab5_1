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

                if (input == "q")
                {
                    break;
                }

                if (int.TryParse(input, out int number)) 
                {
                    Console.WriteLine(Convert.ToChar(number));
                }

                double doubleNum = double.Parse(input);
                if (Math.Abs(doubleNum - lastChar) < 1e-9)
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
