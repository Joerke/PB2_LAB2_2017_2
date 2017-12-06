using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2PabloJoerke.Models
{
    public class Endereco
    {
        [ForeignKey("Cliente")]
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Numero { get; set; }
    }
}