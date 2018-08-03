namespace _10_IOT_JoaoRocha_CircleCalc
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRaio = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDiametroVal = new System.Windows.Forms.Label();
            this.lblAreaVal = new System.Windows.Forms.Label();
            this.lblPerimetroVal = new System.Windows.Forms.Label();
            this.lblVolumeVal = new System.Windows.Forms.Label();
            this.checkBoxDiametro = new System.Windows.Forms.CheckBox();
            this.checkBoxArea = new System.Windows.Forms.CheckBox();
            this.checkBoxPerimetro = new System.Windows.Forms.CheckBox();
            this.checkBoxVolume = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(31, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Introduza o valor do raio cricunferência";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(31, 54);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(29, 13);
            this.lblRaio.TabIndex = 1;
            this.lblRaio.Text = "Raio";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDiametroVal
            // 
            this.lblDiametroVal.AutoSize = true;
            this.lblDiametroVal.Location = new System.Drawing.Point(129, 105);
            this.lblDiametroVal.Name = "lblDiametroVal";
            this.lblDiametroVal.Size = new System.Drawing.Size(16, 13);
            this.lblDiametroVal.TabIndex = 8;
            this.lblDiametroVal.Text = "...";
            // 
            // lblAreaVal
            // 
            this.lblAreaVal.AutoSize = true;
            this.lblAreaVal.Location = new System.Drawing.Point(129, 133);
            this.lblAreaVal.Name = "lblAreaVal";
            this.lblAreaVal.Size = new System.Drawing.Size(16, 13);
            this.lblAreaVal.TabIndex = 9;
            this.lblAreaVal.Text = "...";
            // 
            // lblPerimetroVal
            // 
            this.lblPerimetroVal.AutoSize = true;
            this.lblPerimetroVal.Location = new System.Drawing.Point(129, 161);
            this.lblPerimetroVal.Name = "lblPerimetroVal";
            this.lblPerimetroVal.Size = new System.Drawing.Size(16, 13);
            this.lblPerimetroVal.TabIndex = 10;
            this.lblPerimetroVal.Text = "...";
            // 
            // lblVolumeVal
            // 
            this.lblVolumeVal.AutoSize = true;
            this.lblVolumeVal.Location = new System.Drawing.Point(129, 188);
            this.lblVolumeVal.Name = "lblVolumeVal";
            this.lblVolumeVal.Size = new System.Drawing.Size(16, 13);
            this.lblVolumeVal.TabIndex = 11;
            this.lblVolumeVal.Text = "...";
            // 
            // checkBoxDiametro
            // 
            this.checkBoxDiametro.AutoSize = true;
            this.checkBoxDiametro.Location = new System.Drawing.Point(34, 105);
            this.checkBoxDiametro.Name = "checkBoxDiametro";
            this.checkBoxDiametro.Size = new System.Drawing.Size(68, 17);
            this.checkBoxDiametro.TabIndex = 12;
            this.checkBoxDiametro.Text = "Diâmetro";
            this.checkBoxDiametro.UseVisualStyleBackColor = true;
            this.checkBoxDiametro.CheckedChanged += new System.EventHandler(this.checkBoxDiametro_CheckedChanged);
            // 
            // checkBoxArea
            // 
            this.checkBoxArea.AutoSize = true;
            this.checkBoxArea.Location = new System.Drawing.Point(34, 129);
            this.checkBoxArea.Name = "checkBoxArea";
            this.checkBoxArea.Size = new System.Drawing.Size(48, 17);
            this.checkBoxArea.TabIndex = 13;
            this.checkBoxArea.Text = "Área";
            this.checkBoxArea.UseVisualStyleBackColor = true;
            this.checkBoxArea.CheckedChanged += new System.EventHandler(this.checkBoxArea_CheckedChanged);
            // 
            // checkBoxPerimetro
            // 
            this.checkBoxPerimetro.AutoSize = true;
            this.checkBoxPerimetro.Location = new System.Drawing.Point(34, 157);
            this.checkBoxPerimetro.Name = "checkBoxPerimetro";
            this.checkBoxPerimetro.Size = new System.Drawing.Size(72, 17);
            this.checkBoxPerimetro.TabIndex = 14;
            this.checkBoxPerimetro.Text = "Perímetro";
            this.checkBoxPerimetro.UseVisualStyleBackColor = true;
            this.checkBoxPerimetro.CheckedChanged += new System.EventHandler(this.checkBoxPerimetro_CheckedChanged);
            // 
            // checkBoxVolume
            // 
            this.checkBoxVolume.AutoSize = true;
            this.checkBoxVolume.Location = new System.Drawing.Point(34, 187);
            this.checkBoxVolume.Name = "checkBoxVolume";
            this.checkBoxVolume.Size = new System.Drawing.Size(61, 17);
            this.checkBoxVolume.TabIndex = 15;
            this.checkBoxVolume.Text = "Volume";
            this.checkBoxVolume.UseVisualStyleBackColor = true;
            this.checkBoxVolume.CheckedChanged += new System.EventHandler(this.checkBoxVolume_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 222);
            this.Controls.Add(this.checkBoxVolume);
            this.Controls.Add(this.checkBoxPerimetro);
            this.Controls.Add(this.checkBoxArea);
            this.Controls.Add(this.checkBoxDiametro);
            this.Controls.Add(this.lblVolumeVal);
            this.Controls.Add(this.lblPerimetroVal);
            this.Controls.Add(this.lblAreaVal);
            this.Controls.Add(this.lblDiametroVal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblRaio);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDiametroVal;
        private System.Windows.Forms.Label lblAreaVal;
        private System.Windows.Forms.Label lblPerimetroVal;
        private System.Windows.Forms.Label lblVolumeVal;
        private System.Windows.Forms.CheckBox checkBoxDiametro;
        private System.Windows.Forms.CheckBox checkBoxArea;
        private System.Windows.Forms.CheckBox checkBoxPerimetro;
        private System.Windows.Forms.CheckBox checkBoxVolume;
    }
}

