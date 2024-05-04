namespace ProjectGUI.UI
{
    partial class Remove_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove_Book));
            this.remove_books = new Guna.UI2.WinForms.Guna2Button();
            this.namebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.student_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.logout = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
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
            this.remove_books.Location = new System.Drawing.Point(171, 224);
            this.remove_books.Name = "remove_books";
            this.remove_books.Size = new System.Drawing.Size(180, 45);
            this.remove_books.TabIndex = 9;
            this.remove_books.Text = "Remove Book";
            this.remove_books.Click += new System.EventHandler(this.remove_books_Click);
            // 
            // namebox
            // 
            this.namebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.namebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.namebox.DefaultText = "";
            this.namebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.namebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.namebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.namebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.namebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.namebox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.namebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.namebox.Location = new System.Drawing.Point(237, 120);
            this.namebox.Name = "namebox";
            this.namebox.PasswordChar = '\0';
            this.namebox.PlaceholderText = "";
            this.namebox.SelectedText = "";
            this.namebox.Size = new System.Drawing.Size(268, 32);
            this.namebox.TabIndex = 31;
            // 
            // student_name
            // 
            this.student_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.student_name.BackColor = System.Drawing.Color.White;
            this.student_name.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_name.Location = new System.Drawing.Point(43, 120);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(152, 32);
            this.student_name.TabIndex = 30;
            this.student_name.Text = "Book Name";
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
            this.logout.Location = new System.Drawing.Point(12, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(44, 32);
            this.logout.TabIndex = 36;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Remove_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 322);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.student_name);
            this.Controls.Add(this.remove_books);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Remove_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove_Book";
            this.Load += new System.EventHandler(this.Remove_Book_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button remove_books;
        private Guna.UI2.WinForms.Guna2TextBox namebox;
        private Guna.UI2.WinForms.Guna2HtmlLabel student_name;
        private Guna.UI2.WinForms.Guna2Button logout;
    }
}