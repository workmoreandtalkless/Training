using System;

namespace Exercise3
{   
    class StringRevers
    {
        string str;
        public StringRevers(string str)
        {
            this.str = str;
        }

        public string Reverse()
        {
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string: ");
            string input = Console.ReadLine();
            StringRevers str = new StringRevers(input);
            Console.WriteLine(str.Reverse());
        }
    }
}
