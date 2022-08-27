namespace AccessRemoteHelper.Models
{
    public class Acesso
    {
        public DateTime Data { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
        public TipoAcesso TipoAcesso { get; set; }

        public Contato? Contato { get; set; }
    }
}
