using AccessRemoteHelper.Assets;
using AccessRemoteHelper.Data;
using AccessRemoteHelper.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AccessRemoteHelper
{
    public partial class Contatos : Form
    {
        private readonly IAplicativoRemoto _aplicativoRemoto;
        private readonly IApplicationDb _applicationDb;
        private DataView _dataView;
        public Contatos()
        {
            InitializeComponent();
            _aplicativoRemoto = new AplicativoRemoto();
            _applicationDb = new ApplicationDb();
        }

        private void Contatos_Load(object sender, EventArgs e)
        {
            ListarContatos();
        }

        public void ListarContatos()
        {
            _dataView = new DataView(_applicationDb.ListarContatos());
            dtGridContatos.DataSource = _dataView;
        }

        private void Contatos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ContatosCadastro contatosCadastro = new ContatosCadastro();
            contatosCadastro.ShowDialog();
            ListarContatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dtGridContatos.SelectedRows.Count == 0) return;

            var contato = dtGridContatos.SelectedRows[0].Cells["Contato"].Value as string;
            var id = dtGridContatos.SelectedRows[0].Cells["Id"].Value as string;
            var tipo = dtGridContatos.SelectedRows[0].Cells["Tipo"].Value as string;
            var password = dtGridContatos.SelectedRows[0].Cells["Password"].Value as string;


            ContatosCadastro contatoCadastro = new ContatosCadastro(contato, id, tipo, password);
            contatoCadastro.ShowDialog();
            ListarContatos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dtGridContatos.SelectedRows.Count == 0) return;

            var id = dtGridContatos.SelectedRows[0].Cells["Id"].Value as string;

            _applicationDb.ExcluirContato(id);
            ListarContatos();
        }



        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            _dataView.RowFilter = $"nome like '*{txtPesquisa.Text}*' OR " +
                                  $"Id like '*{txtPesquisa.Text}*'";
        }

        private void dtGridContatos_DoubleClick(object sender, EventArgs e)
        {
            if (dtGridContatos.SelectedRows.Count == 0) return;

            var id          = dtGridContatos.SelectedRows[0].Cells["Id"].Value as string;
            var tipo        = dtGridContatos.SelectedRows[0].Cells["Tipo"].Value as string;
            var password    = dtGridContatos.SelectedRows[0].Cells["Password"].Value as string;
            var tipoAcesso  = (TipoAcesso)Enum.Parse(typeof(TipoAcesso), tipo);

            _aplicativoRemoto.Conectar(id, password, tipoAcesso);
        }
    }
}
