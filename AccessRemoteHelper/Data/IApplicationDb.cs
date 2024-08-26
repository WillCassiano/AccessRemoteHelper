using AccessRemoteHelper.Models;
using Microsoft.Data.Sqlite;
using System.Data;

namespace AccessRemoteHelper.Data
{
    internal interface IApplicationDb
    {
        void RegistrarAcesso(string id, TipoAcesso tipoAcesso, string password);
        void CreateEnsure();

        void NovoContato(string contato, string id, string tipo, string password);
        void EditarContato(string oldId, string contato, string id, string tipo, string password);
        void ExcluirContato(string id);

        DataTable ListarAcessos();
        DataTable ListarContatos();
    }

    public class ApplicationDb : IApplicationDb
    {
        public ApplicationDb()
        {
            this.CreateEnsure();
        }
        public void RegistrarAcesso(string id, TipoAcesso tipoAcesso, string password)
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

        public void CreateEnsure()
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

        public DataTable ListarAcessos()
        {
            using (var connection = new SqliteConnection("Data Source=contatos.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT AC.DATA, CT.CONTATO, AC.ID, AC.PASSWORD, AC.TIPO FROM ACESSOS AC LEFT JOIN CONTATOS CT ON AC.ID = CT.ID ORDER BY AC.DATA DESC";

                var dt = new DataTable();

                var columnDate = new DataColumn("Data");
                columnDate.DataType = typeof(DateTime);

                dt.Columns.Add(columnDate);
                dt.Columns.Add("Contato");
                dt.Columns.Add("Id");
                dt.Columns.Add("Password");
                dt.Columns.Add("Tipo");
                dt.Load(command.ExecuteReader());

                connection.Close();

                return dt;
            }
        }

        public DataTable ListarContatos()
        {
            using (var connection = new SqliteConnection("Data Source=contatos.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT CONTATO AS nome, ID, TIPO, PASSWORD FROM CONTATOS";

                var dt = new DataTable();
                dt.Load(command.ExecuteReader());

                connection.Close();

                return dt;
            }
        }

        public void NovoContato(string contato, string id, string tipo, string password)
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
            }
        }

        public void EditarContato(string oldId, string contato, string id, string tipo, string password)
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
                command.Parameters.AddWithValue("@OLDID", oldId);

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void ExcluirContato(string id)
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
