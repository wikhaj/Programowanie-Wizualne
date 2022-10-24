namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buuton_dodaj_Click(object sender, EventArgs e)
        {
            Form form_dodaj = new Form_dodaj();
            form_dodaj.Show();
        }
    }
}