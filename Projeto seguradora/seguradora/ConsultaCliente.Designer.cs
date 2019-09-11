namespace seguradora
{
    partial class ConsultaCliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCliente));
			this.txt_Cpf = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_Alterar = new System.Windows.Forms.Button();
			this.btn_Sair = new System.Windows.Forms.Button();
			this.btn_Limpar = new System.Windows.Forms.Button();
			this.btn_Excluir = new System.Windows.Forms.Button();
			this.txt_telefoneCliente = new System.Windows.Forms.TextBox();
			this.txt_enderecoCliente = new System.Windows.Forms.TextBox();
			this.txt_nascCliente = new System.Windows.Forms.TextBox();
			this.txt_nomeCliente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_consultaCpf = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_ConsultarCliente = new System.Windows.Forms.Button();
			this.txt_codCliente = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txt_Cpf
			// 
			this.txt_Cpf.Location = new System.Drawing.Point(192, 84);
			this.txt_Cpf.Name = "txt_Cpf";
			this.txt_Cpf.Size = new System.Drawing.Size(135, 20);
			this.txt_Cpf.TabIndex = 81;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label5.Location = new System.Drawing.Point(152, 85);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 16);
			this.label5.TabIndex = 80;
			this.label5.Text = "CPF";
			// 
			// btn_Alterar
			// 
			this.btn_Alterar.BackColor = System.Drawing.Color.Gray;
			this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Alterar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Alterar.ForeColor = System.Drawing.SystemColors.Info;
			this.btn_Alterar.Location = new System.Drawing.Point(49, 212);
			this.btn_Alterar.Name = "btn_Alterar";
			this.btn_Alterar.Size = new System.Drawing.Size(94, 23);
			this.btn_Alterar.TabIndex = 79;
			this.btn_Alterar.Text = "ALTERAR";
			this.btn_Alterar.UseVisualStyleBackColor = false;
			this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
			// 
			// btn_Sair
			// 
			this.btn_Sair.BackColor = System.Drawing.Color.Gray;
			this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Sair.ForeColor = System.Drawing.SystemColors.Info;
			this.btn_Sair.Location = new System.Drawing.Point(493, 212);
			this.btn_Sair.Name = "btn_Sair";
			this.btn_Sair.Size = new System.Drawing.Size(94, 23);
			this.btn_Sair.TabIndex = 77;
			this.btn_Sair.Text = "SAIR";
			this.btn_Sair.UseVisualStyleBackColor = false;
			this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
			// 
			// btn_Limpar
			// 
			this.btn_Limpar.BackColor = System.Drawing.Color.Gray;
			this.btn_Limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Limpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Limpar.ForeColor = System.Drawing.SystemColors.Info;
			this.btn_Limpar.Location = new System.Drawing.Point(350, 212);
			this.btn_Limpar.Name = "btn_Limpar";
			this.btn_Limpar.Size = new System.Drawing.Size(94, 23);
			this.btn_Limpar.TabIndex = 78;
			this.btn_Limpar.Text = "LIMPAR";
			this.btn_Limpar.UseVisualStyleBackColor = false;
			this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
			// 
			// btn_Excluir
			// 
			this.btn_Excluir.BackColor = System.Drawing.Color.Gray;
			this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Excluir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Excluir.ForeColor = System.Drawing.SystemColors.Info;
			this.btn_Excluir.Location = new System.Drawing.Point(205, 212);
			this.btn_Excluir.Name = "btn_Excluir";
			this.btn_Excluir.Size = new System.Drawing.Size(92, 23);
			this.btn_Excluir.TabIndex = 76;
			this.btn_Excluir.Text = "EXCLUIR";
			this.btn_Excluir.UseVisualStyleBackColor = false;
			this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
			// 
			// txt_telefoneCliente
			// 
			this.txt_telefoneCliente.Location = new System.Drawing.Point(192, 170);
			this.txt_telefoneCliente.Name = "txt_telefoneCliente";
			this.txt_telefoneCliente.Size = new System.Drawing.Size(135, 20);
			this.txt_telefoneCliente.TabIndex = 73;
			// 
			// txt_enderecoCliente
			// 
			this.txt_enderecoCliente.Location = new System.Drawing.Point(192, 142);
			this.txt_enderecoCliente.Name = "txt_enderecoCliente";
			this.txt_enderecoCliente.Size = new System.Drawing.Size(438, 20);
			this.txt_enderecoCliente.TabIndex = 74;
			// 
			// txt_nascCliente
			// 
			this.txt_nascCliente.Location = new System.Drawing.Point(192, 112);
			this.txt_nascCliente.Name = "txt_nascCliente";
			this.txt_nascCliente.Size = new System.Drawing.Size(135, 20);
			this.txt_nascCliente.TabIndex = 75;
			// 
			// txt_nomeCliente
			// 
			this.txt_nomeCliente.Location = new System.Drawing.Point(192, 54);
			this.txt_nomeCliente.Name = "txt_nomeCliente";
			this.txt_nomeCliente.Size = new System.Drawing.Size(338, 20);
			this.txt_nomeCliente.TabIndex = 72;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label3.Location = new System.Drawing.Point(111, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 16);
			this.label3.TabIndex = 68;
			this.label3.Text = "TELEFONE";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label4.Location = new System.Drawing.Point(108, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 16);
			this.label4.TabIndex = 69;
			this.label4.Text = "ENDEREÇO";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new System.Drawing.Point(34, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 16);
			this.label2.TabIndex = 70;
			this.label2.Text = "DATA DE NASCIMENTO";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(59, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 16);
			this.label1.TabIndex = 71;
			this.label1.Text = "NOME DO CLIENTE";
			// 
			// txt_consultaCpf
			// 
			this.txt_consultaCpf.Location = new System.Drawing.Point(192, 12);
			this.txt_consultaCpf.Name = "txt_consultaCpf";
			this.txt_consultaCpf.Size = new System.Drawing.Size(135, 20);
			this.txt_consultaCpf.TabIndex = 83;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label6.Location = new System.Drawing.Point(94, 13);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 16);
			this.label6.TabIndex = 82;
			this.label6.Text = "Informar CPF";
			// 
			// btn_ConsultarCliente
			// 
			this.btn_ConsultarCliente.BackColor = System.Drawing.Color.Gray;
			this.btn_ConsultarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_ConsultarCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ConsultarCliente.ForeColor = System.Drawing.SystemColors.Info;
			this.btn_ConsultarCliente.Location = new System.Drawing.Point(333, 10);
			this.btn_ConsultarCliente.Name = "btn_ConsultarCliente";
			this.btn_ConsultarCliente.Size = new System.Drawing.Size(94, 23);
			this.btn_ConsultarCliente.TabIndex = 84;
			this.btn_ConsultarCliente.Text = "CONSULTAR";
			this.btn_ConsultarCliente.UseVisualStyleBackColor = false;
			this.btn_ConsultarCliente.Click += new System.EventHandler(this.btn_ConsultarCliente_Click);
			// 
			// txt_codCliente
			// 
			this.txt_codCliente.Enabled = false;
			this.txt_codCliente.Location = new System.Drawing.Point(605, 13);
			this.txt_codCliente.Name = "txt_codCliente";
			this.txt_codCliente.Size = new System.Drawing.Size(42, 20);
			this.txt_codCliente.TabIndex = 85;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label7.Location = new System.Drawing.Point(539, 14);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 16);
			this.label7.TabIndex = 86;
			this.label7.Text = "CÓDIGO";
			// 
			// ConsultaCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::seguradora.Properties.Resources._1;
			this.ClientSize = new System.Drawing.Size(659, 271);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txt_codCliente);
			this.Controls.Add(this.btn_ConsultarCliente);
			this.Controls.Add(this.txt_consultaCpf);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_Cpf);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btn_Alterar);
			this.Controls.Add(this.btn_Sair);
			this.Controls.Add(this.btn_Limpar);
			this.Controls.Add(this.btn_Excluir);
			this.Controls.Add(this.txt_telefoneCliente);
			this.Controls.Add(this.txt_enderecoCliente);
			this.Controls.Add(this.txt_nascCliente);
			this.Controls.Add(this.txt_nomeCliente);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ConsultaCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CONSULTAR CLIENTE";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Cpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.TextBox txt_telefoneCliente;
        private System.Windows.Forms.TextBox txt_enderecoCliente;
        private System.Windows.Forms.TextBox txt_nascCliente;
        private System.Windows.Forms.TextBox txt_nomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_consultaCpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ConsultarCliente;
		private System.Windows.Forms.TextBox txt_codCliente;
		private System.Windows.Forms.Label label7;
	}
}