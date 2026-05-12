using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int productid = int.Parse(textBox1.Text);

            string productname = textBox3.Text; 
            string category = textBox2.Text;   

            decimal price = decimal.Parse(textBox4.Text);

            string query = "INSERT INTO products (ProductID, ProductName, Category, Price) VALUES (@ProductID, @ProductName, @Category, @Price)";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productid);
                    cmd.Parameters.AddWithValue("@ProductName", productname);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Inserted Successfully");
            ProductData();
        }
        private void ProductData()
        {
            string query = "SELECT ProductID, ProductName, Category, Price FROM products";
            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable datatable = new DataTable();
                        adapter.Fill(datatable);
                        dataGridView1.DataSource = datatable;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int productid = int.Parse(textBox1.Text);

            string productname = textBox3.Text;
            string category = textBox2.Text;

            decimal price = decimal.Parse(textBox4.Text);

            string query = "UPDATE products SET ProductName=@ProductName, Category=@Category, Price=@Price WHERE ProductID=@ProductID";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productid);
                    cmd.Parameters.AddWithValue("@ProductName", productname);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Updated Successfully");
            ProductData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int productid = int.Parse(textBox1.Text);


            string query = "DELETE FROM products WHERE ProductID = @ProductID";



            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productid);
                    cmd.ExecuteNonQuery();
                }

            }
            MessageBox.Show("Record Deleted Successfully");
            ProductData();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            ProductData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }
    }
}
