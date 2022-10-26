namespace lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tytuł = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buuton_dodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytuł,
            this.autor,
            this.id});
            this.dataGridView1.Location = new System.Drawing.Point(108, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(521, 393);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tytuł
            // 
            this.tytuł.HeaderText = "tytuł";
            this.tytuł.MinimumWidth = 8;
            this.tytuł.Name = "tytuł";
            this.tytuł.Width = 150;
            // 
            // autor
            // 
            this.autor.HeaderText = "autor";
            this.autor.MinimumWidth = 8;
            this.autor.Name = "autor";
            this.autor.Width = 150;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // buuton_dodaj
            // 
            this.buuton_dodaj.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buuton_dodaj.Location = new System.Drawing.Point(676, 37);
            this.buuton_dodaj.Name = "buuton_dodaj";
            this.buuton_dodaj.Size = new System.Drawing.Size(112, 34);
            this.buuton_dodaj.TabIndex = 1;
            this.buuton_dodaj.Text = "+";
            this.buuton_dodaj.UseVisualStyleBackColor = true;
            this.buuton_dodaj.Click += new System.EventHandler(this.buuton_dodaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buuton_dodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn tytuł;
        private DataGridViewTextBoxColumn autor;
        private DataGridViewTextBoxColumn id;
        private Button buuton_dodaj;
    }
}