namespace AccessRemoteHelper.Views
{
    partial class Scanner
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
            timer1 = new System.Windows.Forms.Timer(components);
            picScan = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picScan).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // picScan
            // 
            picScan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picScan.BorderStyle = BorderStyle.FixedSingle;
            picScan.Location = new Point(0, 0);
            picScan.Name = "picScan";
            picScan.Size = new Size(369, 57);
            picScan.TabIndex = 0;
            picScan.TabStop = false;
            picScan.Click += Scanner_Click;
            // 
            // Scanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(369, 57);
            Controls.Add(picScan);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Scanner";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Scanner";
            TopMost = true;
            TransparencyKey = Color.LightSeaGreen;
            Load += Scanner_Load;
            Click += Scanner_Click;
            KeyDown += Scanner_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picScan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PictureBox picScan;
    }
}