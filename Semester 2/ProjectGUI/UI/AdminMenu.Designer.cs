namespace ProjectGUI.UI
{
    partial class AdminMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.add_books = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.search_book = new Guna.UI2.WinForms.Guna2Button();
            this.view_all = new Guna.UI2.WinForms.Guna2Button();
            this.update_student = new Guna.UI2.WinForms.Guna2Button();
            this.remove_student = new Guna.UI2.WinForms.Guna2Button();
            this.add_student = new Guna.UI2.WinForms.Guna2Button();
            this.update_book = new Guna.UI2.WinForms.Guna2Button();
            this.remove_books = new Guna.UI2.WinForms.Guna2Button();
            this.view_students = new Guna.UI2.WinForms.Guna2Button();
            this.logout = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // add_books
            // 
            this.add_books.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_books.BorderColor = System.Drawing.Color.Teal;
            this.add_books.BorderThickness = 2;
            this.add_books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_books.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_books.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_books.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_books.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_books.FillColor = System.Drawing.Color.White;
            this.add_books.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_books.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.add_books.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.add_books.HoverState.FillColor = System.Drawing.Color.White;
            this.add_books.HoverState.ForeColor = System.Drawing.Color.Red;
            this.add_books.Image = ((System.Drawing.Image)(resources.GetObject("add_books.Image")));
            this.add_books.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.add_books.Location = new System.Drawing.Point(22, 139);
            this.add_books.Name = "add_books";
            this.add_books.Size = new System.Drawing.Size(180, 45);
            this.add_books.TabIndex = 0;
            this.add_books.Text = "Add Book";
            this.add_books.Click += new System.EventHandler(this.add_books_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(186, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(377, 75);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Admin Menu";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // search_book
            // 
            this.search_book.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_book.BorderColor = System.Drawing.Color.Teal;
            this.search_book.BorderThickness = 2;
            this.search_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_book.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.search_book.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.search_book.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.search_book.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.search_book.FillColor = System.Drawing.Color.White;
            this.search_book.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_book.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.search_book.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.search_book.HoverState.FillColor = System.Drawing.Color.White;
            this.search_book.HoverState.ForeColor = System.Drawing.Color.Red;
            this.search_book.Image = ((System.Drawing.Image)(resources.GetObject("search_book.Image")));
            this.search_book.Location = new System.Drawing.Point(317, 222);
            this.search_book.Name = "search_book";
            this.search_book.Size = new System.Drawing.Size(180, 45);
            this.search_book.TabIndex = 2;
            this.search_book.Text = "Search Book";
            this.search_book.Click += new System.EventHandler(this.search_book_Click);
            // 
            // view_all
            // 
            this.view_all.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.view_all.BorderColor = System.Drawing.Color.Teal;
            this.view_all.BorderThickness = 2;
            this.view_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_all.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.view_all.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.view_all.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.view_all.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.view_all.FillColor = System.Drawing.Color.White;
            this.view_all.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_all.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.view_all.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_all.HoverState.FillColor = System.Drawing.Color.White;
            this.view_all.HoverState.ForeColor = System.Drawing.Color.Red;
            this.view_all.Image = ((System.Drawing.Image)(resources.GetObject("view_all.Image")));
            this.view_all.Location = new System.Drawing.Point(22, 222);
            this.view_all.Name = "view_all";
            this.view_all.Size = new System.Drawing.Size(180, 45);
            this.view_all.TabIndex = 3;
            this.view_all.Text = "View All Books";
            this.view_all.Click += new System.EventHandler(this.view_all_Click);
            // 
            // update_student
            // 
            this.update_student.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_student.BorderColor = System.Drawing.Color.Teal;
            this.update_student.BorderThickness = 2;
            this.update_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_student.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update_student.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update_student.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_student.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update_student.FillColor = System.Drawing.Color.White;
            this.update_student.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_student.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.update_student.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.update_student.HoverState.FillColor = System.Drawing.Color.White;
            this.update_student.HoverState.ForeColor = System.Drawing.Color.Red;
            this.update_student.Image = ((System.Drawing.Image)(resources.GetObject("update_student.Image")));
            this.update_student.Location = new System.Drawing.Point(317, 306);
            this.update_student.Name = "update_student";
            this.update_student.Size = new System.Drawing.Size(180, 45);
            this.update_student.TabIndex = 4;
            this.update_student.Text = "Update Student";
            this.update_student.Click += new System.EventHandler(this.update_student_Click);
            // 
            // remove_student
            // 
            this.remove_student.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remove_student.BorderColor = System.Drawing.Color.Teal;
            this.remove_student.BorderThickness = 2;
            this.remove_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove_student.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.remove_student.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.remove_student.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.remove_student.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.remove_student.FillColor = System.Drawing.Color.White;
            this.remove_student.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_student.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.remove_student.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.remove_student.HoverState.FillColor = System.Drawing.Color.White;
            this.remove_student.HoverState.ForeColor = System.Drawing.Color.Red;
            this.remove_student.Image = ((System.Drawing.Image)(resources.GetObject("remove_student.Image")));
            this.remove_student.Location = new System.Drawing.Point(22, 306);
            this.remove_student.Name = "remove_student";
            this.remove_student.Size = new System.Drawing.Size(180, 45);
            this.remove_student.TabIndex = 5;
            this.remove_student.Text = "Remove Student";
            this.remove_student.Click += new System.EventHandler(this.remove_student_Click);
            // 
            // add_student
            // 
            this.add_student.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_student.BorderColor = System.Drawing.Color.Teal;
            this.add_student.BorderThickness = 2;
            this.add_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_student.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_student.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_student.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_student.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_student.FillColor = System.Drawing.Color.White;
            this.add_student.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_student.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.add_student.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.add_student.HoverState.FillColor = System.Drawing.Color.White;
            this.add_student.HoverState.ForeColor = System.Drawing.Color.Red;
            this.add_student.Image = ((System.Drawing.Image)(resources.GetObject("add_student.Image")));
            this.add_student.Location = new System.Drawing.Point(605, 222);
            this.add_student.Name = "add_student";
            this.add_student.Size = new System.Drawing.Size(180, 45);
            this.add_student.TabIndex = 6;
            this.add_student.Text = "Add  Student";
            this.add_student.Click += new System.EventHandler(this.add_student_Click);
            // 
            // update_book
            // 
            this.update_book.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_book.BorderColor = System.Drawing.Color.Teal;
            this.update_book.BorderThickness = 2;
            this.update_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_book.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update_book.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update_book.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_book.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update_book.FillColor = System.Drawing.Color.White;
            this.update_book.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_book.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.update_book.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.update_book.HoverState.FillColor = System.Drawing.Color.White;
            this.update_book.HoverState.ForeColor = System.Drawing.Color.Red;
            this.update_book.Image = ((System.Drawing.Image)(resources.GetObject("update_book.Image")));
            this.update_book.Location = new System.Drawing.Point(605, 139);
            this.update_book.Name = "update_book";
            this.update_book.Size = new System.Drawing.Size(180, 45);
            this.update_book.TabIndex = 7;
            this.update_book.Text = "Update Book";
            this.update_book.Click += new System.EventHandler(this.update_book_Click);
            // 
            // remove_books
            // 
            this.remove_books.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remove_books.BorderColor = System.Drawing.Color.Teal;
            this.remove_books.BorderThickness = 2;
            this.remove_books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove_books.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.remove_books.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.remove_books.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.remove_books.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.remove_books.FillColor = System.Drawing.Color.White;
            this.remove_books.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_books.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.remove_books.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.remove_books.HoverState.FillColor = System.Drawing.Color.White;
            this.remove_books.HoverState.ForeColor = System.Drawing.Color.Red;
            this.remove_books.Image = ((System.Drawing.Image)(resources.GetObject("remove_books.Image")));
            this.remove_books.Location = new System.Drawing.Point(317, 139);
            this.remove_books.Name = "remove_books";
            this.remove_books.Size = new System.Drawing.Size(180, 45);
            this.remove_books.TabIndex = 8;
            this.remove_books.Text = "Remove Book";
            this.remove_books.Click += new System.EventHandler(this.remove_books_Click);
            // 
            // view_students
            // 
            this.view_students.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.view_students.BorderColor = System.Drawing.Color.Teal;
            this.view_students.BorderThickness = 2;
            this.view_students.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view_students.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.view_students.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.view_students.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.view_students.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.view_students.FillColor = System.Drawing.Color.White;
            this.view_students.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_students.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.view_students.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.view_students.HoverState.FillColor = System.Drawing.Color.White;
            this.view_students.HoverState.ForeColor = System.Drawing.Color.Red;
            this.view_students.Image = ((System.Drawing.Image)(resources.GetObject("view_students.Image")));
            this.view_students.Location = new System.Drawing.Point(605, 306);
            this.view_students.Name = "view_students";
            this.view_students.Size = new System.Drawing.Size(180, 45);
            this.view_students.TabIndex = 10;
            this.view_students.Text = "View All Students";
            this.view_students.Click += new System.EventHandler(this.view_students_Click);
            // 
            // logout
            // 
            this.logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logout.BorderColor = System.Drawing.Color.Teal;
            this.logout.BorderThickness = 2;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logout.FillColor = System.Drawing.Color.White;
            this.logout.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.logout.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.logout.HoverState.FillColor = System.Drawing.Color.White;
            this.logout.HoverState.ForeColor = System.Drawing.Color.Red;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.Location = new System.Drawing.Point(676, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(109, 45);
            this.logout.TabIndex = 11;
            this.logout.Text = "LogOut";
            this.logout.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 391);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.view_students);
            this.Controls.Add(this.remove_books);
            this.Controls.Add(this.update_book);
            this.Controls.Add(this.add_student);
            this.Controls.Add(this.remove_student);
            this.Controls.Add(this.update_student);
            this.Controls.Add(this.view_all);
            this.Controls.Add(this.search_book);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.add_books);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button add_books;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button search_book;
        private Guna.UI2.WinForms.Guna2Button view_all;
        private Guna.UI2.WinForms.Guna2Button update_student;
        private Guna.UI2.WinForms.Guna2Button remove_student;
        private Guna.UI2.WinForms.Guna2Button add_student;
        private Guna.UI2.WinForms.Guna2Button update_book;
        private Guna.UI2.WinForms.Guna2Button remove_books;
        private Guna.UI2.WinForms.Guna2Button view_students;
        private Guna.UI2.WinForms.Guna2Button logout;
    }
}