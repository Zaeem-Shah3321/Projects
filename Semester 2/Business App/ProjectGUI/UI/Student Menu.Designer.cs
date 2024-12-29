namespace ProjectGUI.UI
{
    partial class Student_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Menu));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.logout = new Guna.UI2.WinForms.Guna2Button();
            this.update_student = new Guna.UI2.WinForms.Guna2Button();
            this.view_all = new Guna.UI2.WinForms.Guna2Button();
            this.search_book = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(37, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(451, 75);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Student Menu";
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
            this.logout.Location = new System.Drawing.Point(507, 22);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(109, 45);
            this.logout.TabIndex = 16;
            this.logout.Text = "LogOut";
            this.logout.Click += new System.EventHandler(this.logout_Click);
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
            this.update_student.Location = new System.Drawing.Point(223, 304);
            this.update_student.Name = "update_student";
            this.update_student.Size = new System.Drawing.Size(185, 45);
            this.update_student.TabIndex = 15;
            this.update_student.Text = "Change Password";
            this.update_student.Click += new System.EventHandler(this.update_student_Click);
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
            this.view_all.Location = new System.Drawing.Point(63, 177);
            this.view_all.Name = "view_all";
            this.view_all.Size = new System.Drawing.Size(180, 45);
            this.view_all.TabIndex = 14;
            this.view_all.Text = "View All Books";
            this.view_all.Click += new System.EventHandler(this.view_all_Click);
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
            this.search_book.Location = new System.Drawing.Point(413, 177);
            this.search_book.Name = "search_book";
            this.search_book.Size = new System.Drawing.Size(180, 45);
            this.search_book.TabIndex = 13;
            this.search_book.Text = "Search Book";
            this.search_book.Click += new System.EventHandler(this.search_book_Click);
            // 
            // Student_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 396);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.update_student);
            this.Controls.Add(this.view_all);
            this.Controls.Add(this.search_book);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Student_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button logout;
        private Guna.UI2.WinForms.Guna2Button update_student;
        private Guna.UI2.WinForms.Guna2Button view_all;
        private Guna.UI2.WinForms.Guna2Button search_book;
    }
}