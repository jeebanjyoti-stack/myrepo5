using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String username;
            Again:
            Console.WriteLine("enter user name");
            username = Console.ReadLine();
            if (username.Length>=6) {

                Console.WriteLine("Welcome :  \t " + username);

            }
            else
            {
                Console.WriteLine("invalid user name");
                goto Again;
            }
            Console.ReadKey();
        }
    }
}
