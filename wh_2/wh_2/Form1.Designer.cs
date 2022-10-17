namespace wh_2
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
            this.button_computer = new System.Windows.Forms.Button();
            this.button_monitor = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_computer
            // 
            this.button_computer.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_computer.Location = new System.Drawing.Point(72, 98);
            this.button_computer.Name = "button_computer";
            this.button_computer.Size = new System.Drawing.Size(215, 103);
            this.button_computer.TabIndex = 0;
            this.button_computer.Text = "komputer";
            this.button_computer.UseVisualStyleBackColor = true;
            this.button_computer.Click += new System.EventHandler(this.button_computer_Click);
            // 
            // button_monitor
            // 
            this.button_monitor.BackColor = System.Drawing.SystemColors.Control;
            this.button_monitor.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_monitor.Location = new System.Drawing.Point(454, 98);
            this.button_monitor.Name = "button_monitor";
            this.button_monitor.Size = new System.Drawing.Size(219, 103);
            this.button_monitor.TabIndex = 1;
            this.button_monitor.Text = "monitor";
            this.button_monitor.UseVisualStyleBackColor = false;
            this.button_monitor.Click += new System.EventHandler(this.button_monitor_Click);
            // 
            // suma
            // 
            this.suma.AutoSize = true;
            this.suma.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.suma.Location = new System.Drawing.Point(435, 324);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(155, 65);
            this.suma.TabIndex = 2;
            this.suma.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.button_monitor);
            this.Controls.Add(this.button_computer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_computer;
        private Button button_monitor;
        private Label suma;
    }
}