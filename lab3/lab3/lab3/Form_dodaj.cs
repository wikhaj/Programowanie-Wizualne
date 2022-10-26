using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab3.Books;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab3
{
    public partial class Form_dodaj : Form
    {
        public string author_tmp { get; set; }
        public string title_tmp { get; set; }
        public Form_dodaj()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var book = new List<Book>()
            {
                new Book
                {
                    Title = textBox_title.Text,
                    Author = textBox_author.Text
                }
            };
            textBox_title.Clear();
            textBox_author.Clear();
            Books.ExportData.ExportCsv(book, "book");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            author_tmp = textBox_author.Text;
            textBox_author.Clear();
            title_tmp = textBox_title.Text;
            textBox_title.Clear();
            Form1.addGrid(title_tmp, author_tmp);

            this.Close();
        }

    }
}
