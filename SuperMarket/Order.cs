using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int orderid = int.Parse(textBox1.Text);

            int customerid = int.Parse(textBox3.Text);
            int productid = int.Parse(textBox2.Text);

            decimal quantity = decimal.Parse(textBox4.Text);
            decimal amount = decimal.Parse(textBox5.Text);

            string query = "INSERT INTO orders (OrderID, CustomerID, ProductID, Quantity,Amount) VALUES (@OrderID, @CustomerID, @ProductID, @Quantity,@Amount)";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderid);
                    cmd.Parameters.AddWithValue("@CustomerID", customerid);
                    cmd.Parameters.AddWithValue("@ProductID", productid);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Inserted Successfully");
            OrderData();
        }

        private void OrderData()
        {
            string query = "SELECT * FROM orders";
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

            int orderid = int.Parse(textBox1.Text);

            int customerid = int.Parse(textBox3.Text);
            int productid = int.Parse(textBox2.Text);

            decimal quantity = decimal.Parse(textBox4.Text);
            decimal amount = decimal.Parse(textBox5.Text);

            string query = "UPDATE orders SET CustomerID=@CustomerID, ProductID=@ProductID, Quantity=@Quantity,Amount=@Amount WHERE OrDERID = @OrderID";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderid);
                    cmd.Parameters.AddWithValue("@CustomerID", customerid);
                    cmd.Parameters.AddWithValue("@ProductID", productid);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Updated Successfully");
            OrderData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int orderid = int.Parse(textBox1.Text);

            string query = "DELETE FROM orders WHERE OrderID = @OrderID";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderid);

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Deleted Successfully");
            OrderData();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            OrderData();
        }
    }

}
