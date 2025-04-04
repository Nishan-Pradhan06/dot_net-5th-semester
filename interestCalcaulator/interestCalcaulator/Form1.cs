namespace interestCalcaulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal principal, time, rate, interest;
            principal = Convert.ToDecimal(txtPrincipal.Text);
            time = Convert.ToDecimal(textBox2.Text);
            rate = Convert.ToDecimal(textBox3.Text);
            interest = principal * time * rate / 100;
            MessageBox.Show("Interest Amount:"+interest.ToString());
        }


        private void button2_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = textBox2.Text = textBox3.Text = String.Empty;
            txtPrincipal.Focus();

        }
    }
}
