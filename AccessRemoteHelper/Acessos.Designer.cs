namespace AccessRemoteHelper
{
    partial class Acessos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acessos));
            this.dtGridAcessos = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adicinonarContatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAcessos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridAcessos
            // 
            this.dtGridAcessos.AllowUserToAddRows = false;
            this.dtGridAcessos.AllowUserToDeleteRows = false;
            this.dtGridAcessos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridAcessos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtGridAcessos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridAcessos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Contato,
            this.Id,
            this.Password,
            this.Tipo});
            this.dtGridAcessos.ContextMenuStrip = this.contextMenuStrip1;
            this.dtGridAcessos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGridAcessos.Location = new System.Drawing.Point(0, 0);
            this.dtGridAcessos.MultiSelect = false;
            this.dtGridAcessos.Name = "dtGridAcessos";
            this.dtGridAcessos.ReadOnly = true;
            this.dtGridAcessos.RowHeadersVisible = false;
            this.dtGridAcessos.RowTemplate.Height = 25;
            this.dtGridAcessos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridAcessos.Size = new System.Drawing.Size(603, 257);
            this.dtGridAcessos.TabIndex = 0;
            this.dtGridAcessos.DoubleClick += new System.EventHandler(this.dtGridAcessos_DoubleClick);
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Data.DataPropertyName = "data";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy HH:mm:ss";
            this.Data.DefaultCellStyle = dataGridViewCellStyle1;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 56;
            // 
            // Contato
            // 
            this.Contato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Contato.DataPropertyName = "contato";
            this.Contato.HeaderText = "Contato";
            this.Contato.Name = "Contato";
            this.Contato.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 42;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Password.DataPropertyName = "password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 82;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tipo.DataPropertyName = "tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 55;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicinonarContatoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(170, 26);
            // 
            // adicinonarContatoToolStripMenuItem
            // 
            this.adicinonarContatoToolStripMenuItem.Image = global::AccessRemoteHelper.Properties.Resources.star_line_yellow_icon;
            this.adicinonarContatoToolStripMenuItem.Name = "adicinonarContatoToolStripMenuItem";
            this.adicinonarContatoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.adicinonarContatoToolStripMenuItem.Text = "Adicionar contato";
            this.adicinonarContatoToolStripMenuItem.Click += new System.EventHandler(this.adicinonarContatoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 40);
            this.panel1.TabIndex = 1;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPesquisa.Location = new System.Drawing.Point(11, 6);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(579, 29);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtGridAcessos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 257);
            this.panel2.TabIndex = 2;
            // 
            // Acessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 297);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(619, 336);
            this.Name = "Acessos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acessos";
            this.Load += new System.EventHandler(this.Acessos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridAcessos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtGridAcessos;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Contato;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Tipo;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem adicinonarContatoToolStripMenuItem;
        private Panel panel1;
        private TextBox txtPesquisa;
        private Panel panel2;
    }
}