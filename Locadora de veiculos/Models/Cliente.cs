using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Locadora_de_veiculos.Models
{
    public class Cliente
    {
        public long ClienteID { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string CPF { get; set; }

        public string NumCNH { get; set; }

        public string Logradouro { get; set; }

        public string Cidade { get; set; }

        public string CEP { get; set; }

        public virtual ICollection<Locacao> Locacaos { get; set; }

    }
}