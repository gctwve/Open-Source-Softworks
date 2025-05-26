using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace executor
{
    public partial class Home : Form
    {
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel changelogs_Panel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button discordButton;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label label7;
        private Label label8;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Label label9;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2Panel welcome_Panel;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel status_Panel;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Label label10;
        private Guna.UI2.WinForms.Guna2HtmlLabel username;
        private Guna.UI2.WinForms.Guna2HtmlLabel robloxStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Label label11;
        public Guna.UI2.WinForms.Guna2HtmlLabel injectedStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel memoryUsage_Label;
        private Timer timer2;
        private System.ComponentModel.IContainer components;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;

        public Home()
        {
            InitializeComponent();
            memoryUsage_Label.Text = $"{GetMemoryUsage()}";
            username.Text = Environment.UserName + ".";
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.discordButton = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.changelogs_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.welcome_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.username = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.status_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.memoryUsage_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.injectedStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.robloxStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.label11 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.changelogs_Panel.SuspendLayout();
            this.welcome_Panel.SuspendLayout();
            this.status_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2Panel1.BorderRadius = 4;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.guna2CircleButton2);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.guna2CircleButton1);
            this.guna2Panel1.Controls.Add(this.discordButton);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(403, 266);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(271, 127);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(168, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "40+ Members";
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Location = new System.Drawing.Point(152, 38);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(10, 10);
            this.guna2CircleButton2.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(68, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = " 12 Online";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.LimeGreen;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(60, 38);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(10, 10);
            this.guna2CircleButton1.TabIndex = 2;
            // 
            // discordButton
            // 
            this.discordButton.BorderRadius = 10;
            this.discordButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.discordButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.discordButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.discordButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.discordButton.FillColor = System.Drawing.Color.Orange;
            this.discordButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordButton.ForeColor = System.Drawing.Color.White;
            this.discordButton.Image = global::executor.Properties.Resources.discord;
            this.discordButton.ImageSize = new System.Drawing.Size(25, 25);
            this.discordButton.Location = new System.Drawing.Point(55, 70);
            this.discordButton.Name = "discordButton";
            this.discordButton.Size = new System.Drawing.Size(170, 40);
            this.discordButton.TabIndex = 2;
            this.discordButton.Text = "Join";
            this.discordButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(56, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Open Source Softworks";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.BackgroundImage = global::executor.Properties.Resources.logo;
            this.guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Empty;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(10, 15);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2CirclePictureBox1.TabIndex = 3;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // changelogs_Panel
            // 
            this.changelogs_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.changelogs_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.changelogs_Panel.BorderRadius = 4;
            this.changelogs_Panel.BorderThickness = 1;
            this.changelogs_Panel.Controls.Add(this.label6);
            this.changelogs_Panel.Controls.Add(this.label5);
            this.changelogs_Panel.Controls.Add(this.label3);
            this.changelogs_Panel.Controls.Add(this.label2);
            this.changelogs_Panel.Controls.Add(this.label1);
            this.changelogs_Panel.Controls.Add(this.guna2Separator1);
            this.changelogs_Panel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changelogs_Panel.Location = new System.Drawing.Point(12, 180);
            this.changelogs_Panel.Name = "changelogs_Panel";
            this.changelogs_Panel.Size = new System.Drawing.Size(366, 213);
            this.changelogs_Panel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(132, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "[+] v1";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "[+] Multi API";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "[+] Tab Saving";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "[+] Clean UI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Changelogs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.guna2Separator1.Location = new System.Drawing.Point(8, 41);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(346, 23);
            this.guna2Separator1.TabIndex = 0;
            // 
            // welcome_Panel
            // 
            this.welcome_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.welcome_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.welcome_Panel.BorderRadius = 4;
            this.welcome_Panel.BorderThickness = 1;
            this.welcome_Panel.Controls.Add(this.username);
            this.welcome_Panel.Controls.Add(this.label10);
            this.welcome_Panel.Controls.Add(this.loginButton);
            this.welcome_Panel.Controls.Add(this.guna2HtmlLabel2);
            this.welcome_Panel.Controls.Add(this.guna2HtmlLabel1);
            this.welcome_Panel.Controls.Add(this.guna2ImageButton1);
            this.welcome_Panel.Location = new System.Drawing.Point(12, 20);
            this.welcome_Panel.Name = "welcome_Panel";
            this.welcome_Panel.Size = new System.Drawing.Size(366, 139);
            this.welcome_Panel.TabIndex = 8;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Orange;
            this.username.Location = new System.Drawing.Point(145, 50);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(47, 30);
            this.username.TabIndex = 8;
            this.username.Text = "user.";
            this.username.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Location = new System.Drawing.Point(10, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 28);
            this.label10.TabIndex = 7;
            this.label10.Text = "Status: Member";
            // 
            // loginButton
            // 
            this.loginButton.BorderRadius = 10;
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton.FillColor = System.Drawing.Color.Orange;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Image = global::executor.Properties.Resources.enter;
            this.loginButton.Location = new System.Drawing.Point(234, 83);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(120, 40);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(94, 50);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(56, 30);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Hello,";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(94, 16);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(262, 30);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Welcome To Open Executor,";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.guna2ImageButton1.Image = global::executor.Properties.Resources.profile;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(60, 60);
            this.guna2ImageButton1.Location = new System.Drawing.Point(15, 16);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(60, 60);
            this.guna2ImageButton1.TabIndex = 0;
            // 
            // status_Panel
            // 
            this.status_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.status_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.status_Panel.BorderRadius = 4;
            this.status_Panel.BorderThickness = 1;
            this.status_Panel.Controls.Add(this.memoryUsage_Label);
            this.status_Panel.Controls.Add(this.guna2HtmlLabel3);
            this.status_Panel.Controls.Add(this.injectedStatus);
            this.status_Panel.Controls.Add(this.guna2HtmlLabel6);
            this.status_Panel.Controls.Add(this.robloxStatus);
            this.status_Panel.Controls.Add(this.guna2HtmlLabel4);
            this.status_Panel.Controls.Add(this.guna2Separator2);
            this.status_Panel.Controls.Add(this.label11);
            this.status_Panel.Location = new System.Drawing.Point(403, 20);
            this.status_Panel.Name = "status_Panel";
            this.status_Panel.Size = new System.Drawing.Size(271, 224);
            this.status_Panel.TabIndex = 9;
            // 
            // memoryUsage_Label
            // 
            this.memoryUsage_Label.BackColor = System.Drawing.Color.Transparent;
            this.memoryUsage_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryUsage_Label.ForeColor = System.Drawing.Color.Orange;
            this.memoryUsage_Label.Location = new System.Drawing.Point(96, 145);
            this.memoryUsage_Label.Name = "memoryUsage_Label";
            this.memoryUsage_Label.Size = new System.Drawing.Size(50, 30);
            this.memoryUsage_Label.TabIndex = 13;
            this.memoryUsage_Label.Text = "0 MB";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(10, 145);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(64, 30);
            this.guna2HtmlLabel3.TabIndex = 12;
            this.guna2HtmlLabel3.Text = "Usage:";
            // 
            // injectedStatus
            // 
            this.injectedStatus.BackColor = System.Drawing.Color.Transparent;
            this.injectedStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injectedStatus.ForeColor = System.Drawing.Color.Gray;
            this.injectedStatus.Location = new System.Drawing.Point(97, 109);
            this.injectedStatus.Name = "injectedStatus";
            this.injectedStatus.Size = new System.Drawing.Size(116, 30);
            this.injectedStatus.TabIndex = 11;
            this.injectedStatus.Text = "Not Injected";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(10, 109);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(81, 30);
            this.guna2HtmlLabel6.TabIndex = 10;
            this.guna2HtmlLabel6.Text = "Injected:";
            // 
            // robloxStatus
            // 
            this.robloxStatus.BackColor = System.Drawing.Color.Transparent;
            this.robloxStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.robloxStatus.ForeColor = System.Drawing.Color.Orange;
            this.robloxStatus.Location = new System.Drawing.Point(97, 73);
            this.robloxStatus.Name = "robloxStatus";
            this.robloxStatus.Size = new System.Drawing.Size(76, 30);
            this.robloxStatus.TabIndex = 9;
            this.robloxStatus.Text = "Opened";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(10, 73);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(71, 30);
            this.guna2HtmlLabel4.TabIndex = 9;
            this.guna2HtmlLabel4.Text = "Roblox:";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.guna2Separator2.Location = new System.Drawing.Point(10, 40);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(258, 23);
            this.guna2Separator2.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(90, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 38);
            this.label11.TabIndex = 7;
            this.label11.Text = "Status";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // Home
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(755, 435);
            this.Controls.Add(this.status_Panel);
            this.Controls.Add(this.welcome_Panel);
            this.Controls.Add(this.changelogs_Panel);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.changelogs_Panel.ResumeLayout(false);
            this.changelogs_Panel.PerformLayout();
            this.welcome_Panel.ResumeLayout(false);
            this.welcome_Panel.PerformLayout();
            this.status_Panel.ResumeLayout(false);
            this.status_Panel.PerformLayout();
            this.ResumeLayout(false);

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            string discordLink = "https://discord.gg/N4vwxzXCsw";
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = discordLink,
                    UseShellExecute = true
                });

                Clipboard.SetText(discordLink);
                discordButton.Text = "Discord Opened & Copied";

                await Task.Delay(2000);

                discordButton.Text = "Join";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening link: " + ex.Message);
            }
        }

        public static string GetMemoryUsage()
        {
            var process = Process.GetCurrentProcess();
            return $"{(process.WorkingSet64 / 1024 / 1024)} MB";
        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            memoryUsage_Label.Text = $"{GetMemoryUsage()}";

            if (Api.IsRobloxOpen())
                {
                    robloxStatus.ForeColor = Color.Orange;
                    robloxStatus.Text = "Opened";
                }
                else
                {
                    robloxStatus.ForeColor = Color.Gray;
                    robloxStatus.Text = "Closed";
                }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.ShowDialog();

                string username = loginform.Username;
                this.username.Text = username;

        }
  
        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer2.Stop();
            timer2.Dispose();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

