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
    public partial class Student_Menu : Form
    {
        public Student_Menu()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void view_all_Click(object sender, EventArgs e)
        {
            View_All_Books v = new View_All_Books();
            v.Show();
        }

        private void search_book_Click(object sender, EventArgs e)
        {
            Search_Book s = new Search_Book();
            s.Show();
        }

        private void update_student_Click(object sender, EventArgs e)
        {
            Update_Student u = new Update_Student();
            u.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LogIn_Page logIn_Page = new LogIn_Page();
            logIn_Page.Show();
            this.Hide();
        }
    }
}
