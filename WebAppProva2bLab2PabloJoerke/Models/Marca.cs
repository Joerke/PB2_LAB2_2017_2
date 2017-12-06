using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2PabloJoerke.Models
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string  Descricao { get; set; }
        public List<Veiculo> Veiculos { get; set; } // lista de veiculos


    }
}