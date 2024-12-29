namespace ProjectGUI.UI
{
    partial class Sign_Up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_Up));
            this.signup = new Guna.UI2.WinForms.Guna2Button();
            this.passbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.hidepassword = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.namebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rolebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.singin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // signup
            // 
            this.signup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signup.BackColor = System.Drawing.Color.White;
            this.signup.BorderColor = System.Drawing.Color.White;
            this.signup.BorderThickness = 2;
            this.signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signup.FillColor = System.Drawing.Color.Transparent;
            this.signup.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.Red;
            this.signup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.signup.HoverState.FillColor = System.Drawing.Color.Red;
            this.signup.HoverState.ForeColor = System.Drawing.Color.White;
            this.signup.Location = new System.Drawing.Point(367, 375);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(117, 28);
            this.signup.TabIndex = 29;
            this.signup.Text = "Sign Up";
            this.signup.Click += new System.EventHandler(this.signup_Click);
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
            this.passbox.Location = new System.Drawing.Point(407, 242);
            this.passbox.Name = "passbox";
            this.passbox.PasswordChar = '●';
            this.passbox.PlaceholderText = "";
            this.passbox.SelectedText = "";
            this.passbox.Size = new System.Drawing.Size(190, 32);
            this.passbox.TabIndex = 28;
            // 
            // hidepassword
            // 
            this.hidepassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hidepassword.BackColor = System.Drawing.Color.Transparent;
            this.hidepassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hidepassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hidepassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hidepassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hidepassword.FillColor = System.Drawing.Color.White;
            this.hidepassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hidepassword.ForeColor = System.Drawing.Color.White;
            this.hidepassword.Image = global::ProjectGUI.Properties.Resources.view;
            this.hidepassword.Location = new System.Drawing.Point(603, 242);
            this.hidepassword.Name = "hidepassword";
            this.hidepassword.Size = new System.Drawing.Size(37, 32);
            this.hidepassword.TabIndex = 27;
            this.hidepassword.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Algerian", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(235, 241);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(147, 33);
            this.guna2HtmlLabel2.TabIndex = 24;
            this.guna2HtmlLabel2.Text = "Password";
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
            this.namebox.Location = new System.Drawing.Point(407, 184);
            this.namebox.Name = "namebox";
            this.namebox.PasswordChar = '\0';
            this.namebox.PlaceholderText = "";
            this.namebox.SelectedText = "";
            this.namebox.Size = new System.Drawing.Size(233, 32);
            this.namebox.TabIndex = 23;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(234, 184);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(148, 32);
            this.guna2HtmlLabel1.TabIndex = 22;
            this.guna2HtmlLabel1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 54);
            this.label2.TabIndex = 21;
            this.label2.Text = "Create Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 20;
            // 
            // rolebox
            // 
            this.rolebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rolebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rolebox.DefaultText = "";
            this.rolebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rolebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rolebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rolebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rolebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rolebox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rolebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rolebox.Location = new System.Drawing.Point(407, 301);
            this.rolebox.Name = "rolebox";
            this.rolebox.PasswordChar = '\0';
            this.rolebox.PlaceholderText = "";
            this.rolebox.SelectedText = "";
            this.rolebox.Size = new System.Drawing.Size(233, 32);
            this.rolebox.TabIndex = 31;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(313, 301);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(69, 32);
            this.guna2HtmlLabel4.TabIndex = 30;
            this.guna2HtmlLabel4.Text = "Role";
            // 
            // singin
            // 
            this.singin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.singin.BorderColor = System.Drawing.Color.White;
            this.singin.BorderThickness = 2;
            this.singin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.singin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.singin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.singin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.singin.FillColor = System.Drawing.Color.Transparent;
            this.singin.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singin.ForeColor = System.Drawing.Color.Red;
            this.singin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.singin.HoverState.FillColor = System.Drawing.Color.Red;
            this.singin.HoverState.ForeColor = System.Drawing.Color.White;
            this.singin.Location = new System.Drawing.Point(580, 450);
            this.singin.Name = "singin";
            this.singin.Size = new System.Drawing.Size(101, 26);
            this.singin.TabIndex = 33;
            this.singin.Text = "Sign In";
            this.singin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.singin.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(272, 450);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(302, 26);
            this.guna2HtmlLabel3.TabIndex = 32;
            this.guna2HtmlLabel3.Text = "Already Have an Account ?";
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 524);
            this.Controls.Add(this.singin);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.rolebox);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.hidepassword);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sign_Up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign_Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button signup;
        private Guna.UI2.WinForms.Guna2TextBox passbox;
        private Guna.UI2.WinForms.Guna2Button hidepassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox namebox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox rolebox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button singin;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}