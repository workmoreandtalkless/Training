using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int row ;
            Console.WriteLine("Enter the number of Rows: ");
            row = Convert.ToInt32(Console.ReadLine());
            int p, lastInt = 0;

            for (int i = 1; i <= row; i++)
            {
                for (p = 1; p <= i; p++)
                {
                    if (lastInt == 1)
                    {
                        Console.Write("0");
                        lastInt = 0;
                    }
                    else if (lastInt == 0)
                    {
                        Console.Write("1");
                        lastInt = 1;
                    }
                }
                Console.Write("\n");
            }
            
        }
    }
}
