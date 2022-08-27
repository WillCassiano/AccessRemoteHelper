using AccessRemoteHelper.Assets;
using AccessRemoteHelper.Data;
using AccessRemoteHelper.Models;
using System.Data;

namespace AccessRemoteHelper
{
    public partial class Acessos : Form
    {
        private DataView _dataView;
        private readonly IAplicativoRemoto _aplicativoRemoto;
        private readonly IApplicationDb _applicationDb;

        public Acessos()
        {
            InitializeComponent();
            _aplicativoRemoto = new AplicativoRemoto();
            _applicationDb = new ApplicationDb();
        }


        private void Acessos_Load(object sender, EventArgs e)
        {
            ListarAcessos();
        }

        private void ListarAcessos()
        {
            _dataView = new DataView(_applicationDb.ListarAcessos());
            dtGridAcessos.DataSource = _dataView;
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

            _aplicativoRemoto.Conectar(id, password, (TipoAcesso)Enum.Parse(typeof(TipoAcesso), tipo));
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
            _dataView.RowFilter = $"Contato like '*{txtPesquisa.Text}*' OR " +
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

            if (index < dtGridAcessos.Rows.Count - 1)
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
