using ProjectDLL.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDLL.DLInterface
{
    public interface IPerson
    {
        void Create(Person person);
        Person Read (string name);
        Person signin(Person person);
        bool IsExist(string name);
        Person check(Person person);
        void DeletePerson(string bookName);
        List<Person> ViewAllStudents();
        void UpdateStudent(Person personToUpdate);
        Person SearchByName(string name);
        Person signin1(Person person);


    }
}
