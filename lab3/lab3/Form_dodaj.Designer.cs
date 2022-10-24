namespace lab3
{
    partial class Form_dodaj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label_tytul = new System.Windows.Forms.Label();
            this.label_autor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(534, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 103);
            this.button1.TabIndex = 0;
            this.button1.Text = "dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_tytul
            // 
            this.label_tytul.AutoSize = true;
            this.label_tytul.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_tytul.Location = new System.Drawing.Point(59, 50);
            this.label_tytul.Name = "label_tytul";
            this.label_tytul.Size = new System.Drawing.Size(90, 45);
            this.label_tytul.TabIndex = 1;
            this.label_tytul.Text = "tytuł";
            // 
            // label_autor
            // 
            this.label_autor.AutoSize = true;
            this.label_autor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_autor.Location = new System.Drawing.Point(346, 50);
            this.label_autor.Name = "label_autor";
            this.label_autor.Size = new System.Drawing.Size(101, 45);
            this.label_autor.TabIndex = 3;
            this.label_autor.Text = "autor";
            // 
            // Form_dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_autor);
            this.Controls.Add(this.label_tytul);
            this.Controls.Add(this.button1);
            this.Name = "Form_dodaj";
            this.Text = "Form_dodaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label_tytul;
        private Label label_autor;
    }
}