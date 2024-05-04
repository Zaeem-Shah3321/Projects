using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDLL;
using ProjectDLL.DLInterface;
using ProjectDLL.DL.DB;
using ProjectConsole.UI;
using ProjectDLL.BL;
using ProjectConsole.Util;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Remoting.Messaging;

namespace ProjectConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

        logout:
            string choice = "";
            while (true)
            {
                choice = Menu.showMenu();
                
                if (choice == "1")
                {
                    Person person = PersonUI.getPersonWithRole(ObjectHandler.GetPersonDL());
                    if (person == null)
                    {
                        UtilUi.Error("User Already Exist");
                        continue;
                    }
                    
                    ObjectHandler.GetPersonDL().Create(person);
                    UtilUi.Success("Signed Up Sucessfully");
                }
                else if (choice == "2")
                {
                    Person person = PersonUI.getPerson();
                    Person per = ObjectHandler.GetPersonDL().signin(person);
                    if (per == null)
                    {
                        UtilUi.Error("Wrong UserName or Password");
                        continue;
                    } 
                    else if (per.getRole().ToLower() == "admin")
                    {
                        goto Admin;
                    }
                    else if (per.getRole().ToLower() == "student")
                    {
                        goto Student;
                    }
                }
                else if (choice == "3")
                {
                    return;
                }
                else
                {
                    UtilUi.InvalidChoice();
                }
            }
        Admin:
            while (true)
            {
                choice = Menu.adminMenu();

                if (choice == "1")
                {
                    Book book = BookUI.getBook(ObjectHandler.GetBookDL());
                    if (book == null)
                    {
                        UtilUi.Error("Book Already Exist");
                        continue;
                    }

                    ObjectHandler.GetBookDL().Create(book);
                    UtilUi.Success("Book Added Sucessfully");
                }
                else if (choice == "2")
                {
                    if (ObjectHandler.GetBookDL() == null)
                    {
                        UtilUi.Error("No books found in the database.");
                    }
                    else
                    {
                       

                        foreach (Book book in ObjectHandler.GetBookDL().ViewAllBooks())
                        {
                            Console.WriteLine($" Name: {book.getName()}\n Author: {book.getAuthor()}\n Location: {book.getLocation()}\n Total Copies: {book.getCopies()}\n Copies Available: {book.getCopiesAvailable()}");
                            Console.WriteLine("------------------------");
                        }
                        Console.ReadKey();
                    }
                }
                else if (choice == "3")
                {
                    string book = BookUI.GetBookNameToDelete(ObjectHandler.GetBookDL());
                    if (book == null)
                    {
                        UtilUi.Error("Book Not Found");
                        continue;
                    }

                    ObjectHandler.GetBookDL().DeleteBook(book);
                    UtilUi.Success("Book Deleted Sucessfully");
                }
                else if (choice == "4")
                {
                    Book bookToUpdate = BookUI.UpdateBookInfo(ObjectHandler.GetBookDL());
                    if (bookToUpdate == null)
                    {
                        UtilUi.Error("Book not found or updated.");
                        continue;
                    }

                    ObjectHandler.GetBookDL().UpdateBook(bookToUpdate);
                    UtilUi.Success("Book Updated Successfully.");

                }
                else if (choice == "5")
                {
                    goto logout;
                }
                else
                {
                    UtilUi.InvalidChoice();
                }
            }
        Student:
            while (true)
            {
                choice = Menu.studentMenu();

                if (choice == "1")
                {
                    if (ObjectHandler.GetBookDL() == null)
                    {
                        UtilUi.Error("No books found in the database.");
                    }
                    else
                    {
                        
                        foreach (Book book in ObjectHandler.GetBookDL().ViewAllBooks())
                        {
                            Console.WriteLine($" Name: {book.getName()}\n Author: {book.getAuthor()}\n Location: {book.getLocation()}\n Total Copies: {book.getCopies()}\n Copies Available: {book.getCopiesAvailable()}");
                            Console.WriteLine("------------------------");
                        }
                        Console.ReadKey();
                    }
                }
                else if (choice == "2")
                {
                    if (ObjectHandler.GetBookDL() == null)
                    {
                        UtilUi.Error("No books found in the database.");
                    }
                    else
                    {
                        Book foundBook = BookUI.Search();

                        if (foundBook == null)
                        {
                            UtilUi.Error("Book not found.");
                        }
                        else
                        {
                            Console.WriteLine($" Name: {foundBook.getName()}\n Author: {foundBook.getAuthor()}\n Location: {foundBook.getLocation()}\n Total Copies: {foundBook.getCopies()}\n Copies Available: {foundBook.getCopiesAvailable()}");
                            Console.WriteLine("------------------------");
                        }

                        Console.ReadKey();
                    }
                }
                else if (choice == "3")
                {
                    goto logout;
                }
                else
                {
                    UtilUi.InvalidChoice();
                }
            }
        }
    }
}
