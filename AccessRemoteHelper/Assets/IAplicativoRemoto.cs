using AccessRemoteHelper.Data;
using AccessRemoteHelper.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessRemoteHelper.Assets
{
    internal interface IAplicativoRemoto
    {
        void Conectar(string id, string password, TipoAcesso tipoAcesso);
    }

    public class AplicativoRemoto: IAplicativoRemoto
    {
        private readonly IApplicationDb _applicationDb;

        public AplicativoRemoto()
        {
            _applicationDb = new ApplicationDb();
        }

        public void Conectar(string id, string password, TipoAcesso tipoAcesso)
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

            _applicationDb.RegistrarAcesso(id, tipoAcesso, password);
        }
    }
}
