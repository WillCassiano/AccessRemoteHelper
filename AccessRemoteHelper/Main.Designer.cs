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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.btnTeamViewer = new System.Windows.Forms.Button();
            this.btnAnyDesk = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picStar = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnRdp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AccessRemoteHelper.Properties.Resources.teamviewer_ico_128x128;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AccessRemoteHelper.Properties.Resources.anydesk_ico_128x128;
            this.pictureBox2.Location = new System.Drawing.Point(98, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID do cliente";
            // 
            // txtClienteId
            // 
            this.txtClienteId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClienteId.Location = new System.Drawing.Point(12, 100);
            this.txtClienteId.MaxLength = 50;
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(229, 32);
            this.txtClienteId.TabIndex = 0;
            this.txtClienteId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTeamViewer
            // 
            this.btnTeamViewer.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTeamViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTeamViewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeamViewer.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTeamViewer.Location = new System.Drawing.Point(12, 193);
            this.btnTeamViewer.Name = "btnTeamViewer";
            this.btnTeamViewer.Size = new System.Drawing.Size(73, 30);
            this.btnTeamViewer.TabIndex = 2;
            this.btnTeamViewer.Text = "TV";
            this.btnTeamViewer.UseVisualStyleBackColor = false;
            this.btnTeamViewer.Click += new System.EventHandler(this.btnTeamViewer_Click);
            // 
            // btnAnyDesk
            // 
            this.btnAnyDesk.BackColor = System.Drawing.Color.IndianRed;
            this.btnAnyDesk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnyDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnyDesk.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnyDesk.Location = new System.Drawing.Point(90, 193);
            this.btnAnyDesk.Name = "btnAnyDesk";
            this.btnAnyDesk.Size = new System.Drawing.Size(73, 30);
            this.btnAnyDesk.TabIndex = 3;
            this.btnAnyDesk.Text = "Any";
            this.btnAnyDesk.UseVisualStyleBackColor = false;
            this.btnAnyDesk.Click += new System.EventHandler(this.btnAnyDesk_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::AccessRemoteHelper.Properties.Resources.VisualEditor___Icon___Menu_svg;
            this.pictureBox3.Location = new System.Drawing.Point(217, 73);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(181, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Salvos";
            // 
            // picStar
            // 
            this.picStar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picStar.Image = global::AccessRemoteHelper.Properties.Resources.star_line_yellow_icon;
            this.picStar.Location = new System.Drawing.Point(214, 104);
            this.picStar.Name = "picStar";
            this.picStar.Size = new System.Drawing.Size(24, 24);
            this.picStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar.TabIndex = 8;
            this.picStar.TabStop = false;
            this.picStar.Click += new System.EventHandler(this.picStar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(12, 155);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(229, 32);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::AccessRemoteHelper.Properties.Resources.registry;
            this.pictureBox4.Location = new System.Drawing.Point(148, 73);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(124, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Log";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::AccessRemoteHelper.Properties.Resources.rdp_icon1;
            this.pictureBox5.Location = new System.Drawing.Point(184, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(57, 51);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // btnRdp
            // 
            this.btnRdp.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRdp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRdp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRdp.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRdp.Location = new System.Drawing.Point(168, 193);
            this.btnRdp.Name = "btnRdp";
            this.btnRdp.Size = new System.Drawing.Size(73, 30);
            this.btnRdp.TabIndex = 14;
            this.btnRdp.Text = "RDP";
            this.btnRdp.UseVisualStyleBackColor = false;
            this.btnRdp.Click += new System.EventHandler(this.btnRdp_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(253, 231);
            this.Controls.Add(this.btnRdp);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.picStar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnAnyDesk);
            this.Controls.Add(this.btnTeamViewer);
            this.Controls.Add(this.txtClienteId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(269, 270);
            this.MinimumSize = new System.Drawing.Size(269, 270);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access Remote Helper";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.Move += new System.EventHandler(this.Form1_Move);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}