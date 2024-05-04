using Microsoft.SqlServer.Server;
using ProjectDLL.BL;
using ProjectDLL.DLInterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDLL.DL.DB
{
    public class PersonDB:IPerson
    {
        public void Create(Person person)
        {
            DataBase.openConnection();
            string query = $"insert into Person values('{person.getName()}','{person.getPassword()}','{person.getRole()}')";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            cmd.ExecuteNonQuery();
            DataBase.closeConnection();
        }
        public bool IsExist(string name)
        {
            DataBase.openConnection();
            string query = $"select * from Person where Name = '{name}'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bool exist = false;
            while (reader.Read())
            {
                exist = true;
            }
            DataBase.closeConnection();
            return exist;
        }
        public Person Read(string find)
        {
            DataBase.openConnection();
            string query = $"select * from Person where Name = '{find}'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Person person = null;
            while (reader.Read()) 
            {
                string name = reader["Name"].ToString();
                string password = reader["Password"].ToString();
                string role = reader["Role"].ToString();
                person = new Person(name, password, role);
            }
            DataBase.closeConnection();
            return person;

        }
        public Person signin(Person person)
        {
           
            DataBase.openConnection();
            string query = $"select * from Person where Name = '{person.getName()}' AND Password = '{person.getPassword()}'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Person per = null;
            while (reader.Read())
            {
                string name = reader["Name"].ToString();
                string password = reader["Password"].ToString();
                string role = reader["Role"].ToString();
                per = new Person(name, password, role);
            }
            DataBase.closeConnection();
            return per;
        }
        public void DeletePerson(string personName)
        {
            DataBase.openConnection();
            string query = $"DELETE FROM Person WHERE Name = '{personName}'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            cmd.ExecuteNonQuery();
            DataBase.closeConnection();
        }
        public Person check(Person person)
        {

            DataBase.openConnection();
            string query = $"select * from Person where Name = '{person.getName()}'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Person per = null;
            while (reader.Read())
            {
                string name = reader["Name"].ToString();
                string password = reader["Password"].ToString();
                string role = reader["Role"].ToString();
                per = new Person(name, password, role);
            }
            DataBase.closeConnection();
            return per;
        }
        public List<Person> ViewAllStudents()
        {
            List<Person> persons = new List<Person>();

            DataBase.openConnection();
            string query = "SELECT * FROM Person Where Role = 'Student' OR Role = 'student'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString(0);
                string password = reader.GetString(1);

                Person person = new Person(name,password);
                persons.Add(person);
            }

            reader.Close();
            DataBase.closeConnection();

            return persons;
        }
        public void UpdateStudent(Person personToUpdate)
        {
            DataBase.openConnection();
            string query = $"UPDATE Person SET Password = '{personToUpdate.getPassword()}' WHERE Name = '{personToUpdate.getName()}'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            cmd.ExecuteNonQuery();
            DataBase.closeConnection();
        }
        public Person SearchByName(string name)
        {
            Person foundPerson = null;
            DataBase.openConnection();
            string query = $"SELECT * FROM Person WHERE Name = '{name}'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                foundPerson = new Person(
                reader["Name"].ToString(),
                reader["Password"].ToString()
            );
            }

            reader.Close();
            DataBase.closeConnection();
            return foundPerson;
        }
        public Person signin1(Person person)
        {

            DataBase.openConnection();
            string query = $"select * from Person where Name = '{person.getName()}'";
            SqlCommand cmd = new SqlCommand(query, DataBase.conn);
            SqlDataReader reader = cmd.ExecuteReader();

            Person per = null;
            while (reader.Read())
            {
                string name = reader["Name"].ToString();
                string password = reader["Password"].ToString();
                string role = reader["Role"].ToString();
                per = new Person(name, password, role);
            }
            DataBase.closeConnection();
            return per;
        }
    }
}
