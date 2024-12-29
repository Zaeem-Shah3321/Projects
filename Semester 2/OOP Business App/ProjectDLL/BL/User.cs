using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDLL.BL
{
    internal class User:Person
    {
        private List <Book> books;
        public User(string name, string password, string role,string rollno): base(name, password,role)
        {
            books = new List<Book>();
        }
    }
}
