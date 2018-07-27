namespace _05_IOT_JoaoRocha_SeveralBttnsForm
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
            this.btnBotao1 = new System.Windows.Forms.Button();
            this.btnBotao2 = new System.Windows.Forms.Button();
            this.btnBotao3 = new System.Windows.Forms.Button();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBotao1
            // 
            this.btnBotao1.Location = new System.Drawing.Point(22, 30);
            this.btnBotao1.Name = "btnBotao1";
            this.btnBotao1.Size = new System.Drawing.Size(75, 44);
            this.btnBotao1.TabIndex = 0;
            this.btnBotao1.Text = "Botão 1";
            this.btnBotao1.UseVisualStyleBackColor = true;
            // 
            // btnBotao2
            // 
            this.btnBotao2.Location = new System.Drawing.Point(103, 30);
            this.btnBotao2.Name = "btnBotao2";
            this.btnBotao2.Size = new System.Drawing.Size(75, 44);
            this.btnBotao2.TabIndex = 1;
            this.btnBotao2.Text = "Botão 2";
            this.btnBotao2.UseVisualStyleBackColor = true;
            this.btnBotao2.Click += new System.EventHandler(this.btnBotao2_Click);
            // 
            // btnBotao3
            // 
            this.btnBotao3.Location = new System.Drawing.Point(184, 30);
            this.btnBotao3.Name = "btnBotao3";
            this.btnBotao3.Size = new System.Drawing.Size(75, 44);
            this.btnBotao3.TabIndex = 2;
            this.btnBotao3.Text = "Botão 3";
            this.btnBotao3.UseVisualStyleBackColor = true;
            this.btnBotao3.Click += new System.EventHandler(this.btnBotao3_Click);
            // 
            // btnMensagem
            // 
            this.btnMensagem.Location = new System.Drawing.Point(265, 30);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(75, 44);
            this.btnMensagem.TabIndex = 3;
            this.btnMensagem.Text = "Mensagem";
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.btnMensagem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 109);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMensagem);
            this.Controls.Add(this.btnBotao3);
            this.Controls.Add(this.btnBotao2);
            this.Controls.Add(this.btnBotao1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBotao1;
        private System.Windows.Forms.Button btnBotao2;
        private System.Windows.Forms.Button btnBotao3;
        private System.Windows.Forms.Button btnMensagem;
        private System.Windows.Forms.Button button1;
    }
}

