namespace AccessRemoteHelper.Views
{
    partial class TextReaded
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
            richTextReader = new RichTextBox();
            pnlCopiar = new Panel();
            label1 = new Label();
            pnlCopiar.SuspendLayout();
            SuspendLayout();
            // 
            // richTextReader
            // 
            richTextReader.Dock = DockStyle.Fill;
            richTextReader.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextReader.Location = new Point(0, 0);
            richTextReader.Name = "richTextReader";
            richTextReader.Size = new Size(253, 60);
            richTextReader.TabIndex = 1;
            richTextReader.Text = " ";
            richTextReader.KeyDown += richTextReader_KeyDown;
            // 
            // pnlCopiar
            // 
            pnlCopiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlCopiar.BackColor = Color.Transparent;
            pnlCopiar.Controls.Add(label1);
            pnlCopiar.Location = new Point(65, 44);
            pnlCopiar.Name = "pnlCopiar";
            pnlCopiar.Size = new Size(188, 16);
            pnlCopiar.TabIndex = 0;
            pnlCopiar.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(190, 15);
            label1.TabIndex = 0;
            label1.Text = "Copiado para área de transferência";
            // 
            // TextReaded
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 60);
            Controls.Add(pnlCopiar);
            Controls.Add(richTextReader);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "TextReaded";
            Opacity = 0.85D;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "TextReaded";
            TopMost = true;
            KeyDown += richTextReader_KeyDown;
            pnlCopiar.ResumeLayout(false);
            pnlCopiar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public RichTextBox richTextReader;
        private Panel pnlCopiar;
        private Label label1;
    }
}