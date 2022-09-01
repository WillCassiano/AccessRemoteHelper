namespace AccessRemoteHelper
{
    partial class Contatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contatos));
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dtGridContatos = new System.Windows.Forms.DataGridView();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(12, 5);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(89, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(166, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisa.Location = new System.Drawing.Point(12, 34);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(229, 29);
            this.txtPesquisa.TabIndex = 4;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // dtGridContatos
            // 
            this.dtGridContatos.AllowUserToAddRows = false;
            this.dtGridContatos.AllowUserToDeleteRows = false;
            this.dtGridContatos.AllowUserToResizeRows = false;
            this.dtGridContatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridContatos.BackgroundColor = System.Drawing.Color.White;
            this.dtGridContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Contato,
            this.Id,
            this.Tipo,
            this.Password});
            this.dtGridContatos.Location = new System.Drawing.Point(12, 69);
            this.dtGridContatos.MultiSelect = false;
            this.dtGridContatos.Name = "dtGridContatos";
            this.dtGridContatos.ReadOnly = true;
            this.dtGridContatos.RowHeadersVisible = false;
            this.dtGridContatos.RowTemplate.Height = 25;
            this.dtGridContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridContatos.Size = new System.Drawing.Size(229, 218);
            this.dtGridContatos.TabIndex = 5;
            this.dtGridContatos.DoubleClick += new System.EventHandler(this.dtGridContatos_DoubleClick);
            // 
            // Contato
            // 
            this.Contato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Contato.DataPropertyName = "nome";
            this.Contato.HeaderText = "Contato";
            this.Contato.Name = "Contato";
            this.Contato.ReadOnly = true;
            this.Contato.Width = 75;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id.";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 45;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Contatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(253, 299);
            this.Controls.Add(this.dtGridContatos);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(269, 338);
            this.Name = "Contatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Contatos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Contatos_FormClosing);
            this.Load += new System.EventHandler(this.Contatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridContatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnNovo;
        private Button btnEditar;
        private Button btnExcluir;
        private TextBox txtPesquisa;
        private DataGridView dtGridContatos;
        private DataGridViewTextBoxColumn Contato;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Password;
    }
}