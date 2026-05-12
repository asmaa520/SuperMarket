namespace SuperMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter all fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String correctUserName = "admin";
            String correctPassword = "password123";

            if (textBox1.Text == correctUserName && textBox2.Text == correctPassword)
            {
                Market mt = new Market();
                mt.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
