namespace AccessRemoteHelper
{
    partial class ContatosCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContatosCadastro));
            label1 = new Label();
            txtContato = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            cmbTipoAcesso = new ComboBox();
            label3 = new Label();
            btnSalvar = new Button();
            txtPassword = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Contato";
            // 
            // txtContato
            // 
            txtContato.Location = new Point(12, 27);
            txtContato.MaxLength = 50;
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(229, 23);
            txtContato.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 74);
            txtId.MaxLength = 50;
            txtId.Name = "txtId";
            txtId.Size = new Size(229, 23);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "ID do cliente";
            // 
            // cmbTipoAcesso
            // 
            cmbTipoAcesso.FormattingEnabled = true;
            cmbTipoAcesso.Items.AddRange(new object[] { "Anydesk", "TeamViewer", "Rdp", "RustDesk" });
            cmbTipoAcesso.Location = new Point(12, 167);
            cmbTipoAcesso.Name = "cmbTipoAcesso";
            cmbTipoAcesso.Size = new Size(129, 23);
            cmbTipoAcesso.TabIndex = 3;
            cmbTipoAcesso.Text = "Anydesk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 5;
            label3.Text = "ID do cliente";
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.IndianRed;
            btnSalvar.BackgroundImageLayout = ImageLayout.Zoom;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Cascadia Code", 9F, FontStyle.Bold);
            btnSalvar.Location = new Point(147, 152);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 41);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 123);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(229, 23);
            txtPassword.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 105);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Password";
            // 
            // ContatosCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 205);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(btnSalvar);
            Controls.Add(label3);
            Controls.Add(cmbTipoAcesso);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(txtContato);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(269, 194);
            Name = "ContatosCadastro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Contato";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtContato;
        private TextBox txtId;
        private Label label2;
        private ComboBox cmbTipoAcesso;
        private Label label3;
        private Button btnSalvar;
        private TextBox txtPassword;
        private Label label4;
    }
}