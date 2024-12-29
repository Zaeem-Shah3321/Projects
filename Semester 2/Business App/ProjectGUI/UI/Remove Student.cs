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
    public partial class Remove_Student : Form
    {
        public Remove_Student()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            bool isUserPersonExist = ObjectHandler.GetPersonDL().IsExist(namebox.Text);
            bool isValid = InputValidate();
            if (!isValid)
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            if (!isUserPersonExist)
            {
                MessageBox.Show("Student Don't exist");
                return;
            }
            Person person = new Person(namebox.Text);
            Person p = ObjectHandler.GetPersonDL().check(person);
            if (p != null)
            {
                if (p.getRole().ToLower() == "student")
                {

                    ObjectHandler.GetPersonDL().DeletePerson(namebox.Text);
                    MessageBox.Show("Student Deleted Sucessfully");
                    this.Hide(); ;
                }
                else if (p.getRole().ToLower() == "admin")
                {
                    MessageBox.Show("Invalid Student");
                }
                return;
            }
            
        }
        private bool InputValidate()
        {
            if (namebox.Text == "")
            {
                return false;
            }
            return true;
        }

    }
}
