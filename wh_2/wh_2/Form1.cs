namespace wh_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button_monitor_Click(object sender, EventArgs e)
        {
            var monitorForm = new FormMonitor();
            monitorForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_computer_Click(object sender, EventArgs e)
        {
            FormKomputer komputerForm = new FormKomputer();
            komputerForm.Show();
        }
    }

   
}