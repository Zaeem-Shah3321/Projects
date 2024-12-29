using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConsole.UI
{
    internal class Menu
    {
        public static void header()
        {
            Console.Clear();
            Console.WriteLine("Bukhari Library Co.");
            Console.WriteLine();
        }
        public static string showMenu()
        {
            header();
            Console.WriteLine("1. Sign Up");
            Console.WriteLine("2. Sign In");
            Console.WriteLine("3. Exit");


            Console.Write("Enter your option: ");
            return Console.ReadLine();
        }
        public static string adminMenu()
        {
            header();
            Console.WriteLine("1. Add Book.. ");
            Console.WriteLine("2. View Books.. ");
            Console.WriteLine("3. Remove Book.. ");
            Console.WriteLine("4. Update Book's Data.. ");
            Console.WriteLine("5. Log Out.. ");

            Console.Write("Enter your option: ");
            return Console.ReadLine();
        }
        public static string studentMenu()
        {
            header();
            Console.WriteLine("1. View all Books.. ");
            Console.WriteLine("2. Search Book.. ");
            Console.WriteLine("3. Log Out.. ");
            
            Console.Write("Enter your option: ");
            return Console.ReadLine();
        }
    }
}
