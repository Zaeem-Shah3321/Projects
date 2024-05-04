using Guna.UI2.WinForms.Enums;
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
    public partial class AdminMenu : Form
    {
        private DataTable allBooksData = new DataTable();
        public AdminMenu()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LogIn_Page logIn_Page = new LogIn_Page();
            logIn_Page.Show();
            this.Hide();
        }
        private void add_books_Click(object sender, EventArgs e)
        {
            Add_Books add_Books = new Add_Books();
            add_Books.Show();
        }
        private void add_student_Click(object sender, EventArgs e)
        {
            Add_Student add_Student = new Add_Student();
            add_Student.Show();
        }

        private void remove_books_Click(object sender, EventArgs e)
        {
            Remove_Book remove_Book = new Remove_Book();
            remove_Book.Show();
        }

        private void remove_student_Click(object sender, EventArgs e)
        {
            Remove_Student remove_Student = new Remove_Student();
            remove_Student.Show();
        }

        private void view_all_Click(object sender, EventArgs e)
        {
            View_All_Books view_All_Books = new View_All_Books();
            view_All_Books.Show();
        }

        private void view_students_Click(object sender, EventArgs e)
        {
            View_All_Students view_All_Students = new View_All_Students();
            view_All_Students.Show();
        }

        private void search_book_Click(object sender, EventArgs e)
        {
            Search_Book search_Book = new Search_Book();
            search_Book.Show();
        }

        private void update_book_Click(object sender, EventArgs e)
        {
            Update_Book update_Book = new Update_Book();
            update_Book.Show();
        }

        private void update_student_Click(object sender, EventArgs e)
        {
            Update_Student update_Student = new Update_Student();
            update_Student.Show();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
