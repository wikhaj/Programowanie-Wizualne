namespace wh_2
{
    partial class FormKomputer
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
            this.label_dysk = new System.Windows.Forms.Label();
            this.label_system = new System.Windows.Forms.Label();
            this.label_dodatki = new System.Windows.Forms.Label();
            this.radioButton_50GB = new System.Windows.Forms.RadioButton();
            this.radioButton_500GB = new System.Windows.Forms.RadioButton();
            this.radioButton_2TB = new System.Windows.Forms.RadioButton();
            this.comboBox_SystemO = new System.Windows.Forms.ComboBox();
            this.checkBox_myszka = new System.Windows.Forms.CheckBox();
            this.checkBox_klawiatura = new System.Windows.Forms.CheckBox();
            this.checkBox_chłodzenie = new System.Windows.Forms.CheckBox();
            this.checkBox_kamerka = new System.Windows.Forms.CheckBox();
            this.label_suma = new System.Windows.Forms.Label();
            this.label_waluta = new System.Windows.Forms.Label();
            this.label_cena = new System.Windows.Forms.Label();
            this.timer_cena = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_dysk
            // 
            this.label_dysk.AutoSize = true;
            this.label_dysk.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_dysk.Location = new System.Drawing.Point(57, 53);
            this.label_dysk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dysk.Name = "label_dysk";
            this.label_dysk.Size = new System.Drawing.Size(346, 55);
            this.label_dysk.TabIndex = 0;
            this.label_dysk.Text = "Pojemność dysku";
            // 
            // label_system
            // 
            this.label_system.AutoSize = true;
            this.label_system.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_system.Location = new System.Drawing.Point(57, 377);
            this.label_system.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_system.Name = "label_system";
            this.label_system.Size = new System.Drawing.Size(371, 55);
            this.label_system.TabIndex = 1;
            this.label_system.Text = "System operacyjny";
            // 
            // label_dodatki
            // 
            this.label_dodatki.AutoSize = true;
            this.label_dodatki.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_dodatki.Location = new System.Drawing.Point(691, 53);
            this.label_dodatki.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dodatki.Name = "label_dodatki";
            this.label_dodatki.Size = new System.Drawing.Size(171, 55);
            this.label_dodatki.TabIndex = 2;
            this.label_dodatki.Text = "Dodatki";
            // 
            // radioButton_50GB
            // 
            this.radioButton_50GB.AutoSize = true;
            this.radioButton_50GB.Location = new System.Drawing.Point(103, 142);
            this.radioButton_50GB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_50GB.Name = "radioButton_50GB";
            this.radioButton_50GB.Size = new System.Drawing.Size(84, 29);
            this.radioButton_50GB.TabIndex = 3;
            this.radioButton_50GB.TabStop = true;
            this.radioButton_50GB.Text = "50 GB";
            this.radioButton_50GB.UseVisualStyleBackColor = true;
            this.radioButton_50GB.CheckedChanged += new System.EventHandler(this.radioButton_50GB_CheckedChanged);
            // 
            // radioButton_500GB
            // 
            this.radioButton_500GB.AutoSize = true;
            this.radioButton_500GB.Location = new System.Drawing.Point(101, 178);
            this.radioButton_500GB.Name = "radioButton_500GB";
            this.radioButton_500GB.Size = new System.Drawing.Size(94, 29);
            this.radioButton_500GB.TabIndex = 4;
            this.radioButton_500GB.TabStop = true;
            this.radioButton_500GB.Text = "500 GB";
            this.radioButton_500GB.UseVisualStyleBackColor = true;
            this.radioButton_500GB.CheckedChanged += new System.EventHandler(this.radioButton_500GB_CheckedChanged);
            // 
            // radioButton_2TB
            // 
            this.radioButton_2TB.AutoSize = true;
            this.radioButton_2TB.ForeColor = System.Drawing.Color.Black;
            this.radioButton_2TB.Location = new System.Drawing.Point(101, 213);
            this.radioButton_2TB.Name = "radioButton_2TB";
            this.radioButton_2TB.Size = new System.Drawing.Size(71, 29);
            this.radioButton_2TB.TabIndex = 5;
            this.radioButton_2TB.TabStop = true;
            this.radioButton_2TB.Text = "2 TB";
            this.radioButton_2TB.UseVisualStyleBackColor = true;
            this.radioButton_2TB.CheckedChanged += new System.EventHandler(this.radioButton_2TB_CheckedChanged);
            // 
            // comboBox_SystemO
            // 
            this.comboBox_SystemO.FormattingEnabled = true;
            this.comboBox_SystemO.Items.AddRange(new object[] {
            "Microsoft Windows 11",
            "Microsoft Windows 10 Home ",
            "Microsoft Windows 7"});
            this.comboBox_SystemO.Location = new System.Drawing.Point(89, 498);
            this.comboBox_SystemO.Name = "comboBox_SystemO";
            this.comboBox_SystemO.Size = new System.Drawing.Size(282, 33);
            this.comboBox_SystemO.TabIndex = 6;
            this.comboBox_SystemO.SelectedIndexChanged += new System.EventHandler(this.comboBox_SystemO_SelectedIndexChanged);
            // 
            // checkBox_myszka
            // 
            this.checkBox_myszka.AutoSize = true;
            this.checkBox_myszka.Location = new System.Drawing.Point(697, 139);
            this.checkBox_myszka.Name = "checkBox_myszka";
            this.checkBox_myszka.Size = new System.Drawing.Size(97, 29);
            this.checkBox_myszka.TabIndex = 7;
            this.checkBox_myszka.Text = "myszka";
            this.checkBox_myszka.UseVisualStyleBackColor = true;
            this.checkBox_myszka.CheckedChanged += new System.EventHandler(this.checkBox_myszka_CheckedChanged);
            // 
            // checkBox_klawiatura
            // 
            this.checkBox_klawiatura.AutoSize = true;
            this.checkBox_klawiatura.Location = new System.Drawing.Point(697, 174);
            this.checkBox_klawiatura.Name = "checkBox_klawiatura";
            this.checkBox_klawiatura.Size = new System.Drawing.Size(117, 29);
            this.checkBox_klawiatura.TabIndex = 8;
            this.checkBox_klawiatura.Text = "klawiatura";
            this.checkBox_klawiatura.UseVisualStyleBackColor = true;
            this.checkBox_klawiatura.CheckedChanged += new System.EventHandler(this.checkBox_klawiatura_CheckedChanged);
            // 
            // checkBox_chłodzenie
            // 
            this.checkBox_chłodzenie.AutoSize = true;
            this.checkBox_chłodzenie.Location = new System.Drawing.Point(697, 214);
            this.checkBox_chłodzenie.Name = "checkBox_chłodzenie";
            this.checkBox_chłodzenie.Size = new System.Drawing.Size(123, 29);
            this.checkBox_chłodzenie.TabIndex = 9;
            this.checkBox_chłodzenie.Text = "chłodzenie";
            this.checkBox_chłodzenie.UseVisualStyleBackColor = true;
            this.checkBox_chłodzenie.CheckedChanged += new System.EventHandler(this.checkBox_chłodzenie_CheckedChanged);
            // 
            // checkBox_kamerka
            // 
            this.checkBox_kamerka.AutoSize = true;
            this.checkBox_kamerka.Location = new System.Drawing.Point(697, 259);
            this.checkBox_kamerka.Name = "checkBox_kamerka";
            this.checkBox_kamerka.Size = new System.Drawing.Size(105, 29);
            this.checkBox_kamerka.TabIndex = 10;
            this.checkBox_kamerka.Text = "kamerka";
            this.checkBox_kamerka.UseVisualStyleBackColor = true;
            this.checkBox_kamerka.CheckedChanged += new System.EventHandler(this.checkBox_kamerka_CheckedChanged);
            // 
            // label_suma
            // 
            this.label_suma.AutoSize = true;
            this.label_suma.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_suma.Location = new System.Drawing.Point(691, 363);
            this.label_suma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_suma.Name = "label_suma";
            this.label_suma.Size = new System.Drawing.Size(127, 55);
            this.label_suma.TabIndex = 11;
            this.label_suma.Text = "Suma";
            // 
            // label_waluta
            // 
            this.label_waluta.AutoSize = true;
            this.label_waluta.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_waluta.Location = new System.Drawing.Point(923, 536);
            this.label_waluta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_waluta.Name = "label_waluta";
            this.label_waluta.Size = new System.Drawing.Size(55, 55);
            this.label_waluta.TabIndex = 12;
            this.label_waluta.Text = "zł";
            // 
            // label_cena
            // 
            this.label_cena.AutoSize = true;
            this.label_cena.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_cena.Location = new System.Drawing.Point(708, 521);
            this.label_cena.Name = "label_cena";
            this.label_cena.Size = new System.Drawing.Size(0, 70);
            this.label_cena.TabIndex = 13;
            // 
            // timer_cena
            // 
            this.timer_cena.Enabled = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormKomputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.label_cena);
            this.Controls.Add(this.label_waluta);
            this.Controls.Add(this.label_suma);
            this.Controls.Add(this.checkBox_kamerka);
            this.Controls.Add(this.checkBox_chłodzenie);
            this.Controls.Add(this.checkBox_klawiatura);
            this.Controls.Add(this.checkBox_myszka);
            this.Controls.Add(this.comboBox_SystemO);
            this.Controls.Add(this.radioButton_2TB);
            this.Controls.Add(this.radioButton_500GB);
            this.Controls.Add(this.radioButton_50GB);
            this.Controls.Add(this.label_dodatki);
            this.Controls.Add(this.label_system);
            this.Controls.Add(this.label_dysk);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormKomputer";
            this.Text = "FormKomputer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_dysk;
        private Label label_system;
        private Label label_dodatki;
        private RadioButton radioButton_50GB;
        private RadioButton radioButton_500GB;
        private RadioButton radioButton_2TB;
        private ComboBox comboBox_SystemO;
        private CheckBox checkBox_myszka;
        private CheckBox checkBox_klawiatura;
        private CheckBox checkBox_chłodzenie;
        private CheckBox checkBox_kamerka;
        private Label label_suma;
        private Label label_waluta;
        private Label label_cena;
        private System.Windows.Forms.Timer timer_cena;
        private System.Windows.Forms.Timer timer1;


    }
}