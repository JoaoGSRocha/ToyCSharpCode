namespace _07_IOT_JoaoRocha_RandNumbGen
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
            this.btnGen = new System.Windows.Forms.Button();
            this.lblGenVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(12, 12);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(84, 55);
            this.btnGen.TabIndex = 0;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGenVal
            // 
            this.lblGenVal.AutoSize = true;
            this.lblGenVal.Location = new System.Drawing.Point(115, 33);
            this.lblGenVal.Name = "lblGenVal";
            this.lblGenVal.Size = new System.Drawing.Size(0, 13);
            this.lblGenVal.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 84);
            this.Controls.Add(this.lblGenVal);
            this.Controls.Add(this.btnGen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Label lblGenVal;
    }
}

