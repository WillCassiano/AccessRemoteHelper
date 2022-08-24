using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessRemoteHelper
{
    public partial class Acessos : Form
    {
        private readonly Main _main;
        private DataView _data;

        public Acessos(Main main)
        {
            InitializeComponent();
            _main = main;
        }
        private void ListarAcessos()
        {
            using (var connection = new SqliteConnection("Data Source=contatos.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT AC.DATA, CT.CONTATO, AC.ID, AC.PASSWORD, AC.TIPO FROM ACESSOS AC LEFT JOIN CONTATOS CT ON AC.ID = CT.ID ORDER BY AC.DATA DESC";

                var reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                connection.Close();

                _data = new DataView(dt);

                dtGridAcessos.DataSource = _data;
            }
        }

        private void Acessos_Load(object sender, EventArgs e)
        {
            ListarAcessos();
        }

        private void dtGridAcessos_DoubleClick(object sender, EventArgs e)
        {
            Conectar();
        }

        private void Conectar()
        {
            if (dtGridAcessos.SelectedRows.Count == 0) return;

            var id = dtGridAcessos.SelectedRows[0].Cells["Id"].Value as string;
            var password = dtGridAcessos.SelectedRows[0].Cells["Password"].Value as string;
            var tipo = dtGridAcessos.SelectedRows[0].Cells["Tipo"].Value as string;

            _main.Conectar(id, (TipoAcesso)Enum.Parse(typeof(TipoAcesso), tipo), password);
        }

        private void adicinonarContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtGridAcessos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um contato");
                return;
            }

            var id = dtGridAcessos.SelectedRows[0].Cells["Id"].Value as string;
            var password = dtGridAcessos.SelectedRows[0].Cells["Password"].Value as string;
            var tipo = dtGridAcessos.SelectedRows[0].Cells["Tipo"].Value as string;

            ContatosCadastro contatosCadastro = new ContatosCadastro("", id, tipo, password, false);

            contatosCadastro.ShowDialog();

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            _data.RowFilter = $"Contato like '*{txtPesquisa.Text}*' OR " +
                              $"Id like '*{txtPesquisa.Text}*'";
        }

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                NextRow();
            if (e.KeyCode == Keys.Up)
                PreviousRow();
            if (e.KeyCode == Keys.Enter)
            {
                if (MessageBox.Show("Você irá se conectar a este contato, deseja continuar?", "Confirmação de acesso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Conectar();
                }
            }
        }

        private void NextRow()
        {
            var index = dtGridAcessos.SelectedRows[0].Index;

            if (index < dtGridAcessos.Rows.Count -1)
            {
                dtGridAcessos.Rows[index].Selected = false;
                dtGridAcessos.Rows[++index].Selected = true;
            }

        }

        private void PreviousRow()
        {
            var index = dtGridAcessos.SelectedRows[0].Index;

            if (index > 0)
            {
                dtGridAcessos.Rows[index].Selected = false;
                dtGridAcessos.Rows[--index].Selected = true;
            }
        }
    }
}
