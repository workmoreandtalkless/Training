using System;

namespace Exercise2
{

    class Arithmetic
    {
        double a, b;
        public Arithmetic(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double Addition()
        {
            return a + b;
        }

        public double Subtraction()
        {
            return a - b;
        }

        public double Multiplication()
        {
            return a * b;
        }
        public double Division()
        {
            return a / b;

        }

    }
        class Program
    {
        static void Main(string[] args)
        {
               
                Console.Write("Input num1: ");
               double a = Convert.ToInt32(Console.ReadLine());
               
                Console.Write("Input num2: ");
               double b = Convert.ToInt32(Console.ReadLine());
                Arithmetic arithmetic = new Arithmetic(a,b);
                int op = 0;
                while (op != 5)
            {
                Console.WriteLine("Select calculation: 1. Addition  2.Substraction  3.Mulitiplication   4.Division  5.Exit");
                 op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine($"{a} + {b} = {arithmetic.Addition()}");
                        break;
                    case 2:
                        Console.WriteLine($"{a} - {b} = {arithmetic.Subtraction()}");
                        break;
                    case 3:
                        Console.WriteLine($"{a} * {b} = {arithmetic.Multiplication()}");
                        break;
                    case 4:
                        Console.WriteLine($"{a} / {b} = {arithmetic.Division()}");
                        break;
                    case 5:
                        Console.WriteLine("exit");
                        break;

                    default:
                        Console.WriteLine("Wrong operator");
                        break;
                }
            }
                
          }
    }
}
