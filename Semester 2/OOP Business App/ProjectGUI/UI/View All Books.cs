using Guna.UI2.WinForms;
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
using ProjectDLL.DL;

namespace ProjectGUI.UI
{
    public partial class View_All_Books : Form
    {
        private DataTable allBooksData;
        public View_All_Books()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            List <Book> booksDataTable = ObjectHandler.GetBookDL().ViewAllBooks();
            guna2DataGridView1.DataSource = booksDataTable;
            DataTable dt = new DataTable();
            // add columns to the table
            dt.Columns.Add("Name");
            dt.Columns.Add("Author");
            dt.Columns.Add("Location");
            dt.Columns.Add("Total Copies");
            dt.Columns.Add("Available Copies");

            // add the history of the user to the table
            foreach (Book book in booksDataTable)
                dt.Rows.Add(book.getName(), book.getAuthor(), book.getLocation(), book.getCopies(), book.getCopiesAvailable());

            guna2DataGridView1.DataSource = dt;
        }
        

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void view_all_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
