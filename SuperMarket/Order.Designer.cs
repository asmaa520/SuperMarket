namespace SuperMarket
{
    partial class Order
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            textBox5 = new TextBox();
            label6 = new Label();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnInsert = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 60);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(295, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 41);
            label1.TabIndex = 1;
            label1.Text = "Order";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 339);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(727, 157);
            dataGridView1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnInsert);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(18, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(727, 260);
            panel2.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(181, 177);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(490, 27);
            textBox5.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(54, 178);
            label6.Name = "label6";
            label6.Size = new Size(75, 23);
            label6.TabIndex = 12;
            label6.Text = "Amount";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.Maroon;
            btnNew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = Color.Transparent;
            btnNew.Location = new Point(532, 213);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(116, 40);
            btnNew.TabIndex = 11;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Maroon;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Transparent;
            btnUpdate.Location = new Point(208, 213);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 40);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Maroon;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(368, 213);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 40);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Maroon;
            btnInsert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = Color.Transparent;
            btnInsert.Location = new Point(54, 213);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(116, 40);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(181, 142);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(490, 27);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(181, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(490, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(490, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(490, 27);
            textBox1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(53, 142);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 3;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(53, 102);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 2;
            label4.Text = "ProductID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(53, 66);
            label3.Name = "label3";
            label3.Size = new Size(105, 23);
            label3.TabIndex = 1;
            label3.Text = "CustomerID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(53, 27);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 0;
            label2.Text = "OrderID";
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(762, 508);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            Load += Order_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnInsert;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox5;
        private Label label6;
    }
}