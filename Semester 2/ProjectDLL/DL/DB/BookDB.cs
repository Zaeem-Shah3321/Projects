using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDLL.BL;
using ProjectDLL.DLInterface;
using System.Data.SqlClient;

namespace ProjectDLL.DL.DB
{
    public class BookDB:IBook
    {
        public void Create(Book book)
        {
            // Open a database connection
            DataBase.openConnection();

            // SQL query to insert a new book record into the database
            string query = $"insert into Book values('{book.getName()}','{book.getAuthor()}','{book.getLocation()}','{book.getCopies()}','{book.getCopiesAvailable()}')";

            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            cmd.ExecuteNonQuery();

            // Close the database connection
            DataBase.closeConnection();
        }

        public bool IsExist(string name)
        {
            // Open a database connection
            DataBase.openConnection();

            // SQL query to select a book by its name
            string query = $"select * from Book where Name = '{name}'";

            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            bool exist = false;

            // Check if the reader has any rows
            while (reader.Read())
            {
                exist = true;
            }

            // Close the database connection
            DataBase.closeConnection();

            return exist;
        }

        public Book Read(string find)
        {
            // Open a database connection
            DataBase.openConnection();

            // SQL query to select a book by its name
            string query = $"select * from Book where Name = '{find}'";

            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Book book = null;

            while (reader.Read())
            {
                string name = reader["Name"].ToString();
                string author = reader["Author"].ToString();
                string location = reader["Location"].ToString();
                int copies = int.Parse(reader["Total Copies"].ToString());
                int copiesAvailable = int.Parse(reader["Copies Available"].ToString());
                book = new Book(name, author, location, copies, copiesAvailable);
            }

            // Close the database connection
            DataBase.closeConnection();

            // Return the Book object
            return book;
        }

        public void DeleteBook(string bookName)
        {
            // Open a database connection
            DataBase.openConnection();

            // SQL query to delete a book by its name
            string query = $"DELETE FROM Book WHERE Name = '{bookName}'";

            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            cmd.ExecuteNonQuery();

            // Close the database connection
            DataBase.closeConnection();
        }

        public List<Book> ViewAllBooks()
        {
            // Create a list to store all books
            List<Book> books = new List<Book>();

            // Open a database connection
            DataBase.openConnection();

            // SQL query to select all books from the database
            string query = "SELECT * FROM Book";

            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString(0);
                string author = reader.GetString(1);
                string location = reader.GetString(2);
                int copies = reader.GetInt32(3);
                int copiesAvailable = reader.GetInt32(4);
                Book book = new Book(name, author, location, copies, copiesAvailable);

                // Add the Book object to the list of books
                books.Add(book);
            }

            // Close the reader and the database connection
            reader.Close();
            DataBase.closeConnection();

            // Return the list of books
            return books;
        }

        public void UpdateBook(Book bookToUpdate)
        {
            // Open a database connection
            DataBase.openConnection();

            // SQL query to update a book's information in the database
            string query = $"UPDATE Book SET Author = '{bookToUpdate.getAuthor()}', Location = '{bookToUpdate.getLocation()}', [Total Copies] = {bookToUpdate.getCopies()}, [Copies Available] = {bookToUpdate.getCopiesAvailable()} WHERE Name = '{bookToUpdate.getName()}'";

            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            cmd.ExecuteNonQuery();

            // Close the database connection
            DataBase.closeConnection();
        }

        public Book SearchByName(string name)
        {
            Book foundBook = null;

            // Open a database connection
            DataBase.openConnection();

            // SQL query to select a book by its name
            string query = $"SELECT * FROM Book WHERE Name = '{name}'";

            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            // Check if a row is found
            if (reader.Read())
            {
                foundBook = new Book(
                    reader["Name"].ToString(),
                    reader["Author"].ToString(),
                    reader["Location"].ToString(),
                    int.Parse(reader["Total Copies"].ToString()),
                    int.Parse(reader["Copies Available"].ToString())
                );
            }

            // Close the reader and the database connection
            reader.Close();
            DataBase.closeConnection();

            // Return the found Book object
            return foundBook;
        }


    }
}
