using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDLL.BL;
using ProjectDLL.DLInterface;
using System.Data.SqlClient;
using System.IO;

namespace ProjectDLL.DL.FH
{
    public class BookFH : IBook
    {
        // File path
        string filePath = "F:\\Semester 2\\OOP\\OOP-MAIN_PROJ\\FileHandeling\\books.txt";
        public void Create(Book book)
        {
            // Open the file
            using (StreamWriter writer = File.AppendText(filePath))
            {
                string bookData = $"{book.getName()},{book.getAuthor()},{book.getLocation()},{book.getCopies()},{book.getCopiesAvailable()}";

                // Write the book data to the file
                writer.WriteLine(bookData);
            }
        }
        public bool IsExist(string name)
        {
            // Read all lines from the file
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                // Split the line by comma to separate different parts
                string[] parts = line.Split(',');

                if (parts[0] == name)
                {
                    return true;
                }
            }
            // If the loop completes without finding a match, return false indicating that the name does not exist
            return false;
        }
        public Book Read(string find)
        {
            // Read all lines from the file
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                // Split the line by comma to separate different parts
                string[] parts = line.Split(',');


                if (parts[0] == find)
                {
                    return new Book(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
                }
            }
            return null;
        }

        public void DeleteBook(string bookName)
        {
            // Read all lines from the file
            List<string> lines = File.ReadAllLines(filePath).ToList();

            List<string> updatedLines = new List<string>();

            foreach (string line in lines)
            {
                // Split the line by comma to separate different parts
                string[] parts = line.Split(',');

                if (parts[0] != bookName)
                {
                    updatedLines.Add(line);
                }
            }
            // Write the updated lines back to the file, effectively deleting the book
            File.WriteAllLines(filePath, updatedLines);
        }


        public List<Book> ViewAllBooks()
        {
            // Create a list to store all books
            List<Book> books = new List<Book>();

            // Read all lines from the file and store them in a list
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                // Split the line by comma to separate different parts
                string[] parts = line.Split(',');

                books.Add(new Book(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4])));
            }

            return books;
        }

        public void UpdateBook(Book bookToUpdate)
        {
            // Read all lines from the file
            List<string> lines = File.ReadAllLines(filePath).ToList();

            List<string> updatedLines = new List<string>();

            foreach (string line in lines)
            {
                // Split the line by comma to separate different parts
                string[] parts = line.Split(',');

                if (parts[0] == bookToUpdate.getName())
                {
                    updatedLines.Add($"{bookToUpdate.getName()},{bookToUpdate.getAuthor()},{bookToUpdate.getLocation()},{bookToUpdate.getCopies()},{bookToUpdate.getCopiesAvailable()}");
                }
                else
                {
                    updatedLines.Add(line);
                }
            }
            // Write the updated lines back to the file
            File.WriteAllLines(filePath, updatedLines);
        }

        public Book SearchByName(string name)
        {
            // Read all lines from the file and store them in a list
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                // Split the line by comma to separate different parts
                string[] parts = line.Split(',');

                if (parts[0] == name)
                {
                    return new Book(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
                }
            }

            return null;
        }
    }
}
