namespace executor
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.login_Logo = new Guna.UI2.WinForms.Guna2Button();
            this.minimzeButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.closeButton1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.rememberMe = new Guna.UI2.WinForms.Guna2CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginButton1
            // 
            this.loginButton1.BorderRadius = 4;
            this.loginButton1.BorderThickness = 1;
            this.loginButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton1.FillColor = System.Drawing.Color.Orange;
            this.loginButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginButton1.ForeColor = System.Drawing.Color.White;
            this.loginButton1.Location = new System.Drawing.Point(125, 211);
            this.loginButton1.Name = "loginButton1";
            this.loginButton1.Size = new System.Drawing.Size(180, 45);
            this.loginButton1.TabIndex = 4;
            this.loginButton1.Text = "Login";
            this.loginButton1.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.login_Logo);
            this.guna2Panel1.Controls.Add(this.minimzeButton1);
            this.guna2Panel1.Controls.Add(this.closeButton1);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, 1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(638, 42);
            this.guna2Panel1.TabIndex = 6;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseMove);
            this.guna2Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Open Source Softworks";
            // 
            // login_Logo
            // 
            this.login_Logo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_Logo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_Logo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_Logo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_Logo.FillColor = System.Drawing.Color.Transparent;
            this.login_Logo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_Logo.ForeColor = System.Drawing.Color.White;
            this.login_Logo.Image = global::executor.Properties.Resources.logo2;
            this.login_Logo.ImageSize = new System.Drawing.Size(25, 25);
            this.login_Logo.Location = new System.Drawing.Point(13, 1);
            this.login_Logo.Name = "login_Logo";
            this.login_Logo.Size = new System.Drawing.Size(40, 40);
            this.login_Logo.TabIndex = 2;
            // 
            // minimzeButton1
            // 
            this.minimzeButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minimzeButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minimzeButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimzeButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minimzeButton1.FillColor = System.Drawing.Color.Transparent;
            this.minimzeButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimzeButton1.ForeColor = System.Drawing.Color.White;
            this.minimzeButton1.Image = global::executor.Properties.Resources.ic_fluent_subtract_24_filled;
            this.minimzeButton1.Location = new System.Drawing.Point(461, 0);
            this.minimzeButton1.Name = "minimzeButton1";
            this.minimzeButton1.Size = new System.Drawing.Size(67, 45);
            this.minimzeButton1.TabIndex = 1;
            this.minimzeButton1.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // closeButton1
            // 
            this.closeButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeButton1.FillColor = System.Drawing.Color.Transparent;
            this.closeButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeButton1.ForeColor = System.Drawing.Color.White;
            this.closeButton1.Image = global::executor.Properties.Resources.ic_fluent_dismiss_24_filled;
            this.closeButton1.Location = new System.Drawing.Point(528, 0);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(67, 45);
            this.closeButton1.TabIndex = 0;
            this.closeButton1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(247, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // textBox
            // 
            this.textBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox.BorderRadius = 4;
            this.textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox.DefaultText = "";
            this.textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox.IconLeft = global::executor.Properties.Resources.icons8_username_60;
            this.textBox.Location = new System.Drawing.Point(125, 135);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox.Name = "textBox";
            this.textBox.PasswordChar = '\0';
            this.textBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBox.PlaceholderText = "Username";
            this.textBox.SelectedText = "";
            this.textBox.Size = new System.Drawing.Size(362, 56);
            this.textBox.TabIndex = 7;
            // 
            // rememberMe
            // 
            this.rememberMe.AutoSize = true;
            this.rememberMe.CheckedState.BorderColor = System.Drawing.Color.Orange;
            this.rememberMe.CheckedState.BorderRadius = 1;
            this.rememberMe.CheckedState.BorderThickness = 1;
            this.rememberMe.CheckedState.FillColor = System.Drawing.Color.Orange;
            this.rememberMe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberMe.ForeColor = System.Drawing.Color.White;
            this.rememberMe.Location = new System.Drawing.Point(323, 221);
            this.rememberMe.Name = "rememberMe";
            this.rememberMe.Size = new System.Drawing.Size(148, 27);
            this.rememberMe.TabIndex = 8;
            this.rememberMe.Text = "Remember me.";
            this.rememberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rememberMe.UncheckedState.BorderRadius = 2;
            this.rememberMe.UncheckedState.BorderThickness = 1;
            this.rememberMe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.rememberMe.CheckedChanged += new System.EventHandler(this.rememberMe_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(594, 338);
            this.Controls.Add(this.rememberMe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.loginButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login | Open Executor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button closeButton1;
        private Guna.UI2.WinForms.Guna2Button minimzeButton1;
        private Guna.UI2.WinForms.Guna2Button login_Logo;
        private Guna.UI2.WinForms.Guna2Button loginButton1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CheckBox rememberMe;
        private System.Windows.Forms.Timer timer1;
    }
}