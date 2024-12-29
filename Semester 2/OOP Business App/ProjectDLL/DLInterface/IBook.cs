using ProjectDLL.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDLL.DLInterface
{
    public interface IBook
    {
        void Create(Book book);
        Book Read(string name);
        void DeleteBook(string bookName);
        List<Book> ViewAllBooks();
        void UpdateBook(Book bookToUpdate);
        Book SearchByName(string name);
        bool IsExist(string name);
    }
}
