namespace Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hello World!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            MessageBox.Show(inputText);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
