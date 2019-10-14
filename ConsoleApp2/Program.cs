using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static bool IsAlmostPolindrome(string pString)
        {
            string rev;
            char[] ch = pString.ToCharArray();

            Array.Reverse(ch);
            rev = new string(ch);

            bool b = pString.Equals(rev, StringComparison.OrdinalIgnoreCase);

            return b;
            
        }
        static void Main(string[] args)
        {
            string string1;
            string1 = "abccba";

            if (IsAlmostPolindrome(string1))
            {
                Console.WriteLine("" + string1 + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + string1 + " is not a Palindrome!");
            }
            Console.Read();


        }
    }
}
