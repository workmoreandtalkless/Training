using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Input first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            int n, r, sum = 0, temp;
            for (int i = num1; i <= num2; i++)
            {
                n = i;
                temp = n;
                while (n > 0)
                {
                    r = n % 10;
                    sum += (r * r * r);
                    n = n / 10;
                }
                if (temp == sum)
                {
                    Console.WriteLine(i);
                }
                sum = 0;
            }
        }
    }
}
