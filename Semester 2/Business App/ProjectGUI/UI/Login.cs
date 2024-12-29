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
using ProjectGUI.UI;
using ProjectDLL;
using Guna.UI2.WinForms;

namespace ProjectGUI
{
    public partial class LogIn_Page : Form
    {
        public LogIn_Page()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (passbox.PasswordChar == '●')
            {
                hidepassword.Image = ProjectGUI.Properties.Resources.hide;
                passbox.UseSystemPasswordChar = false;
                passbox.PasswordChar = '\0';
            }
            else
            {
                hidepassword.Image = ProjectGUI.Properties.Resources.view;
                passbox.UseSystemPasswordChar = true;
                passbox.PasswordChar = '●';
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Sign_Up signup = new Sign_Up();
            signup.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            
            Person person = new Person(namebox.Text,passbox.Text);
            Person p = ObjectHandler.GetPersonDL().signin(person);
      
            if (p != null)
            {
                if (p.getRole().ToLower() == "admin")
                {

                    AdminMenu a = new AdminMenu();
                    a.Show();
                    this.Hide();
                }
                else if (p.getRole().ToLower() == "student")
                {
                    Student_Menu s = new Student_Menu();
                    s.Show();
                    this.Hide();
                }
                return;
            }
            bool isValid = InputValidate();
            if (!isValid)
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            MessageBox.Show("user not found");
        }
        private bool InputValidate()
        {
            if (namebox.Text == "" || passbox.Text == "")
            {
                return false;
            }
            return true;
        }

        private void LogIn_Page_Load(object sender, EventArgs e)
        {

        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
