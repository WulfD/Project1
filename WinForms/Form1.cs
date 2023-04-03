namespace WinForms
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string data = await Program.getfile();
            Console.Write(data);
            richTextBox1.Text = data;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}