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
    public class PersonFH:IPerson
    {
        private string filePath = "F:\\Semester 2\\OOP\\OOP-MAIN_PROJ\\FileHandeling\\persons.txt";

        public void Create(Person person)
        {
            // Open the file
            using (StreamWriter writer = File.AppendText(filePath))
            {
                // Write the person's data to the file
                writer.WriteLine($"{person.getName()},{person.getPassword()},{person.getRole().ToLower()}");
            }
        }

        public bool IsExist(string name)
        {
            // Read all lines from the file
            List<string> lines = File.ReadAllLines(filePath).ToList();
            // Check if any line contains the specified name
            return lines.Any(line => line.StartsWith(name + ","));
        }

        public Person Read(string find)
        {
            // Read all lines from the file
            List<string> lines = File.ReadAllLines(filePath).ToList();
            // Find the line that starts with the specified name
            string line = lines.FirstOrDefault(l => l.StartsWith(find + ","));
            if (line != null)
            {
                string[] parts = line.Split(',');
                return new Person(parts[0], parts[1], parts[2]);
            }
            return null;
        }

        public Person signin(Person person)
        {
            // Read all lines from the file
            List<string> lines = File.ReadAllLines(filePath).ToList();
            string line = lines.FirstOrDefault(l => l.StartsWith($"{person.getName()},{person.getPassword()},"));
            if (line != null)
            {
                // Split the line
                string[] parts = line.Split(',');
                return new Person(parts[0], parts[1], parts[2]);
            }
            return null;
        }

        public void DeletePerson(string personName)
        {
            // Read all lines from the file
            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<string> updatedLines = lines.Where(line => !line.StartsWith(personName + ",")).ToList();
            // Write the updated lines back to the file
            File.WriteAllLines(filePath, updatedLines);
        }

        public List<Person> ViewAllStudents()
        {
            // Read all lines from the file
            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<Person> students = new List<Person>();
            foreach (string line in lines)
            {
                // Split each line and check if the role is "Student" or "student"
                string[] parts = line.Split(',');
                if (parts[2].Equals("Student", StringComparison.OrdinalIgnoreCase))
                {
                    students.Add(new Person(parts[0], parts[1]));
                }
            }
            return students;
        }

        public void UpdateStudent(Person personToUpdate)
        {
            // Read all lines from the file
            List<string> lines = File.ReadAllLines(filePath).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts[0] == personToUpdate.getName())
                {
                    // Update the password in the line
                    lines[i] = $"{personToUpdate.getName()},{personToUpdate.getPassword()},{parts[2]}";
                    break;
                }
            }
            // Write the updated lines back to the file
            File.WriteAllLines(filePath, lines);
        }

        public Person SearchByName(string name)
        {
            // Read all lines from the file
            List<string> lines = File.ReadAllLines(filePath).ToList();
            // Find the line that starts with the specified name
            string line = lines.FirstOrDefault(l => l.StartsWith(name + ","));
            if (line != null)
            {
                string[] parts = line.Split(',');
                return new Person(parts[0], parts[1]);
            }
            return null;
        }
        public Person signin1(Person person)
        {
            // Read all lines from the file
            List<string> lines = File.ReadAllLines(filePath).ToList();
            string line = lines.FirstOrDefault(l => l.StartsWith($"{person.getName()},"));
            if (line != null)
            {
                // Split the line.
                string[] parts = line.Split(',');
                return new Person(parts[0], parts[1], parts[2]);
            }
            return null;
        }
        public Person check(Person person)
        {
            // Read all lines from the file
            List<string> lines = File.ReadAllLines(filePath).ToList();
            string line = lines.FirstOrDefault(l => l.StartsWith($"{person.getName()},"));
            if (line != null)
            {
                string[] parts = line.Split(',');
                return new Person(parts[0], parts[1], parts[2]);
            }
            return null;
        }


    }
}
