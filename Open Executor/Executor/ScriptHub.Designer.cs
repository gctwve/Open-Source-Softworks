namespace executor
{
    partial class ScriptHub
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
            this.scriptPanel1 = new SyphraAPI.ScriptPanel();
            this.SuspendLayout();
            // 
            // scriptPanel1
            // 
            this.scriptPanel1.AutoScroll = true;
            this.scriptPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.scriptPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.scriptPanel1.Location = new System.Drawing.Point(0, 0);
            this.scriptPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.scriptPanel1.Name = "scriptPanel1";
            this.scriptPanel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.scriptPanel1.Size = new System.Drawing.Size(964, 500);
            this.scriptPanel1.TabIndex = 5;
            this.scriptPanel1.WrapContents = false;
            this.scriptPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.scriptPanel1_Paint);
            // 
            // ScriptHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(964, 500);
            this.Controls.Add(this.scriptPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ScriptHub";
            this.Text = "ScriptHub";
            this.ResumeLayout(false);

        }

        #endregion

        private SyphraAPI.ScriptPanel scriptPanel1;
    }
}