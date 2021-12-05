using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Locadora_de_veiculos.Models
{
    public class Locacao
    {
        public long? LocacaoID { get; set; }

        public string Nome { get; set; }

        public long? ClienteID { get; set; }

        public long? VeiculoID { get; set; }

        public Cliente Cliente { get; set; }

        public Veiculo Veiculo { get; set; }
    }
}