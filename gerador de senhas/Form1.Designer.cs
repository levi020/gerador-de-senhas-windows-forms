namespace gerador_de_senhas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnGerador = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RDespeciais = new System.Windows.Forms.RadioButton();
            this.RDnumb = new System.Windows.Forms.RadioButton();
            this.RDlm = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(288, 55);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(100, 20);
            this.tbxSenha.TabIndex = 0;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(13, 43);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(73, 13);
            this.lblresult.TabIndex = 1;
            this.lblresult.Text = "RESULTADO";
            // 
            // btnGerador
            // 
            this.btnGerador.Location = new System.Drawing.Point(299, 112);
            this.btnGerador.Name = "btnGerador";
            this.btnGerador.Size = new System.Drawing.Size(75, 23);
            this.btnGerador.TabIndex = 2;
            this.btnGerador.Text = "Gerar senha";
            this.btnGerador.UseVisualStyleBackColor = true;
            this.btnGerador.Click += new System.EventHandler(this.btnGerador_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RDespeciais);
            this.groupBox1.Controls.Add(this.RDnumb);
            this.groupBox1.Controls.Add(this.RDlm);
            this.groupBox1.Location = new System.Drawing.Point(237, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 117);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha as opções";
            // 
            // RDespeciais
            // 
            this.RDespeciais.AutoSize = true;
            this.RDespeciais.Location = new System.Drawing.Point(6, 65);
            this.RDespeciais.Name = "RDespeciais";
            this.RDespeciais.Size = new System.Drawing.Size(146, 17);
            this.RDespeciais.TabIndex = 2;
            this.RDespeciais.TabStop = true;
            this.RDespeciais.Text = "Com caracteres especiais";
            this.RDespeciais.UseVisualStyleBackColor = true;
            // 
            // RDnumb
            // 
            this.RDnumb.AutoSize = true;
            this.RDnumb.Location = new System.Drawing.Point(6, 42);
            this.RDnumb.Name = "RDnumb";
            this.RDnumb.Size = new System.Drawing.Size(89, 17);
            this.RDnumb.TabIndex = 1;
            this.RDnumb.TabStop = true;
            this.RDnumb.Text = "Com números";
            this.RDnumb.UseVisualStyleBackColor = true;
            // 
            // RDlm
            // 
            this.RDlm.AutoSize = true;
            this.RDlm.Location = new System.Drawing.Point(6, 19);
            this.RDlm.Name = "RDlm";
            this.RDlm.Size = new System.Drawing.Size(110, 17);
            this.RDlm.TabIndex = 0;
            this.RDlm.TabStop = true;
            this.RDlm.Text = "Letras Maiusculas";
            this.RDlm.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblresult);
            this.groupBox2.Location = new System.Drawing.Point(227, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 117);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(271, 23);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(135, 13);
            this.lblHome.TabIndex = 2;
            this.lblHome.Text = "Qual o tamanho da senha?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aviso: valor mínimo igua a 8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGerador);
            this.Controls.Add(this.tbxSenha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnGerador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RDlm;
        private System.Windows.Forms.RadioButton RDnumb;
        private System.Windows.Forms.RadioButton RDespeciais;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label label1;
    }
}

