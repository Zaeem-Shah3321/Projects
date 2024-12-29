namespace ProjectGUI.UI
{
    partial class Add_Books
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Books));
            this.namebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.book_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.authorbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.author_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.locationbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Location = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.totalbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.total_copies = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.availablebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.copies_available = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.add = new Guna.UI2.WinForms.Guna2Button();
            this.logout = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
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
            this.namebox.Location = new System.Drawing.Point(314, 13);
            this.namebox.Name = "namebox";
            this.namebox.PasswordChar = '\0';
            this.namebox.PlaceholderText = "";
            this.namebox.SelectedText = "";
            this.namebox.Size = new System.Drawing.Size(233, 32);
            this.namebox.TabIndex = 25;
            this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // book_name
            // 
            this.book_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.book_name.BackColor = System.Drawing.Color.White;
            this.book_name.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_name.Location = new System.Drawing.Point(141, 13);
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(152, 32);
            this.book_name.TabIndex = 24;
            this.book_name.Text = "Book Name";
            this.book_name.Click += new System.EventHandler(this.book_name_Click);
            // 
            // authorbox
            // 
            this.authorbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.authorbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.authorbox.DefaultText = "";
            this.authorbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.authorbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.authorbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.authorbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.authorbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.authorbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.authorbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.authorbox.Location = new System.Drawing.Point(314, 79);
            this.authorbox.Name = "authorbox";
            this.authorbox.PasswordChar = '\0';
            this.authorbox.PlaceholderText = "";
            this.authorbox.SelectedText = "";
            this.authorbox.Size = new System.Drawing.Size(233, 32);
            this.authorbox.TabIndex = 27;
            this.authorbox.TextChanged += new System.EventHandler(this.authorbox_TextChanged);
            // 
            // author_name
            // 
            this.author_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.author_name.BackColor = System.Drawing.Color.White;
            this.author_name.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_name.Location = new System.Drawing.Point(107, 79);
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(186, 32);
            this.author_name.TabIndex = 26;
            this.author_name.Text = "Author Name";
            this.author_name.Click += new System.EventHandler(this.author_name_Click);
            // 
            // locationbox
            // 
            this.locationbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.locationbox.DefaultText = "";
            this.locationbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.locationbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.locationbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.locationbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.locationbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.locationbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.locationbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.locationbox.Location = new System.Drawing.Point(314, 148);
            this.locationbox.Name = "locationbox";
            this.locationbox.PasswordChar = '\0';
            this.locationbox.PlaceholderText = "";
            this.locationbox.SelectedText = "";
            this.locationbox.Size = new System.Drawing.Size(233, 32);
            this.locationbox.TabIndex = 29;
            this.locationbox.TextChanged += new System.EventHandler(this.locationbox_TextChanged);
            // 
            // Location
            // 
            this.Location.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Location.BackColor = System.Drawing.Color.White;
            this.Location.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location.Location = new System.Drawing.Point(165, 148);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(128, 32);
            this.Location.TabIndex = 28;
            this.Location.Text = "Location";
            this.Location.Click += new System.EventHandler(this.Location_Click);
            // 
            // totalbox
            // 
            this.totalbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalbox.DefaultText = "";
            this.totalbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalbox.Location = new System.Drawing.Point(314, 214);
            this.totalbox.Name = "totalbox";
            this.totalbox.PasswordChar = '\0';
            this.totalbox.PlaceholderText = "";
            this.totalbox.SelectedText = "";
            this.totalbox.Size = new System.Drawing.Size(233, 32);
            this.totalbox.TabIndex = 31;
            this.totalbox.TextChanged += new System.EventHandler(this.totalbox_TextChanged);
            // 
            // total_copies
            // 
            this.total_copies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.total_copies.BackColor = System.Drawing.Color.White;
            this.total_copies.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_copies.Location = new System.Drawing.Point(110, 214);
            this.total_copies.Name = "total_copies";
            this.total_copies.Size = new System.Drawing.Size(183, 32);
            this.total_copies.TabIndex = 30;
            this.total_copies.Text = "Total Copies";
            this.total_copies.Click += new System.EventHandler(this.total_copies_Click);
            // 
            // availablebox
            // 
            this.availablebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.availablebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.availablebox.DefaultText = "";
            this.availablebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.availablebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.availablebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.availablebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.availablebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.availablebox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.availablebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.availablebox.Location = new System.Drawing.Point(314, 282);
            this.availablebox.Name = "availablebox";
            this.availablebox.PasswordChar = '\0';
            this.availablebox.PlaceholderText = "";
            this.availablebox.SelectedText = "";
            this.availablebox.Size = new System.Drawing.Size(233, 32);
            this.availablebox.TabIndex = 33;
            this.availablebox.TextChanged += new System.EventHandler(this.availablebox_TextChanged);
            // 
            // copies_available
            // 
            this.copies_available.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copies_available.BackColor = System.Drawing.Color.White;
            this.copies_available.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copies_available.Location = new System.Drawing.Point(45, 282);
            this.copies_available.Name = "copies_available";
            this.copies_available.Size = new System.Drawing.Size(248, 32);
            this.copies_available.TabIndex = 32;
            this.copies_available.Text = "Copies Available";
            this.copies_available.Click += new System.EventHandler(this.copies_available_Click);
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add.BorderColor = System.Drawing.Color.Teal;
            this.add.BorderThickness = 2;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add.FillColor = System.Drawing.Color.White;
            this.add.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.add.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.add.HoverState.FillColor = System.Drawing.Color.White;
            this.add.HoverState.ForeColor = System.Drawing.Color.Red;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.add.Location = new System.Drawing.Point(227, 352);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(180, 45);
            this.add.TabIndex = 34;
            this.add.Text = "Add Book";
            this.add.Click += new System.EventHandler(this.add_Click);
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
            this.logout.Location = new System.Drawing.Point(12, 13);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(44, 32);
            this.logout.TabIndex = 35;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Add_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 413);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.add);
            this.Controls.Add(this.availablebox);
            this.Controls.Add(this.copies_available);
            this.Controls.Add(this.totalbox);
            this.Controls.Add(this.total_copies);
            this.Controls.Add(this.locationbox);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.authorbox);
            this.Controls.Add(this.author_name);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.book_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox namebox;
        private Guna.UI2.WinForms.Guna2HtmlLabel book_name;
        private Guna.UI2.WinForms.Guna2TextBox authorbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel author_name;
        private Guna.UI2.WinForms.Guna2TextBox locationbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel Location;
        private Guna.UI2.WinForms.Guna2TextBox totalbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel total_copies;
        private Guna.UI2.WinForms.Guna2TextBox availablebox;
        private Guna.UI2.WinForms.Guna2HtmlLabel copies_available;
        private Guna.UI2.WinForms.Guna2Button add;
        private Guna.UI2.WinForms.Guna2Button logout;
    }
}