using ProjectDLL.DL.DB;
using ProjectDLL.DLInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDLL.DL.FH;

namespace ProjectGUI
{
    internal class ObjectHandler
    {
        //private static IBook BookDl = new BookDB();
        //private static IPerson PersonDl = new PersonDB();

        private static IBook BookDl = new BookFH();
        private static IPerson PersonDl = new PersonFH();

        public static IBook GetBookDL()
        {
            return BookDl;
        }
        public static IPerson GetPersonDL()
        {
            return PersonDl;
        }

    }
}
