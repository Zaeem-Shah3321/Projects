namespace ProjectGUI.UI
{
    partial class Add_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Student));
            this.passbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.student_pass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.namebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.student_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.logout = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // passbox
            // 
            this.passbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passbox.DefaultText = "";
            this.passbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passbox.Location = new System.Drawing.Point(300, 151);
            this.passbox.Name = "passbox";
            this.passbox.PasswordChar = '\0';
            this.passbox.PlaceholderText = "";
            this.passbox.SelectedText = "";
            this.passbox.Size = new System.Drawing.Size(233, 32);
            this.passbox.TabIndex = 31;
            // 
            // student_pass
            // 
            this.student_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.student_pass.BackColor = System.Drawing.Color.White;
            this.student_pass.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_pass.Location = new System.Drawing.Point(12, 151);
            this.student_pass.Name = "student_pass";
            this.student_pass.Size = new System.Drawing.Size(259, 32);
            this.student_pass.TabIndex = 30;
            this.student_pass.Text = "Student Password";
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
            this.namebox.Location = new System.Drawing.Point(300, 85);
            this.namebox.Name = "namebox";
            this.namebox.PasswordChar = '\0';
            this.namebox.PlaceholderText = "";
            this.namebox.SelectedText = "";
            this.namebox.Size = new System.Drawing.Size(233, 32);
            this.namebox.TabIndex = 29;
            // 
            // student_name
            // 
            this.student_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.student_name.BackColor = System.Drawing.Color.White;
            this.student_name.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_name.Location = new System.Drawing.Point(76, 85);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(195, 32);
            this.student_name.TabIndex = 28;
            this.student_name.Text = "Student Name";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Button1.BorderColor = System.Drawing.Color.Teal;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Red;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(185, 230);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 32;
            this.guna2Button1.Text = "Add  Student";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 322);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.student_pass);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.student_name);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox passbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel student_pass;
        private Guna.UI2.WinForms.Guna2TextBox namebox;
        private Guna.UI2.WinForms.Guna2HtmlLabel student_name;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button logout;
    }
}