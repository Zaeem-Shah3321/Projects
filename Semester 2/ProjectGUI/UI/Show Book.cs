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
    public partial class Show_Book : Form
    {
        public Show_Book(string name)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            DataTable dt = new DataTable();
            // add columns to the table
            dt.Columns.Add("Name");
            dt.Columns.Add("Author");
            dt.Columns.Add("Location");
            dt.Columns.Add("Total Copies");
            dt.Columns.Add("Available Copies");

            Book book = ObjectHandler.GetBookDL().SearchByName(name);
            dt.Rows.Add(book.getName(), book.getAuthor(), book.getLocation(), book.getCopies(), book.getCopiesAvailable());

            guna2DataGridView1.DataSource = dt;
        }

        private void view_all_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
