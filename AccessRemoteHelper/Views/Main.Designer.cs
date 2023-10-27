namespace AccessRemoteHelper
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            txtClienteId = new TextBox();
            btnTeamViewer = new Button();
            btnAnyDesk = new Button();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            picStar = new PictureBox();
            txtPassword = new TextBox();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            btnRdp = new Button();
            picScanner = new PictureBox();
            lblModoLeitura = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picScanner).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.teamviewer_ico_128x128;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.anydesk_ico_128x128;
            pictureBox2.Location = new Point(98, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "ID do cliente";
            // 
            // txtClienteId
            // 
            txtClienteId.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteId.Location = new Point(12, 100);
            txtClienteId.MaxLength = 50;
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(229, 32);
            txtClienteId.TabIndex = 0;
            txtClienteId.TextAlign = HorizontalAlignment.Center;
            // 
            // btnTeamViewer
            // 
            btnTeamViewer.BackColor = Color.SkyBlue;
            btnTeamViewer.BackgroundImageLayout = ImageLayout.Zoom;
            btnTeamViewer.FlatStyle = FlatStyle.Flat;
            btnTeamViewer.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTeamViewer.Location = new Point(12, 193);
            btnTeamViewer.Name = "btnTeamViewer";
            btnTeamViewer.Size = new Size(73, 30);
            btnTeamViewer.TabIndex = 2;
            btnTeamViewer.Text = "TV";
            btnTeamViewer.UseVisualStyleBackColor = false;
            btnTeamViewer.Click += btnTeamViewer_Click;
            // 
            // btnAnyDesk
            // 
            btnAnyDesk.BackColor = Color.IndianRed;
            btnAnyDesk.BackgroundImageLayout = ImageLayout.Zoom;
            btnAnyDesk.FlatStyle = FlatStyle.Flat;
            btnAnyDesk.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnyDesk.Location = new Point(90, 193);
            btnAnyDesk.Name = "btnAnyDesk";
            btnAnyDesk.Size = new Size(73, 30);
            btnAnyDesk.TabIndex = 3;
            btnAnyDesk.Text = "Any";
            btnAnyDesk.UseVisualStyleBackColor = false;
            btnAnyDesk.Click += btnAnyDesk_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.VisualEditor___Icon___Menu_svg;
            pictureBox3.Location = new Point(217, 73);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(181, 78);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Salvos";
            // 
            // picStar
            // 
            picStar.Cursor = Cursors.Hand;
            picStar.Image = Properties.Resources.star_line_yellow_icon;
            picStar.Location = new Point(214, 104);
            picStar.Name = "picStar";
            picStar.Size = new Size(24, 24);
            picStar.SizeMode = PictureBoxSizeMode.StretchImage;
            picStar.TabIndex = 8;
            picStar.TabStop = false;
            picStar.Click += picStar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(12, 155);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(229, 32);
            txtPassword.TabIndex = 1;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.registry;
            pictureBox4.Location = new Point(148, 73);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(124, 78);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 12;
            label4.Text = "Log";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.rdp_icon1;
            pictureBox5.Location = new Point(184, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(57, 51);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // btnRdp
            // 
            btnRdp.BackColor = Color.Gainsboro;
            btnRdp.BackgroundImageLayout = ImageLayout.Zoom;
            btnRdp.FlatStyle = FlatStyle.Flat;
            btnRdp.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRdp.Location = new Point(168, 193);
            btnRdp.Name = "btnRdp";
            btnRdp.Size = new Size(73, 30);
            btnRdp.TabIndex = 14;
            btnRdp.Text = "RDP";
            btnRdp.UseVisualStyleBackColor = false;
            btnRdp.Click += btnRdp_Click;
            // 
            // picScanner
            // 
            picScanner.Cursor = Cursors.Hand;
            picScanner.Image = (Image)resources.GetObject("picScanner.Image");
            picScanner.Location = new Point(94, 73);
            picScanner.Name = "picScanner";
            picScanner.Size = new Size(24, 24);
            picScanner.SizeMode = PictureBoxSizeMode.StretchImage;
            picScanner.TabIndex = 15;
            picScanner.TabStop = false;
            picScanner.Click += picScanner_Click;
            // 
            // lblModoLeitura
            // 
            lblModoLeitura.AutoSize = true;
            lblModoLeitura.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point);
            lblModoLeitura.ForeColor = Color.FromArgb(255, 128, 0);
            lblModoLeitura.Location = new Point(12, 66);
            lblModoLeitura.Name = "lblModoLeitura";
            lblModoLeitura.Size = new Size(74, 13);
            lblModoLeitura.TabIndex = 16;
            lblModoLeitura.Text = "[Modo leitura]";
            lblModoLeitura.Visible = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(253, 231);
            Controls.Add(lblModoLeitura);
            Controls.Add(picScanner);
            Controls.Add(btnRdp);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(picStar);
            Controls.Add(pictureBox3);
            Controls.Add(btnAnyDesk);
            Controls.Add(btnTeamViewer);
            Controls.Add(txtClienteId);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(269, 270);
            MinimumSize = new Size(269, 270);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Access Remote Helper";
            KeyDown += Main_KeyDown;
            Move += Form1_Move;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picStar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picScanner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtClienteId;
        private Button btnTeamViewer;
        private Button btnAnyDesk;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox picStar;
        private TextBox txtPassword;
        private Label label3;
        private PictureBox pictureBox4;
        private Label label4;
        private PictureBox pictureBox5;
        private Button btnRdp;
        private PictureBox picScanner;
        private Label lblModoLeitura;
    }
}