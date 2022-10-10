namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}