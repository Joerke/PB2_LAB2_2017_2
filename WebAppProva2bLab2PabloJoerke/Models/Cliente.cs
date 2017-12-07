using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2PabloJoerke.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Locacao> Locacoes { get; set; } // lista de locaçoes
        public Endereco Endereco { get; set; } // propriedade de navegaçao
    }
}