using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your word here: ");
            string word = Console.ReadLine();
            string reverse;
            char[] rev = word.ToCharArray();

            Array.Reverse(rev);
            reverse = new string(rev);

            bool a = word.Equals(reverse, StringComparison.OrdinalIgnoreCase);
            if( a  == true  )
            {
                Console.WriteLine($"{word} is palindrome");
            }
            else
            {
                Console.WriteLine("Your word is not palindrome");
            }

            Console.ReadLine();
        }
       

        
        

            
        

    }
}
