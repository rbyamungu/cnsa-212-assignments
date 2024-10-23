namespace HelloWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string readName = textBox1.Text;
            if (string.IsNullOrEmpty(readName))
            {
                textBox2.Text = "Hello Bro";
            }
            else
            {
                textBox2.Text =  $"Hello, " + readName;
            }
        }
    }
}
