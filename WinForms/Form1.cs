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
        }
    }    
}