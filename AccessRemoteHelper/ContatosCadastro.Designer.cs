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
            this.label1 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoAcesso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contato";
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(12, 27);
            this.txtContato.MaxLength = 50;
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(229, 23);
            this.txtContato.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 74);
            this.txtId.MaxLength = 50;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(229, 23);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID do cliente";
            // 
            // cmbTipoAcesso
            // 
            this.cmbTipoAcesso.FormattingEnabled = true;
            this.cmbTipoAcesso.Items.AddRange(new object[] {
            "Anydesk",
            "TeamViewer",
            "Rdp"});
            this.cmbTipoAcesso.Location = new System.Drawing.Point(12, 167);
            this.cmbTipoAcesso.Name = "cmbTipoAcesso";
            this.cmbTipoAcesso.Size = new System.Drawing.Size(129, 23);
            this.cmbTipoAcesso.TabIndex = 3;
            this.cmbTipoAcesso.Text = "Anydesk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID do cliente";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.IndianRed;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.Location = new System.Drawing.Point(147, 152);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 41);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 123);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(229, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // ContatosCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 205);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoAcesso);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(269, 194);
            this.Name = "ContatosCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contato";
            this.ResumeLayout(false);
            this.PerformLayout();

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