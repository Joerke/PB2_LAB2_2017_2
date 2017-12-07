using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2PabloJoerke.Models
{
    public class Locacao
    {
        public int LocacaoId { get; set; }
        public int Numero { get; set; }
        public DateTime DataLocacao { get; set; }
        public Cliente ClienteId { get; set; } // fk
        public Cliente Cliente { get; set; } // propriedade de navegaçao
        public List<Veiculo> Veiculos { get; set; }// lista de veiculos



    }
}