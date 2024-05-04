using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectDLL.BL;
using System.Threading.Tasks;
using ProjectConsole.Util;
using ProjectDLL.DLInterface;
using ProjectDLL.DL.DB;

namespace ProjectConsole.UI
{
    internal class BookUI
    {
        public static Book getBook(IBook bookDL)
        {
            string name = getStringInput("Name");
            if (bookDL.Read(name) != null)
                return null;
            string author = getStringInput("Author");
            Console.Write("Enter Location: ");
            string location = Console.ReadLine();
            Console.Write("Enter Total Copies: ");
            int copies = int.Parse(Console.ReadLine());
            Console.Write("Enter Copies Available: ");
            int copiesAvailable = int.Parse(Console.ReadLine());


            return new Book(name, author, location, copies, copiesAvailable);
        }
        public static string getStringInput(string type, bool flag = true)
        {
        Again:
            Console.Write($"Enter {type}: ");
            string res = Console.ReadLine();
            if (!Validation.IsValid(type, res, flag))
            {
                goto Again;
            }
            return res;
        }
        public static string GetBookNameToDelete(IBook bookDL)
        {
            string name = getStringInput("Name of the book to delete: ");
            if (bookDL.Read(name) == null)
            {
                return null;
            }
            return name;
        }
        public static Book UpdateBookInfo(IBook bookDL)
        {
            string name = getStringInput("Name of the book to update");
            Book existingBook = bookDL.Read(name);
            if (existingBook == null)
            {
                return null;
            }

            string author = getStringInput("New Author");
            Console.Write("Enter New Location: ");
            string location = Console.ReadLine();
            Console.Write("Enter New Total Copies: ");
            int copies = int.Parse(Console.ReadLine());
            Console.Write("Enter New Copies Available: ");
            int copiesAvailable = int.Parse(Console.ReadLine());

            return new Book(name, author, location, copies, copiesAvailable);
        }
        // Method to search for a book by name

        public static Book Search()
        {
            string name = getStringInput("Enter the name of the book to search:");
            Book foundBook = ObjectHandler.GetBookDL().SearchByName(name);

            if (foundBook == null)
            {
                Console.WriteLine("Book not found.");
                return null;
            }
            
            
                return foundBook;
            
        }



    }
}
