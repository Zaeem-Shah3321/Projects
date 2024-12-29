using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectDLL.BL;
using System.Threading.Tasks;
using ProjectConsole.Util;
using ProjectDLL.DLInterface;

namespace ProjectConsole.UI
{
    internal class PersonUI
    {
        public static Person getPersonWithRole(IPerson personDL)
        {
            string name = getStringInput("Name");
            if (personDL.Read(name) != null)
                return null;
            string password = getStringInput("Password",false);
            string role = getRole();

            return new Person(name, password, role);
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
        public static string getRole()
        {
        Again:
            Console.Write("Enter Role (Admin/Student): ");
            string role = Console.ReadLine();
            if (role.ToLower() == "admin" || role.ToLower() == "student")
            {
                return role;
            }
            else
            {
                UtilUi.Error("Invalid Role",false);
                goto Again;
            }
        }
        public static Person getPerson()
        {
            string name = getStringInput("Name");
            string password = getStringInput("Password", false);
            return new Person(name, password, "NA");
        }


    }
}
