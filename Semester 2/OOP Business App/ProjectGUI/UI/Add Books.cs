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
    public partial class Add_Books : Form
    {
        public Add_Books()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            bool isUserBookExist = ObjectHandler.GetBookDL().IsExist(namebox.Text);
            if (isUserBookExist)
            {
                MessageBox.Show("Book Already Exists");
                return;
            }

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

            Book book = new Book(namebox.Text, authorbox.Text, locationbox.Text, totalCopies, availableCopies);

            ObjectHandler.GetBookDL().Create(book);
            MessageBox.Show("Book Added Successfully");
            this.Hide();
        }

        private bool InputValidate()
        {
            if (namebox.Text == "" || authorbox.Text == "" || locationbox.Text == "" || totalbox.Text == "" || availablebox.Text == "")
            {
                return false;
            }
            return true;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void book_name_Click(object sender, EventArgs e)
        {

        }

        private void authorbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void author_name_Click(object sender, EventArgs e)
        {

        }

        private void locationbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Location_Click(object sender, EventArgs e)
        {

        }

        private void totalbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_copies_Click(object sender, EventArgs e)
        {

        }

        private void availablebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void copies_available_Click(object sender, EventArgs e)
        {

        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
