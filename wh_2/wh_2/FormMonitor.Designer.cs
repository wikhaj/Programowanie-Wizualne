namespace wh_2
{
    partial class FormMonitor
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label_cenaM = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_rozdzielczosc = new System.Windows.Forms.Label();
            this.label_marka = new System.Windows.Forms.Label();
            this.label_zl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ASUS",
            "Dell",
            "Samsung"});
            this.comboBox1.Location = new System.Drawing.Point(186, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(383, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1280 x 1024 px ",
            "1600 x 1200 px",
            "1680 x 1050 px ",
            "1900 x 1200 px ",
            "3840 x 2160 px"});
            this.comboBox2.Location = new System.Drawing.Point(186, 246);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(383, 33);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label_cenaM
            // 
            this.label_cenaM.AutoSize = true;
            this.label_cenaM.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_cenaM.Location = new System.Drawing.Point(549, 316);
            this.label_cenaM.Name = "label_cenaM";
            this.label_cenaM.Size = new System.Drawing.Size(0, 70);
            this.label_cenaM.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_rozdzielczosc
            // 
            this.label_rozdzielczosc.AutoSize = true;
            this.label_rozdzielczosc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_rozdzielczosc.Location = new System.Drawing.Point(186, 195);
            this.label_rozdzielczosc.Name = "label_rozdzielczosc";
            this.label_rozdzielczosc.Size = new System.Drawing.Size(160, 32);
            this.label_rozdzielczosc.TabIndex = 3;
            this.label_rozdzielczosc.Text = "Rozdzielczość";
            // 
            // label_marka
            // 
            this.label_marka.AutoSize = true;
            this.label_marka.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_marka.Location = new System.Drawing.Point(186, 45);
            this.label_marka.Name = "label_marka";
            this.label_marka.Size = new System.Drawing.Size(84, 32);
            this.label_marka.TabIndex = 4;
            this.label_marka.Text = "Marka";
            // 
            // label_zl
            // 
            this.label_zl.AutoSize = true;
            this.label_zl.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_zl.Location = new System.Drawing.Point(671, 332);
            this.label_zl.Name = "label_zl";
            this.label_zl.Size = new System.Drawing.Size(54, 54);
            this.label_zl.TabIndex = 5;
            this.label_zl.Text = "zł";
            // 
            // FormMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_zl);
            this.Controls.Add(this.label_marka);
            this.Controls.Add(this.label_rozdzielczosc);
            this.Controls.Add(this.label_cenaM);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormMonitor";
            this.Text = "FormMonitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label_cenaM;
        private System.Windows.Forms.Timer timer1;
        private Label label_rozdzielczosc;
        private Label label_marka;
        private Label label_zl;
    }
}