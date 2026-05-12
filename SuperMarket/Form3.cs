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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int customerid = int.Parse(textBox1.Text);

            string customername = textBox3.Text;
            string phone = textBox2.Text;

            string address = textBox4.Text;

            string query = "INSERT INTO customers (CustomerID, CustomerName, Phone, Address) VALUES (@CustomerID, @CustomerName, @Phone, @Address)";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerid);
                    cmd.Parameters.AddWithValue("@CustomerName", customername);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Inserted Successfully");
            CustomerData();
        }
        private void CustomerData()
        {

            string query = "SELECT * FROM customers";
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
            int customerid = int.Parse(textBox1.Text);

            string customername = textBox3.Text;
            string phone = textBox2.Text;

            string address = textBox4.Text;

            string query = "UPDATE customers SET CustomerName= @CustomerName, Phone=@Phone, Address=@Address WHERE CustomerID=@CustomerID";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerid);
                    cmd.Parameters.AddWithValue("@CustomerName", customername);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Updated Successfully");
            CustomerData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int customerid = int.Parse(textBox1.Text);


            string query = "DELETE FROM customers WHERE CustomerID=@CustomerID";

            using (MySqlConnection conn = new DatabaseConnection().GetConnection())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerid);

                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Record Deleted Successfully");
            CustomerData();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            CustomerData();
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
