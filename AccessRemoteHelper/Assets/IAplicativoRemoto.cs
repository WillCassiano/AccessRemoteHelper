using AccessRemoteHelper.Data;
using AccessRemoteHelper.Models;
using AccessRemoteHelper.Properties;
using System.Diagnostics;

namespace AccessRemoteHelper.Assets
{
    internal interface IAplicativoRemoto
    {
        void Conectar(string id, string password, TipoAcesso tipoAcesso);
    }

    public class AplicativoRemoto : IAplicativoRemoto
    {
        private readonly IApplicationDb _applicationDb;

        private Settings _settings;

        public AplicativoRemoto()
        {
            _applicationDb = new ApplicationDb();
            _settings = new Settings();
        }

        public void Conectar(string id, string password, TipoAcesso tipoAcesso)
        {
            id = id.Replace(" ", "").Trim();

            if (id.Length < 8) return;

            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;
            processStartInfo.RedirectStandardOutput = true;

            ChecarExecutavel(tipoAcesso);

            switch (tipoAcesso)
            {
                case TipoAcesso.TeamViewer:
                    processStartInfo.FileName = _settings.TeamViewer;
                    processStartInfo.Arguments = $"--id {id}";
                    processStartInfo.Arguments = $"--id {id}";

                    if (!string.IsNullOrEmpty(password))
                        processStartInfo.Arguments += $" --Password {password.Trim()}";
                    break;
                case TipoAcesso.Anydesk:
                    RemoverDadosAnyDesk();
                    processStartInfo.FileName = _settings.Anydesk;
                    processStartInfo.Arguments = $"{id}";
                    break;
                case TipoAcesso.Rdp:
                    processStartInfo.FileName = _settings.Rdp;
                    processStartInfo.Arguments = $"/v:{id}";
                    break;
                case TipoAcesso.UltraViewer:
                    processStartInfo.FileName = _settings.UltraViewer;
                    processStartInfo.Arguments = $"-i:{id}";
                    if (!string.IsNullOrEmpty(password))
                        processStartInfo.Arguments += $" -p:{password.Trim()}";
                    break;
                case TipoAcesso.RustDesk:
                    processStartInfo.FileName = _settings.RustDesk;
                    processStartInfo.Arguments = $"{id}";
                    // RustDesk não usa senha pela linha de comando neste fluxo
                    break;
                default:
                    break;
            }

            Process.Start(processStartInfo);

            _applicationDb.RegistrarAcesso(id, tipoAcesso, password);
        }

        private void RemoverDadosAnyDesk()
        {
            var process = Process.GetProcessesByName("anydesk");
            if (process.Length == 0)
            {
                try
                {
                    var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AnyDesk");
                    File.Delete(folder);
                }
                catch (Exception)
                {

                }
            }
        }

        private void ChecarExecutavel(TipoAcesso tipoAcesso)
        {
            var executavel = string.Empty;
            switch (tipoAcesso)
            {
                case TipoAcesso.TeamViewer:
                    executavel = _settings.TeamViewer;
                    break;
                case TipoAcesso.Anydesk:
                    executavel = _settings.Anydesk;
                    break;
                case TipoAcesso.RustDesk:
                    executavel = _settings.RustDesk;
                    break;
                case TipoAcesso.UltraViewer:
                    executavel = _settings.UltraViewer;
                    break;
                default:
                    break;
            }

            if (!File.Exists(executavel))
            {
                OpenFileDialog dialog = new OpenFileDialog()
                {
                    RestoreDirectory = true,
                    Multiselect = false,
                    Title = $"Selecione o executável do [{tipoAcesso.ToString()}]",
                    Filter = "Aplicativo | *.exe"
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    switch (tipoAcesso)
                    {
                        case TipoAcesso.TeamViewer:
                            _settings.TeamViewer = dialog.FileName;
                            break;
                        case TipoAcesso.Anydesk:
                            _settings.Anydesk = dialog.FileName;
                            break;
                        case TipoAcesso.RustDesk:
                            _settings.RustDesk = dialog.FileName;
                            break;
                        case TipoAcesso.UltraViewer:
                            _settings.UltraViewer = dialog.FileName;
                            break;
                        default:
                            break;
                    }

                    _settings.Save();
                }
            }
        }
    }
}
