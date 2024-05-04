using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectDLL.BL;

namespace ProjectGUI.UI
{
    public partial class Update_Book_Info : Form
    {
        public string bookName;
        public Update_Book_Info(string bookName)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.bookName = bookName;

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void update_book_Click(object sender, EventArgs e)
        {
            bool isValid = InputValidate();
            if (!isValid)
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            int totalCopies, availableCopies;
            try
            {
                totalCopies = int.Parse(totalbox.Text);
                availableCopies = int.Parse(availablebox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Input For Copies. Please Enter A Valid Number.");
                return;
            }

 
            Book book = new Book(bookName, authorbox.Text, locationbox.Text, int.Parse(totalbox.Text), int.Parse(availablebox.Text));

            ObjectHandler.GetBookDL().UpdateBook(book);
            MessageBox.Show("Book Updated Successfully");
            this.Hide();
        }

        private bool InputValidate()
        {
            if (authorbox.Text == "" || locationbox.Text == "" || totalbox.Text == "" || availablebox.Text == "")
            {
                return false;
            }
            return true;
        }
       
    }
}
