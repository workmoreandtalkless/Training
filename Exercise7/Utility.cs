using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    class Utility
    {
        public static int readmenuSelection()
        {
            int c;
            for(; ; )
            {
                c = Convert.ToInt32(Console.ReadLine());
                if (c != 1 && c != 2 && c != 3 && c != 4)
                {
                    Console.WriteLine("selction error, please Enter Again: ");
                }
                else break;
            }
            return c;
        }

        // used for withdraw  and deposit 
        public static int readNumber()
        {
            int n;
            for(; ; )
            {
                try
                {
                n= Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("wrong input number, please Enter Again:");
                }
            }
            return n;
        }
        // used for confirm what you select
        public static char readConfirmSelection()
        {
            char c;
            for(; ; )
            {
                string str = Console.ReadLine().ToUpper();
                c = str[0];
                if (c == 'Y' || c == 'N')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("wrong selection, please Enter Again:");
                }

            }
            return c;
        }
    }
}
