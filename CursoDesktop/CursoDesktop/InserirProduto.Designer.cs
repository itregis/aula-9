namespace CursoDesktop
{
    partial class InserirProduto
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
            this.gbNovoCliente = new System.Windows.Forms.GroupBox();
            this.nuValor = new System.Windows.Forms.NumericUpDown();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.cbFabricante = new System.Windows.Forms.ComboBox();
            this.gbNovoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuValor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNovoCliente
            // 
            this.gbNovoCliente.Controls.Add(this.cbFabricante);
            this.gbNovoCliente.Controls.Add(this.lblFabricante);
            this.gbNovoCliente.Controls.Add(this.nuValor);
            this.gbNovoCliente.Controls.Add(this.lblValor);
            this.gbNovoCliente.Controls.Add(this.txtDescricao);
            this.gbNovoCliente.Controls.Add(this.label1);
            this.gbNovoCliente.Controls.Add(this.txtCodigo);
            this.gbNovoCliente.Controls.Add(this.lblCodigo);
            this.gbNovoCliente.Location = new System.Drawing.Point(12, 12);
            this.gbNovoCliente.Name = "gbNovoCliente";
            this.gbNovoCliente.Size = new System.Drawing.Size(627, 289);
            this.gbNovoCliente.TabIndex = 4;
            this.gbNovoCliente.TabStop = false;
            this.gbNovoCliente.Text = "Novo Cliente";
            // 
            // nuValor
            // 
            this.nuValor.Location = new System.Drawing.Point(76, 93);
            this.nuValor.Name = "nuValor";
            this.nuValor.Size = new System.Drawing.Size(120, 20);
            this.nuValor.TabIndex = 9;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(6, 93);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            this.lblValor.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(76, 67);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(545, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(76, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 41);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(12, 307);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(93, 307);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 5;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(6, 119);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(57, 13);
            this.lblFabricante.TabIndex = 10;
            this.lblFabricante.Text = "Fabricante";
            // 
            // cbFabricante
            // 
            this.cbFabricante.FormattingEnabled = true;
            this.cbFabricante.Location = new System.Drawing.Point(76, 119);
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(235, 21);
            this.cbFabricante.TabIndex = 11;
            // 
            // InserirProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 371);
            this.Controls.Add(this.gbNovoCliente);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btLimpar);
            this.Name = "InserirProduto";
            this.Text = "InserirProduto";
            this.gbNovoCliente.ResumeLayout(false);
            this.gbNovoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuValor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNovoCliente;
        private System.Windows.Forms.NumericUpDown nuValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.ComboBox cbFabricante;
        private System.Windows.Forms.Label lblFabricante;
    }
}