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
    public partial class Update_Student_Info : Form
    {
        string studentName;
        public Update_Student_Info(string studentName)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.studentName = studentName;
        }

        private void update_student_Click(object sender, EventArgs e)
        {
            bool isValid = InputValidate();
            if (!isValid)
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            Person person = new Person(studentName,passbox.Text);

            ObjectHandler.GetPersonDL().UpdateStudent(person);
            MessageBox.Show("Password Updated Successfully");
            this.Hide();
        }

        private bool InputValidate()
        {
            if (passbox.Text == "")
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
