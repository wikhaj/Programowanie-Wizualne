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
            this.label_dysk = new System.Windows.Forms.Label();
            this.label_system = new System.Windows.Forms.Label();
            this.label_dodatki = new System.Windows.Forms.Label();
            this.radioButton_50GB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label_dysk
            // 
            this.label_dysk.AutoSize = true;
            this.label_dysk.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_dysk.Location = new System.Drawing.Point(40, 32);
            this.label_dysk.Name = "label_dysk";
            this.label_dysk.Size = new System.Drawing.Size(229, 37);
            this.label_dysk.TabIndex = 0;
            this.label_dysk.Text = "Pojemność dysku";
            // 
            // label_system
            // 
            this.label_system.AutoSize = true;
            this.label_system.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_system.Location = new System.Drawing.Point(40, 226);
            this.label_system.Name = "label_system";
            this.label_system.Size = new System.Drawing.Size(246, 37);
            this.label_system.TabIndex = 1;
            this.label_system.Text = "System operacyjny";
            // 
            // label_dodatki
            // 
            this.label_dodatki.AutoSize = true;
            this.label_dodatki.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_dodatki.Location = new System.Drawing.Point(484, 32);
            this.label_dodatki.Name = "label_dodatki";
            this.label_dodatki.Size = new System.Drawing.Size(113, 37);
            this.label_dodatki.TabIndex = 2;
            this.label_dodatki.Text = "Dodatki";
            // 
            // radioButton_50GB
            // 
            this.radioButton_50GB.AutoSize = true;
            this.radioButton_50GB.Location = new System.Drawing.Point(72, 85);
            this.radioButton_50GB.Name = "radioButton_50GB";
            this.radioButton_50GB.Size = new System.Drawing.Size(55, 19);
            this.radioButton_50GB.TabIndex = 3;
            this.radioButton_50GB.TabStop = true;
            this.radioButton_50GB.Text = "50 GB";
            this.radioButton_50GB.UseVisualStyleBackColor = true;
            // 
            // FormKomputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton_50GB);
            this.Controls.Add(this.label_dodatki);
            this.Controls.Add(this.label_system);
            this.Controls.Add(this.label_dysk);
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
    }
}