namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) % Convert.ToDouble(textBox2.Text));
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text + textBox2.Text;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));
        }
    }
}