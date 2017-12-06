using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2PabloJoerke.Models
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public string String { get; set; }
        public string Placa { get; set; }
        public List<Locacao> Locacoes { get; set; } // lista de locaçoes 
        public Marca MarcaId { get; set; } // FK
        public Marca Marca { get; set; } // Propriedade de navegaçao 


    }
}