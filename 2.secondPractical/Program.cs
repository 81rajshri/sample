using System;

class Program
{
    static int Add(int a, int b) => a + b;
    static int Sub(int a, int b) => a - b;
    static int Mul(int a, int b) => a * b;
    static int Div(int a, int b) => a / b;

    // Advanced operations
    static double Power(double a, double b) => Math.Pow(a, b);
    static int Modulus(int a, int b) => a % b;

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n1.Add 2.Sub 3.Mul 4.Div 5.Power 6.Modulus 7.Exit");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice >= 1 && choice <= 6)
            {
                Console.Write("Enter first number: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double b = Convert.ToDouble(Console.ReadLine());

                switch (choice)
                {
                    case 1: Console.WriteLine("Result: " + Add((int)a, (int)b)); break;
                    case 2: Console.WriteLine("Result: " + Sub((int)a, (int)b)); break;
                    case 3: Console.WriteLine("Result: " + Mul((int)a, (int)b)); break;
                    case 4: Console.WriteLine("Result: " + Div((int)a, (int)b)); break;
                    case 5: Console.WriteLine("Result: " + Power(a, b)); break;
                    case 6: Console.WriteLine("Result: " + Modulus((int)a, (int)b)); break;
                }
            }

        } while (choice != 7);
    }
}