namespace ProjetoExemplo.WindowsForms.UI
{
    partial class FFormularioInicial
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
            this.LblNomeFornecedor = new System.Windows.Forms.Label();
            this.TxtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblContato = new System.Windows.Forms.Label();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dvgFornecedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNomeFornecedor
            // 
            this.LblNomeFornecedor.AutoSize = true;
            this.LblNomeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeFornecedor.Location = new System.Drawing.Point(12, 23);
            this.LblNomeFornecedor.Name = "LblNomeFornecedor";
            this.LblNomeFornecedor.Size = new System.Drawing.Size(125, 13);
            this.LblNomeFornecedor.TabIndex = 0;
            this.LblNomeFornecedor.Text = "Nome do Fornecedor";
            // 
            // TxtNomeFornecedor
            // 
            this.TxtNomeFornecedor.Location = new System.Drawing.Point(15, 39);
            this.TxtNomeFornecedor.Name = "TxtNomeFornecedor";
            this.TxtNomeFornecedor.Size = new System.Drawing.Size(293, 20);
            this.TxtNomeFornecedor.TabIndex = 1;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(12, 72);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(61, 13);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "Endereço";
            this.lblEndereco.Click += new System.EventHandler(this.lblEndereco_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(15, 88);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(377, 20);
            this.txtEndereco.TabIndex = 1;
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.Location = new System.Drawing.Point(12, 120);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(105, 13);
            this.lblContato.TabIndex = 0;
            this.lblContato.Text = "Nome do Contato";
            this.lblContato.Click += new System.EventHandler(this.lblEndereco_Click);
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.Location = new System.Drawing.Point(15, 136);
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(223, 20);
            this.txtNomeContato.TabIndex = 1;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(12, 168);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(57, 13);
            this.lblTelefone.TabIndex = 0;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Click += new System.EventHandler(this.lblEndereco_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(15, 184);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(223, 20);
            this.txtTelefone.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(15, 224);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(215, 35);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dvgFornecedores
            // 
            this.dvgFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFornecedores.Location = new System.Drawing.Point(15, 281);
            this.dvgFornecedores.Name = "dvgFornecedores";
            this.dvgFornecedores.Size = new System.Drawing.Size(730, 179);
            this.dvgFornecedores.TabIndex = 3;
            // 
            // FFormularioInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 529);
            this.Controls.Add(this.dvgFornecedores);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtNomeContato);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.TxtNomeFornecedor);
            this.Controls.Add(this.LblNomeFornecedor);
            this.Name = "FFormularioInicial";
            this.Text = "Tela de Cadastro de Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dvgFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNomeFornecedor;
        private System.Windows.Forms.TextBox TxtNomeFornecedor;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.TextBox txtNomeContato;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dvgFornecedores;
    }
}

