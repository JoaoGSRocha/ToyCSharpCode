namespace _11_IOT_JoaoRocha_TemperatureMetrics
{
    partial class Form1
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
            this.lblFarenheit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblConvertedVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFarenheit
            // 
            this.lblFarenheit.AutoSize = true;
            this.lblFarenheit.Location = new System.Drawing.Point(18, 48);
            this.lblFarenheit.Name = "lblFarenheit";
            this.lblFarenheit.Size = new System.Drawing.Size(51, 13);
            this.lblFarenheit.TabIndex = 0;
            this.lblFarenheit.Text = "Farenheit";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(177, 48);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(41, 13);
            this.lblCelsius.TabIndex = 2;
            this.lblCelsius.Text = "Celcius";
            // 
            // lblConvertedVal
            // 
            this.lblConvertedVal.AutoSize = true;
            this.lblConvertedVal.Location = new System.Drawing.Point(129, 48);
            this.lblConvertedVal.Name = "lblConvertedVal";
            this.lblConvertedVal.Size = new System.Drawing.Size(16, 13);
            this.lblConvertedVal.TabIndex = 3;
            this.lblConvertedVal.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 97);
            this.Controls.Add(this.lblConvertedVal);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFarenheit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFarenheit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblConvertedVal;
    }
}

