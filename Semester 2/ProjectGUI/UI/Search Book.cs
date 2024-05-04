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
    public partial class Search_Book : Form
    {
        public Search_Book()
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
                string bookName = namebox.Text;

                if (string.IsNullOrWhiteSpace(bookName))
                {
                    MessageBox.Show("Please enter a book name to search.");
                    return;
                }

                Book foundBook = ObjectHandler.GetBookDL().SearchByName(bookName);

                if (foundBook != null)
                {
                    // Book found, display its details
                    Show_Book showBookDetails = new Show_Book(bookName);
                    showBookDetails.Show();
                    this.Hide();
                }
                else
                {
                    // Book not found
                    MessageBox.Show("Book not found.");
                }
            }

            // Function to search for a book by name
            public Book SearchBook(string bookName)
            {
                // Call your data access layer method to search for the book by name
                return ObjectHandler.GetBookDL().SearchByName(bookName);
            }

        }
    }

