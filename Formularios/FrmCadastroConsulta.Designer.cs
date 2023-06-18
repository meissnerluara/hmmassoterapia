
namespace hmmassoterapia
{
    partial class FrmCadastroConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroConsulta));
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.txtdtconsulta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPagamento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProcedimento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(211, 375);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(83, 37);
            this.btnlimpar.TabIndex = 37;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Location = new System.Drawing.Point(493, 375);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(102, 37);
            this.btncadastrar.TabIndex = 36;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(348, 375);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(96, 37);
            this.btncancelar.TabIndex = 35;
            this.btncancelar.Text = "Cancelar ";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtdtconsulta
            // 
            this.txtdtconsulta.Location = new System.Drawing.Point(438, 145);
            this.txtdtconsulta.Name = "txtdtconsulta";
            this.txtdtconsulta.Size = new System.Drawing.Size(157, 20);
            this.txtdtconsulta.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(245, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 22);
            this.label5.TabIndex = 43;
            this.label5.Text = "Data da Consulta:";
            // 
            // cmbPagamento
            // 
            this.cmbPagamento.FormattingEnabled = true;
            this.cmbPagamento.Items.AddRange(new object[] {
            "Débito",
            "Crédito",
            "Pix",
            "Dinheiro"});
            this.cmbPagamento.Location = new System.Drawing.Point(438, 286);
            this.cmbPagamento.Name = "cmbPagamento";
            this.cmbPagamento.Size = new System.Drawing.Size(157, 21);
            this.cmbPagamento.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(205, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 22);
            this.label10.TabIndex = 51;
            this.label10.Text = "Forma de Pagamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 22);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tipo de Procedimento:";
            // 
            // cmbProcedimento
            // 
            this.cmbProcedimento.FormattingEnabled = true;
            this.cmbProcedimento.Items.AddRange(new object[] {
            "Massoterapia",
            "Moxaterapia",
            "Reflexología",
            "Ventosaterapia"});
            this.cmbProcedimento.Location = new System.Drawing.Point(438, 192);
            this.cmbProcedimento.Name = "cmbProcedimento";
            this.cmbProcedimento.Size = new System.Drawing.Size(157, 21);
            this.cmbProcedimento.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "Quantidade de sessões:";
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(438, 235);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(157, 20);
            this.txtquantidade.TabIndex = 54;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(438, 101);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(157, 20);
            this.txtemail.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(352, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 55;
            this.label2.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(192, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 56);
            this.label6.TabIndex = 57;
            this.label6.Text = "Cadastro Consulta";
            // 
            // FrmCadastroConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 469);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProcedimento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbPagamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdtconsulta);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.btncancelar);
            this.Name = "FrmCadastroConsulta";
            this.Text = "Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtdtconsulta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPagamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProcedimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}