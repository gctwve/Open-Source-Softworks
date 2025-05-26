namespace executor
{
    partial class Settings
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
            this.topmost_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TopMost_Switch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Disable_CloseTabMessage_Switch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.closetab_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.api_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.APISwitch3 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.APISwitch2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.APISwitch1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.toggleminimap_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Minimap_Switch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label10 = new System.Windows.Forms.Label();
            this.topmost_Panel.SuspendLayout();
            this.closetab_Panel.SuspendLayout();
            this.api_Panel.SuspendLayout();
            this.toggleminimap_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topmost_Panel
            // 
            this.topmost_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topmost_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.topmost_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.topmost_Panel.BorderRadius = 4;
            this.topmost_Panel.BorderThickness = 1;
            this.topmost_Panel.Controls.Add(this.label1);
            this.topmost_Panel.Controls.Add(this.TopMost_Switch);
            this.topmost_Panel.Location = new System.Drawing.Point(16, 15);
            this.topmost_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.topmost_Panel.Name = "topmost_Panel";
            this.topmost_Panel.Size = new System.Drawing.Size(947, 65);
            this.topmost_Panel.TabIndex = 0;
            this.topmost_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top Most ";
            // 
            // TopMost_Switch
            // 
            this.TopMost_Switch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopMost_Switch.Animated = true;
            this.TopMost_Switch.Checked = true;
            this.TopMost_Switch.CheckedState.BorderColor = System.Drawing.Color.Orange;
            this.TopMost_Switch.CheckedState.FillColor = System.Drawing.Color.Orange;
            this.TopMost_Switch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TopMost_Switch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.TopMost_Switch.Location = new System.Drawing.Point(875, 20);
            this.TopMost_Switch.Margin = new System.Windows.Forms.Padding(4);
            this.TopMost_Switch.Name = "TopMost_Switch";
            this.TopMost_Switch.Size = new System.Drawing.Size(55, 25);
            this.TopMost_Switch.TabIndex = 0;
            this.TopMost_Switch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TopMost_Switch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TopMost_Switch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.TopMost_Switch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.TopMost_Switch.CheckedChanged += new System.EventHandler(this.ToggleTopmost);
            // 
            // Disable_CloseTabMessage_Switch
            // 
            this.Disable_CloseTabMessage_Switch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Disable_CloseTabMessage_Switch.Animated = true;
            this.Disable_CloseTabMessage_Switch.Checked = true;
            this.Disable_CloseTabMessage_Switch.CheckedState.BorderColor = System.Drawing.Color.Orange;
            this.Disable_CloseTabMessage_Switch.CheckedState.FillColor = System.Drawing.Color.Orange;
            this.Disable_CloseTabMessage_Switch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Disable_CloseTabMessage_Switch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Disable_CloseTabMessage_Switch.Location = new System.Drawing.Point(875, 20);
            this.Disable_CloseTabMessage_Switch.Margin = new System.Windows.Forms.Padding(4);
            this.Disable_CloseTabMessage_Switch.Name = "Disable_CloseTabMessage_Switch";
            this.Disable_CloseTabMessage_Switch.Size = new System.Drawing.Size(55, 25);
            this.Disable_CloseTabMessage_Switch.TabIndex = 0;
            this.Disable_CloseTabMessage_Switch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Disable_CloseTabMessage_Switch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Disable_CloseTabMessage_Switch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Disable_CloseTabMessage_Switch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.Disable_CloseTabMessage_Switch.CheckedChanged += new System.EventHandler(this.Toggle_CloseTabText);
            // 
            // closetab_Panel
            // 
            this.closetab_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closetab_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.closetab_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.closetab_Panel.BorderRadius = 4;
            this.closetab_Panel.BorderThickness = 1;
            this.closetab_Panel.Controls.Add(this.label2);
            this.closetab_Panel.Controls.Add(this.Disable_CloseTabMessage_Switch);
            this.closetab_Panel.Location = new System.Drawing.Point(16, 161);
            this.closetab_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.closetab_Panel.Name = "closetab_Panel";
            this.closetab_Panel.Size = new System.Drawing.Size(947, 65);
            this.closetab_Panel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disable Close Tab Text";
            // 
            // api_Panel
            // 
            this.api_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.api_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.api_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.api_Panel.BorderRadius = 4;
            this.api_Panel.BorderThickness = 1;
            this.api_Panel.Controls.Add(this.label6);
            this.api_Panel.Controls.Add(this.label5);
            this.api_Panel.Controls.Add(this.APISwitch3);
            this.api_Panel.Controls.Add(this.APISwitch2);
            this.api_Panel.Controls.Add(this.label4);
            this.api_Panel.Controls.Add(this.APISwitch1);
            this.api_Panel.Controls.Add(this.label3);
            this.api_Panel.Location = new System.Drawing.Point(16, 234);
            this.api_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.api_Panel.Name = "api_Panel";
            this.api_Panel.Size = new System.Drawing.Size(947, 65);
            this.api_Panel.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(722, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "SpashAPI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(419, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "OSSAPI";
            // 
            // APISwitch3
            // 
            this.APISwitch3.Animated = true;
            this.APISwitch3.CheckedState.BorderThickness = 0;
            this.APISwitch3.CheckedState.FillColor = System.Drawing.Color.Orange;
            this.APISwitch3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.APISwitch3.Location = new System.Drawing.Point(849, 23);
            this.APISwitch3.Margin = new System.Windows.Forms.Padding(4);
            this.APISwitch3.Name = "APISwitch3";
            this.APISwitch3.Size = new System.Drawing.Size(27, 25);
            this.APISwitch3.TabIndex = 7;
            this.APISwitch3.Text = "guna2CustomRadioButton3";
            this.APISwitch3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.APISwitch3.UncheckedState.BorderThickness = 2;
            this.APISwitch3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.APISwitch3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // APISwitch2
            // 
            this.APISwitch2.Animated = true;
            this.APISwitch2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.APISwitch2.CheckedState.BorderThickness = 0;
            this.APISwitch2.CheckedState.FillColor = System.Drawing.Color.Orange;
            this.APISwitch2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.APISwitch2.Location = new System.Drawing.Point(524, 22);
            this.APISwitch2.Margin = new System.Windows.Forms.Padding(4);
            this.APISwitch2.Name = "APISwitch2";
            this.APISwitch2.Size = new System.Drawing.Size(27, 25);
            this.APISwitch2.TabIndex = 6;
            this.APISwitch2.Text = "guna2CustomRadioButton2";
            this.APISwitch2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.APISwitch2.UncheckedState.BorderThickness = 2;
            this.APISwitch2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.APISwitch2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.APISwitch2.CheckedChanged += new System.EventHandler(this.APISwitch2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(105, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "QuorumAPI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // APISwitch1
            // 
            this.APISwitch1.Animated = true;
            this.APISwitch1.Checked = true;
            this.APISwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.APISwitch1.CheckedState.BorderThickness = 0;
            this.APISwitch1.CheckedState.FillColor = System.Drawing.Color.Orange;
            this.APISwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.APISwitch1.Location = new System.Drawing.Point(258, 23);
            this.APISwitch1.Margin = new System.Windows.Forms.Padding(4);
            this.APISwitch1.Name = "APISwitch1";
            this.APISwitch1.Size = new System.Drawing.Size(27, 25);
            this.APISwitch1.TabIndex = 2;
            this.APISwitch1.Text = "guna2CustomRadioButton1";
            this.APISwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.APISwitch1.UncheckedState.BorderThickness = 2;
            this.APISwitch1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.APISwitch1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "API:";
            // 
            // toggleminimap_Panel
            // 
            this.toggleminimap_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleminimap_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.toggleminimap_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toggleminimap_Panel.BorderRadius = 4;
            this.toggleminimap_Panel.BorderThickness = 1;
            this.toggleminimap_Panel.Controls.Add(this.Minimap_Switch);
            this.toggleminimap_Panel.Controls.Add(this.label10);
            this.toggleminimap_Panel.Location = new System.Drawing.Point(16, 89);
            this.toggleminimap_Panel.Margin = new System.Windows.Forms.Padding(4);
            this.toggleminimap_Panel.Name = "toggleminimap_Panel";
            this.toggleminimap_Panel.Size = new System.Drawing.Size(947, 65);
            this.toggleminimap_Panel.TabIndex = 10;
            // 
            // Minimap_Switch
            // 
            this.Minimap_Switch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimap_Switch.Animated = true;
            this.Minimap_Switch.Checked = true;
            this.Minimap_Switch.CheckedState.BorderColor = System.Drawing.Color.Orange;
            this.Minimap_Switch.CheckedState.FillColor = System.Drawing.Color.Orange;
            this.Minimap_Switch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Minimap_Switch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Minimap_Switch.Location = new System.Drawing.Point(875, 22);
            this.Minimap_Switch.Margin = new System.Windows.Forms.Padding(4);
            this.Minimap_Switch.Name = "Minimap_Switch";
            this.Minimap_Switch.Size = new System.Drawing.Size(55, 25);
            this.Minimap_Switch.TabIndex = 2;
            this.Minimap_Switch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Minimap_Switch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Minimap_Switch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Minimap_Switch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.Minimap_Switch.CheckedChanged += new System.EventHandler(this.Minimap_Switch_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(4, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 32);
            this.label10.TabIndex = 1;
            this.label10.Text = "Toggle Minimap Scrollbar";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(964, 500);
            this.Controls.Add(this.toggleminimap_Panel);
            this.Controls.Add(this.api_Panel);
            this.Controls.Add(this.closetab_Panel);
            this.Controls.Add(this.topmost_Panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.topmost_Panel.ResumeLayout(false);
            this.topmost_Panel.PerformLayout();
            this.closetab_Panel.ResumeLayout(false);
            this.closetab_Panel.PerformLayout();
            this.api_Panel.ResumeLayout(false);
            this.api_Panel.PerformLayout();
            this.toggleminimap_Panel.ResumeLayout(false);
            this.toggleminimap_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel topmost_Panel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch TopMost_Switch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch Disable_CloseTabMessage_Switch;
        private Guna.UI2.WinForms.Guna2Panel closetab_Panel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel api_Panel;
        private Guna.UI2.WinForms.Guna2CustomRadioButton APISwitch1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CustomRadioButton APISwitch3;
        private Guna.UI2.WinForms.Guna2CustomRadioButton APISwitch2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel toggleminimap_Panel;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ToggleSwitch Minimap_Switch;
    }
}