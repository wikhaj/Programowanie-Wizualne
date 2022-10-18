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
            this.components = new System.ComponentModel.Container();
            this.button_computer = new System.Windows.Forms.Button();
            this.button_monitor = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_computer
            // 
            this.button_computer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_computer.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_computer.Location = new System.Drawing.Point(103, 163);
            this.button_computer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_computer.Name = "button_computer";
            this.button_computer.Size = new System.Drawing.Size(307, 172);
            this.button_computer.TabIndex = 0;
            this.button_computer.Text = "komputer";
            this.button_computer.UseVisualStyleBackColor = false;
            this.button_computer.Click += new System.EventHandler(this.button_computer_Click);
            // 
            // button_monitor
            // 
            this.button_monitor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_monitor.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_monitor.Location = new System.Drawing.Point(649, 163);
            this.button_monitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_monitor.Name = "button_monitor";
            this.button_monitor.Size = new System.Drawing.Size(313, 172);
            this.button_monitor.TabIndex = 1;
            this.button_monitor.Text = "monitor";
            this.button_monitor.UseVisualStyleBackColor = false;
            this.button_monitor.Click += new System.EventHandler(this.button_monitor_Click);
            // 
            // suma
            // 
            this.suma.AutoSize = true;
            this.suma.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.suma.Location = new System.Drawing.Point(621, 540);
            this.suma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(230, 96);
            this.suma.TabIndex = 2;
            this.suma.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(361, 540);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 96);
            this.label1.TabIndex = 3;
            this.label1.Text = "łącznie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(817, 540);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 96);
            this.label2.TabIndex = 4;
            this.label2.Text = "zł";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.button_monitor);
            this.Controls.Add(this.button_computer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_computer;
        private Button button_monitor;
        private Label suma;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
    }
}