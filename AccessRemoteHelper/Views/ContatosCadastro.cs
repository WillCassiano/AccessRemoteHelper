using AccessRemoteHelper.Data;
using AccessRemoteHelper.Models;
using Microsoft.Data.Sqlite;

namespace AccessRemoteHelper
{
    public partial class ContatosCadastro : Form
    {
        private string _contato;
        private string _id;
        private string _tipo;
        private string _password;
        private bool _estaEditando;

        private readonly IApplicationDb _applicationDb;

        public ContatosCadastro(string contato, string id, string tipo, string password, bool estaEditando = true) : base()
        {
            _contato = contato;
            _id = id;
            _tipo = tipo;
            _password = password;
            _estaEditando = estaEditando;

            InitializeComponent();
            _applicationDb = new ApplicationDb();

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
            _applicationDb = new ApplicationDb();
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
                    _applicationDb.EditarContato(_id, contato, id, tipo.ToString(), password);
                else
                    _applicationDb.NovoContato(contato, id, tipo.ToString(), password);

                Close();
            }
        }        
    }
}

