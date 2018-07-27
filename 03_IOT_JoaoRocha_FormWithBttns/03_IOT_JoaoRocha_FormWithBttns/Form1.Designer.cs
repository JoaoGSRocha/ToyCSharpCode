using System.Windows.Forms;

namespace _03_IOT_JoaoRocha_FormWithBttns
{
    partial class frmUtilizadores
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.btnNome = new System.Windows.Forms.Button();
            this.btnSobrenome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(40, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.Location = new System.Drawing.Point(40, 42);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(70, 13);
            this.lblSobrenome.TabIndex = 1;
            this.lblSobrenome.Text = "Sobrenome";
            this.lblSobrenome.Click += new System.EventHandler(this.lblSobrenome_Click);
            // 
            // btnNome
            // 
            this.btnNome.Location = new System.Drawing.Point(343, 13);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(75, 23);
            this.btnNome.TabIndex = 2;
            this.btnNome.Text = "Ver";
            this.btnNome.UseVisualStyleBackColor = true;
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // btnSobrenome
            // 
            this.btnSobrenome.Location = new System.Drawing.Point(343, 42);
            this.btnSobrenome.Name = "btnSobrenome";
            this.btnSobrenome.Size = new System.Drawing.Size(75, 23);
            this.btnSobrenome.TabIndex = 4;
            this.btnSobrenome.Text = "Ver";
            this.btnSobrenome.UseVisualStyleBackColor = true;
            this.btnSobrenome.Click += new System.EventHandler(this.btnSobrenome_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 6;
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(117, 41);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(220, 20);
            this.t.TabIndex = 7;
            // 
            // frmUtilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 192);
            this.Controls.Add(this.t);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSobrenome);
            this.Controls.Add(this.btnNome);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmUtilizadores";
            this.Text = "Utilizadores";
            this.Load += new System.EventHandler(this.frmUtilizadores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
  

        private System.Windows.Forms.Button btnNome;
        private System.Windows.Forms.Button btnSobrenome;
        private Button button1;
        private TextBox textBox1;
        private TextBox t;

        //public TextBox TxtNome { get => txtNome; set => txtNome = value; }
        //public TextBox TxtSobrenome { get => txtSobrenome; set => txtSobrenome = value; }
    }
}

