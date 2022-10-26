using System.Data;

namespace lab3
{
    public partial class Form1 : Form
    {
        DataRow dr = null;
        public Form1()
        {
            InitializeComponent();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buuton_dodaj_Click(object sender, EventArgs e)
        {
            Form form_dodaj = new Form_dodaj();
            form_dodaj.Show();
        }
        public void addGrid(string title, string author)
        {
            try
            {
                int no = 0;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.Cells[0].Value = no + 1;
                newRow.Cells[1].Value = title;
                newRow.Cells[2].Value = author;
                dataGridView1.Rows.Add(newRow);
            }
            catch { }
        }
    }
}