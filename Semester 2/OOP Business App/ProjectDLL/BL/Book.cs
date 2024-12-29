using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDLL.BL
{
    public class Book
    {
        protected string name;
        protected string author;
        protected string location;
        protected int copies;
        protected int copiesAvailable;

        public Book(string name, string author, string location, int copies, int copiesAvailable)
        {
            this.name = name;   
            this.author = author;
            this.location = location;
            this.copies = copies;
            this.copiesAvailable = copiesAvailable;
        }
        public string getName()
        {
            return name;
        }
        public string getAuthor()
        {
            return author;
        }
        public string getLocation()
        {
            return location;
        }
        public int getCopies()
        {
            return copies;
        }
        public int getCopiesAvailable()
        {
            return copiesAvailable;
        }
    }
}
