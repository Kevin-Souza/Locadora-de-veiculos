using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Locadora_de_veiculos.Models
{
    public class Veiculo
    {
        public long VeiculoID { get; set; }

        public string Nome { get; set; }

        public string Marca { get; set; }

        public string Ano { get; set; }

        public string Km { get; set; }

        public string Combustivel { get; set; }

        public string Cor { get; set; }

        public virtual ICollection<Locacao> Locacaos { get; set; }
    }
}