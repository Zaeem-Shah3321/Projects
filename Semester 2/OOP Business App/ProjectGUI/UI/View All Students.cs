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
    public partial class View_All_Students : Form
    {
        private DataTable allStudentData;
        public View_All_Students()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            List<Person> personDataTable = ObjectHandler.GetPersonDL().ViewAllStudents();
            guna2DataGridView1.DataSource = personDataTable;
            DataTable dt = new DataTable();
            // add columns to the table
            dt.Columns.Add("Name");
            dt.Columns.Add("Password");

            // add the history of the user to the table
            foreach (Person person in personDataTable)
                dt.Rows.Add(person.getName(), person.getPassword());

            guna2DataGridView1.DataSource = dt;
        }

        private void view_all_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
