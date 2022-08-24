using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Security.Cryptography;

namespace AccessRemoteHelper
{
    public partial class Main : Form
    {
        private readonly Contatos _contatos;
        public Main()
        {
            InitializeComponent();
            _contatos = new Contatos(this);       
            CreateEnsure();
        }

        private void btnTeamViewer_Click(object sender, EventArgs e)
        {
            Conectar(txtClienteId.Text, TipoAcesso.TeamViewer, txtPassword.Text);
        }

        private void btnAnyDesk_Click(object sender, EventArgs e)
        {
            Conectar(txtClienteId.Text, TipoAcesso.Anydesk, txtPassword.Text);
        }

        public void Conectar(string id, TipoAcesso tipoAcesso, string password = null)
        {
            id = id.Replace(" ", "").Trim();

            if (id.Length < 9) return;            

            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.RedirectStandardOutput = true;

            switch (tipoAcesso)
            {
                case TipoAcesso.TeamViewer:
                    processStartInfo.FileName = @"C:\Program Files (x86)\TeamViewer\TeamViewer.exe";
                    processStartInfo.Arguments = $"--id {id}";

                    if (!string.IsNullOrEmpty(password))
                        processStartInfo.Arguments += $" --Password {password.Trim()}";
                    break;
                case TipoAcesso.Anydesk:
                    processStartInfo.FileName = @"C:\Program Files (x86)\AnyDesk\AnyDesk.exe";
                    processStartInfo.Arguments = $"{id}";
                    break;
                case TipoAcesso.Rdp:
                    processStartInfo.FileName = @"mstsc";
                    processStartInfo.Arguments = $"/v:{id}";
                    break;
                default:
                    break;
            }

            Process.Start(processStartInfo);            

            RegistrarAcesso(id, tipoAcesso, password);
        }

        private void RegistrarAcesso(string id, TipoAcesso tipoAcesso, string password)
        {
            using (var connection = new SqliteConnection("Data Source=contatos.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO ACESSOS (DATA, ID, TIPO, PASSWORD) VALUES (@DATA, @ID, @TIPO, @PASSWORD)";
                command.Parameters.Clear();

                command.Parameters.AddWithValue("@DATA", DateTime.Now);
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@TIPO", tipoAcesso.ToString());
                command.Parameters.AddWithValue("@PASSWORD", password);

                command.ExecuteNonQuery();

                connection.Close();
            }
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



        private void CreateEnsure()
        {
            if (!File.Exists("contatos.db"))
            {
                File.WriteAllBytes("contatos.db", new byte[0]);
                using (var connection = new SqliteConnection("Data Source=contatos.db"))
                {
                    connection.Open();

                    SqliteCommand command = connection.CreateCommand();

                    string sql = "create table contatos(contato varchar(50), id varchar(50), tipo varchar(25), password varchar(50))";
                    command.CommandText = sql;                    
                    command.ExecuteNonQuery();

                    sql = "create table acessos (data datetime, id varchar(50), tipo varchar(25), password varchar(50))";
                    command.CommandText = sql;
                    command.ExecuteNonQuery();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Acessos acessos = new Acessos(this);
            acessos.ShowDialog();
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{tab}");
        }

        private void btnRdp_Click(object sender, EventArgs e)
        {
            Conectar(txtClienteId.Text, TipoAcesso.Rdp, txtPassword.Text);
        }
    }
}