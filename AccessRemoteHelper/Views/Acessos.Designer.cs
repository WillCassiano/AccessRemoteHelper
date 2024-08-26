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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acessos));
            dtGridAcessos = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            adicinonarContatoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            txtPesquisa = new TextBox();
            panel2 = new Panel();
            Data = new DataGridViewTextBoxColumn();
            Contato = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtGridAcessos).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dtGridAcessos
            // 
            dtGridAcessos.AllowUserToAddRows = false;
            dtGridAcessos.AllowUserToDeleteRows = false;
            dtGridAcessos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtGridAcessos.BackgroundColor = SystemColors.ActiveCaption;
            dtGridAcessos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridAcessos.Columns.AddRange(new DataGridViewColumn[] { Data, Contato, Id, Password, Tipo });
            dtGridAcessos.ContextMenuStrip = contextMenuStrip1;
            dtGridAcessos.Dock = DockStyle.Fill;
            dtGridAcessos.Location = new Point(0, 0);
            dtGridAcessos.MultiSelect = false;
            dtGridAcessos.Name = "dtGridAcessos";
            dtGridAcessos.ReadOnly = true;
            dtGridAcessos.RowHeadersVisible = false;
            dtGridAcessos.RowTemplate.Height = 25;
            dtGridAcessos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGridAcessos.Size = new Size(603, 257);
            dtGridAcessos.TabIndex = 0;
            dtGridAcessos.DoubleClick += dtGridAcessos_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { adicinonarContatoToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(170, 26);
            // 
            // adicinonarContatoToolStripMenuItem
            // 
            adicinonarContatoToolStripMenuItem.Image = Properties.Resources.star_line_yellow_icon;
            adicinonarContatoToolStripMenuItem.Name = "adicinonarContatoToolStripMenuItem";
            adicinonarContatoToolStripMenuItem.Size = new Size(169, 22);
            adicinonarContatoToolStripMenuItem.Text = "Adicionar contato";
            adicinonarContatoToolStripMenuItem.Click += adicinonarContatoToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPesquisa);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 40);
            panel1.TabIndex = 1;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesquisa.Location = new Point(11, 6);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(579, 29);
            txtPesquisa.TabIndex = 0;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            txtPesquisa.KeyDown += txtPesquisa_KeyDown;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtGridAcessos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(603, 257);
            panel2.TabIndex = 2;
            // 
            // Data
            // 
            Data.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Data.DataPropertyName = "Data";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            Data.DefaultCellStyle = dataGridViewCellStyle1;
            Data.HeaderText = "Data";
            Data.Name = "Data";
            Data.ReadOnly = true;
            Data.Width = 56;
            // 
            // Contato
            // 
            Contato.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Contato.DataPropertyName = "contato";
            Contato.HeaderText = "Contato";
            Contato.Name = "Contato";
            Contato.ReadOnly = true;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.DataPropertyName = "id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 42;
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Password.DataPropertyName = "password";
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Width = 82;
            // 
            // Tipo
            // 
            Tipo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tipo.DataPropertyName = "tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 55;
            // 
            // Acessos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(603, 297);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(619, 336);
            Name = "Acessos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acessos";
            Load += Acessos_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridAcessos).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtGridAcessos;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem adicinonarContatoToolStripMenuItem;
        private Panel panel1;
        private TextBox txtPesquisa;
        private Panel panel2;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Contato;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Tipo;
    }
}