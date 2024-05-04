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
    public partial class Add_Student : Form
    {
        public Add_Student()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            bool isUserAlreadyExist = ObjectHandler.GetPersonDL().IsExist(namebox.Text);
            if (isUserAlreadyExist)
            {
                MessageBox.Show("Student already exist");
                return;
            }
            bool isValid = InputValidate();
            if (!isValid)
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }
            Person person = new Person(namebox.Text, passbox.Text, "student");
            ObjectHandler.GetPersonDL().Create(person);
            MessageBox.Show("Student Added Sucessfully");
            this.Hide();

        }
        private bool InputValidate()
        {
            if (namebox.Text == "" || passbox.Text == "")
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
