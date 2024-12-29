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
    public partial class Remove_Book : Form
    {
        public Remove_Book()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Remove_Book_Load(object sender, EventArgs e)
        {

        }

        private void remove_books_Click(object sender, EventArgs e)
        {
            bool isUserBookExist = ObjectHandler.GetBookDL().IsExist(namebox.Text);
            bool isValid = InputValidate();
            if (!isValid)
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            if (!isUserBookExist)
            {
                MessageBox.Show("Book Don't exist");
                return;
            }
            ObjectHandler.GetBookDL().DeleteBook(namebox.Text);
            MessageBox.Show("Book Deleted Sucessfully");
            this.Hide();
        }
        private bool InputValidate()
        {
            if (namebox.Text == "")
            {
                return false;
            }
            return true;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
