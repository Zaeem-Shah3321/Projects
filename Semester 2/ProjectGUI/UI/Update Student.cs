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
    public partial class Update_Student : Form
    {
        public Update_Student()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string studentName = namebox.Text;

            if (string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Please enter a Student name to Update.");
                return;
            }

            Person foundStudent = ObjectHandler.GetPersonDL().SearchByName(studentName);

            Person person = new Person(namebox.Text);
            Person p = ObjectHandler.GetPersonDL().signin1(person);

            if (foundStudent != null)
            {
                if (p != null)
                {
                    if (p.getRole().ToLower() == "student")
                    {
                        Update_Student_Info update_Student_Info = new Update_Student_Info(studentName);
                        update_Student_Info.Show();
                        this.Hide();
                    }
                    else if (p.getRole().ToLower() == "admin")
                    {
                        // Student not found
                        MessageBox.Show("Invalid Student.");
                    } 
                }
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
        }

        // Function to search for a book by name
        public Person SearchStudent(string studentName)
        {
            // Call your data access layer method to search for the book by name
           return ObjectHandler.GetPersonDL().SearchByName(studentName);
           
        }

    }
}
