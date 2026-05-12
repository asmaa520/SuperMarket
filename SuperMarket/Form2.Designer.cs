namespace SuperMarket
{
    partial class Market
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 68);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Simplified Arabic Fixed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(585, 36);
            label1.TabIndex = 1;
            label1.Text = "Super Market Management System";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 482);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.Maroon;
            button5.Cursor = Cursors.AppStarting;
            button5.Font = new Font("Sitka Banner", 10.8F, FontStyle.Italic);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(26, 379);
            button5.Name = "button5";
            button5.Size = new Size(202, 60);
            button5.TabIndex = 6;
            button5.Text = "Dashboard";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Maroon;
            button4.Cursor = Cursors.AppStarting;
            button4.Font = new Font("Sitka Banner", 10.8F, FontStyle.Italic);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(26, 289);
            button4.Name = "button4";
            button4.Size = new Size(202, 60);
            button4.TabIndex = 5;
            button4.Text = "Inventory";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.Cursor = Cursors.AppStarting;
            button3.Font = new Font("Sitka Banner", 10.8F, FontStyle.Italic);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(26, 202);
            button3.Name = "button3";
            button3.Size = new Size(202, 60);
            button3.TabIndex = 4;
            button3.Text = "Order";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Cursor = Cursors.AppStarting;
            button2.Font = new Font("Sitka Banner", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(26, 119);
            button2.Name = "button2";
            button2.Size = new Size(202, 60);
            button2.TabIndex = 3;
            button2.Text = "Customer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Cursor = Cursors.AppStarting;
            button1.Font = new Font("Sitka Banner", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(26, 33);
            button1.Name = "button1";
            button1.Size = new Size(202, 60);
            button1.TabIndex = 2;
            button1.Text = "Product";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Market
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maeket1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(938, 550);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Market";
            Text = "Market";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
    }
}