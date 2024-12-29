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
    public partial class Sign_Up : Form
    {
        public Sign_Up()
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
            LogIn_Page mainpage = new LogIn_Page();
            mainpage.Show();
            this.Hide();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            
            bool isUserAlreadyExist = ObjectHandler.GetPersonDL().IsExist(namebox.Text);
            if (isUserAlreadyExist)
            {
                MessageBox.Show("User already exist");
                return;
            }
            bool isValid = InputValidate();
            if (!isValid)
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            if (rolebox.Text.ToLower() != "admin" && rolebox.Text.ToLower() != "student")
            {
                MessageBox.Show("Invalid Role");
                return;
            }
            else
            {
                Person person = new Person(namebox.Text, passbox.Text, rolebox.Text); 
                ObjectHandler.GetPersonDL().Create(person);
                MessageBox.Show("Signed Up Sucessfully");
                LogIn_Page login = new LogIn_Page();
                login.Show();
                this.Hide();
            }

        }
        private bool InputValidate()
        {
            if(namebox.Text == "" || passbox.Text == "" || rolebox.Text == "")
            {
                return false;
            }
            return true;
        }
    }
}
