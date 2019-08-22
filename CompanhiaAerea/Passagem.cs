using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanhiaAerea
{
    [Table("Passagens")]
    public class Passagem
    {
        public int PasssagemId { get; set; }

        public Cidade Origem { get; set; }
        public Cidade Destindo { get; set; }

       public IList<Voo> Trechos { get; set; }

        public Pessoa Passageiro { get; set; }

        public FormaPagamento Pagamento { get; set; }

        public IList<Poltrona> poltronas { get; set; }

    }
}
