using ProjectDLL.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGUI.UI
{
    public partial class Update_Book : Form
    {
        public Update_Book()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string bookName = namebox.Text;

            if (string.IsNullOrWhiteSpace(bookName))
            {
                MessageBox.Show("Please enter a book name to Update.");
                return;
            }

            Book foundBook = ObjectHandler.GetBookDL().SearchByName(bookName);

            if (foundBook != null)
            {
                Update_Book_Info update_Book_Info = new Update_Book_Info(bookName);
                update_Book_Info.Show();
                this.Hide();
            }
            else
            {
                // Book not found
                MessageBox.Show("Book not found.");
            }
        }

        // Function to search for a book by name
        public Book SearchBook(string bookName)
        {
            // Call your data access layer method to search for the book by name
            return ObjectHandler.GetBookDL().SearchByName(bookName);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void student_name_Click(object sender, EventArgs e)
        {

        }
    }
}
