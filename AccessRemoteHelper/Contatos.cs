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

namespace AccessRemoteHelper
{
    public partial class Contatos : Form
    {
        private readonly Main _main;
        public Contatos(Main main)
        {
            InitializeComponent();
            _main = main;
        }

        private void Contatos_Load(object sender, EventArgs e)
        {
            ListarContatos();
        }

        public void ListarContatos()
        {
            listViewContatos.Items.Clear();

            using (var connection = new SqliteConnection("Data Source=contatos.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT CONTATO, ID, TIPO, PASSWORD FROM CONTATOS";
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var contact = reader.GetString(0);
                    var id = reader.GetString(1);
                    var type = Enum.Parse<TipoAcesso>(reader.GetString(2));
                    var password = reader.GetString(3);
                    listViewContatos.Items
                                    .Add(contact)
                                    .SubItems.AddRange(new[]
                                    {
                                        id,
                                        type.ToString(),
                                        password
                                    });
                }

            }
        }

        private void listViewContatos_DoubleClick(object sender, EventArgs e)
        {
            if (listViewContatos.SelectedItems.Count == 0) return;

            var id = listViewContatos.SelectedItems[0].SubItems[1].Text;
            var tipo = listViewContatos.SelectedItems[0].SubItems[2].Text;
            var password = listViewContatos.SelectedItems[0].SubItems[3].Text;
            var tipoAcesso = (TipoAcesso)Enum.Parse(typeof(TipoAcesso), tipo);

            _main.Conectar(id, tipoAcesso, password);
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
            if (listViewContatos.SelectedItems.Count == 0) return;

            var contato = listViewContatos.SelectedItems[0].SubItems[0].Text;
            var id = listViewContatos.SelectedItems[0].SubItems[1].Text;
            var tipo = listViewContatos.SelectedItems[0].SubItems[2].Text;
            var password = listViewContatos.SelectedItems[0].SubItems[3].Text;


            ContatosCadastro contatoCadastro = new ContatosCadastro(contato, id, tipo, password);
            contatoCadastro.ShowDialog();
            ListarContatos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listViewContatos.SelectedItems.Count == 0) return;

            var id = listViewContatos.SelectedItems[0].SubItems[1].Text;

            ExcluirContato(id);
            ListarContatos();
        }

        private void ExcluirContato(string id)
        {
            using (var connection = new SqliteConnection("Data Source=contatos.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM CONTATOS WHERE ID=@ID";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@ID", id);

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
