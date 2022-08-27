using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessRemoteHelper.Models
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
        public TipoAcesso TipoAcesso { get; set; }
    }
}
