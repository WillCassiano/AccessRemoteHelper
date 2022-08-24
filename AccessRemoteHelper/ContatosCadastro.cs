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
    public partial class ContatosCadastro : Form
    {
        private string _contato;
        private string _id;
        private string _tipo;
        private string _password;
        private bool _estaEditando;

        public ContatosCadastro(string contato, string id, string tipo, string password, bool estaEditando = true) : base()
        {
            _contato = contato;
            _id = id;
            _tipo = tipo;
            _password = password;
            _estaEditando = estaEditando;
            InitializeComponent();
            LoadInfo();
        }

        private void LoadInfo()
        {
            txtContato.Text = _contato;
            txtId.Text = _id;
            cmbTipoAcesso.Text = _tipo;
            txtPassword.Text = _password;
        }

        public ContatosCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var id = txtId.Text.Replace(" ", "").Trim();
            var contato = txtContato.Text;
            var password = txtPassword.Text;

            if (id.Length < 9)
            {
                MessageBox.Show("ID Inválido");
                return;
            }

            if (Enum.TryParse(typeof(TipoAcesso), cmbTipoAcesso.Text, out var tipo))
            {
                if (_estaEditando)
                    EditarContato(contato, id, tipo.ToString(), password);
                else
                    NovoContato(contato, id, tipo.ToString(), password);
            }
        }

        private void EditarContato(string contato, string id, string tipo, string password)
        {
            using (var connection = new SqliteConnection("Data Source=contatos.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "UPDATE CONTATOS SET CONTATO=@CONTATO, ID=@ID, TIPO=@TIPO, PASSWORD=@PASSWORD WHERE ID=@OLDID";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@CONTATO", contato);
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@TIPO", tipo);
                command.Parameters.AddWithValue("@PASSWORD", password);
                command.Parameters.AddWithValue("@OLDID", _id);

                command.ExecuteNonQuery();

                connection.Close();

                Close();
            }
        }

        private void NovoContato(string contato, string id, string tipo, string password)
        {
            using (var connection = new SqliteConnection("Data Source=contatos.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO CONTATOS (CONTATO, ID, TIPO, PASSWORD) VALUES (@CONTATO, @ID, @TIPO, @PASSWORD)";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@CONTATO", contato);
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@TIPO", tipo);
                command.Parameters.AddWithValue("@PASSWORD", password);

                command.ExecuteNonQuery();

                connection.Close();

                Close();
            }
        }
    }
}
