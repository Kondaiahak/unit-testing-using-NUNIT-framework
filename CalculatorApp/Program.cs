using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int choice;

            do
            {
                Console.WriteLine("\n===== CALCULATOR =====");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Enter Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                    break;

                Console.Write("Enter First Number: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Second Number: ");
                int b = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Result = " + calculator.Add(a, b));
                        break;

                    case 2:
                        Console.WriteLine("Result = " + calculator.Subtract(a, b));
                        break;

                    case 3:
                        Console.WriteLine("Result = " + calculator.Multiply(a, b));
                        break;

                    case 4:
                        try
                        {
                            Console.WriteLine("Result = " + calculator.Divide(a, b));
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (true);
        }
    }
}