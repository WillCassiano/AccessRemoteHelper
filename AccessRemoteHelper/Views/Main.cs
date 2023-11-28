using AccessRemoteHelper.Assets;
using AccessRemoteHelper.Data;
using AccessRemoteHelper.Models;
using AccessRemoteHelper.Views;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Diagnostics;
using System.Security.Cryptography;

namespace AccessRemoteHelper
{
    public partial class Main : Form
    {
        private readonly Contatos _contatos;
        private readonly IAplicativoRemoto _aplicativoRemoto;
        private readonly IApplicationDb _applicationDb;
        private bool OpenWithReaderText = false;
        public Main()
        {
            InitializeComponent();
            _contatos = new Contatos();
            _aplicativoRemoto = new AplicativoRemoto();
            _applicationDb = new ApplicationDb();
            _applicationDb.CreateEnsure();
        }

        private void btnTeamViewer_Click(object sender, EventArgs e)
        {
            _aplicativoRemoto.Conectar(txtClienteId.Text, txtPassword.Text, TipoAcesso.TeamViewer);
        }

        private void btnAnyDesk_Click(object sender, EventArgs e)
        {
            _aplicativoRemoto.Conectar(txtClienteId.Text, txtPassword.Text, TipoAcesso.Anydesk);
        }

        private void btnRdp_Click(object sender, EventArgs e)
        {
            _aplicativoRemoto.Conectar(txtClienteId.Text, txtPassword.Text, TipoAcesso.Rdp);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (_contatos.WindowState == FormWindowState.Minimized)
                _contatos.WindowState = FormWindowState.Normal;

            if (_contatos.Visible)
                _contatos.Hide();
            else
            {
                _contatos.Show();
                _contatos.ListarContatos();
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            _contatos.DesktopLocation = new System.Drawing.Point(this.DesktopLocation.X + this.Size.Width, this.DesktopLocation.Y);
        }

        private void picStar_Click(object sender, EventArgs e)
        {
            if (txtClienteId.Text.Length < 9)
            {
                MessageBox.Show("ID inválido, mínimo de 9 digitos");
                return;
            }
            ContatosCadastro contatosCadastro = new ContatosCadastro("", txtClienteId.Text, "Anydesk", txtPassword.Text, false);
            contatosCadastro.ShowDialog();

            _contatos.ListarContatos();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Acessos acessos = new Acessos();
            acessos.ShowDialog();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{tab}");

            if (e.KeyCode == Keys.F1)
            {
                OpenWithReaderText = !OpenWithReaderText;
                lblModoLeitura.Visible = OpenWithReaderText;
            };

        }

        private void picScanner_Click(object sender, EventArgs e)
        {
            Scanner scanner = new Scanner(txtClienteId, OpenWithReaderText);
            scanner.Show();
        }

        private void btnUltra_Click(object sender, EventArgs e)
        {
            _aplicativoRemoto.Conectar(txtClienteId.Text, txtPassword.Text, TipoAcesso.UltraViewer);
        }

        private void Main_Load(object sender, EventArgs e)
        {

            var source = new AutoCompleteStringCollection();
            source.AddRange(_applicationDb.ListarAcessos()
                .AsEnumerable()
                .Select(x => new { Id = x["Id"].ToString(), Tipo = x["Tipo"].ToString(), DataHora = Convert.ToDateTime(x["Data"]) })                
                .GroupBy(c => (c.Id, c.Tipo))      
                .Select(x => new { x.Key.Id, x.Key.Tipo, Tempo = DateTime.Now - x.Max(g => g.DataHora) })
                .OrderBy(x => x.Tempo)
                .Select(c =>
                    $"{c.Id.PadRight(25, ' ')}| {c.Tipo.PadLeft(12, ' ')}"
        
                )
                .ToArray());
            
            txtClienteId.AutoCompleteCustomSource = source;
            txtClienteId.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtClienteId.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }



        private void txtClienteId_TextChanged(object sender, EventArgs e)
        {
            var campos = txtClienteId.Text.Split("|");
            if (campos is null) return;

            txtClienteId.Text = campos[0].Trim();
        }
    }
}