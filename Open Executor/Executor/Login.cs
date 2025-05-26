using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace executor
{
    public partial class Login : Form
    { 
        private bool isDragging = false;
        private int offsetX = 0;
        private int offsetY = 0;
        public string Username { get; private set; }
        public Login()
        {
            InitializeComponent();
            guna2Panel1.MouseDown += new MouseEventHandler(guna2Panel1_MouseDown);
            guna2Panel1.MouseMove += new MouseEventHandler(guna2Panel1_MouseMove);
            guna2Panel1.MouseUp += new MouseEventHandler(guna2Panel1_MouseUp);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radius = 10;


            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, radius * 2, radius * 2, 180, 90); // Top left corner
                path.AddArc(this.Width - radius * 2 - 1, 0, radius * 2, radius * 2, 270, 90); // Top right corner
                path.AddArc(this.Width - radius * 2 - 1, this.Height - radius * 2 - 1, radius * 2, radius * 2, 0, 90); // Bottom right corner
                path.AddArc(0, this.Height - radius * 2 - 1, radius * 2, radius * 2, 90, 90); // Bottom left corner
                path.CloseFigure();

                this.Region = new Region(path);

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
           

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Username = textBox.Text;
            if (string.IsNullOrWhiteSpace(Username))
            {
                Username = "user.";
            }
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
     
                // Check if the username field is empty
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    // Show a message box if the username field is empty
                    MessageBox.Show("Please enter a username.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                // Proceed with login logic if the username is filled
                Username = textBox.Text + ".";
                this.Close(); // Close the Login form (optional)
                }
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .2; 

            if (Opacity >= 1)
            {
                timer1.Stop();
                timer1.Dispose();
            }
        }

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true; // Start dragging
                offsetX = e.X; // Capture the mouse's X position
                offsetY = e.Y; // Capture the mouse's Y position
            }
        }

        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Update the form's position based on the mouse movement
                this.Left = e.X + this.Left - offsetX;
                this.Top = e.Y + this.Top - offsetY;
            }
        }

        private void guna2Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false; // Stop dragging
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            timer1.Dispose();
        }

        private void rememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

    

