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

                if ((Math.Abc(Convert.ToDouble(input) - lastChar) < 1e-9)
                {
                    Console.WriteLine("введеное число равно предыдущему");
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
