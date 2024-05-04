using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDLL.BL
{
    public class Person
    {
        protected string name;
        protected string password;
        protected string role;

        public Person(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public Person(string name, string password)
        {
            this.name = name;
            this.password = password;
           
        }
        public Person(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public string getPassword()
        {
            return password;
        }
        public string getRole()
        {
            return role;
        }
    }
}
