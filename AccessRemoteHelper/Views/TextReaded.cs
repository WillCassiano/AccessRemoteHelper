using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessRemoteHelper.Views
{
    public partial class TextReaded : Form
    {
        public TextReaded()
        {
            InitializeComponent();
        }

        private void richTextReader_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Hide();
        }

        public void CopiarTexto()
        {
            if (!string.IsNullOrEmpty(richTextReader.Text))
            {
                Clipboard.SetText(richTextReader.Text);
                pnlCopiar.Visible = true;
            }
        }
    }
}
