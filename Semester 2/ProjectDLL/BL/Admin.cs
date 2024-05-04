using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDLL.BL
{
    internal class Admin:Person
    {
        List <Book> books = new List<Book>();
        public Admin(string name, string password, string role) : base(name, password,role)
        {
            books = new List<Book>();
        }
    }
}
