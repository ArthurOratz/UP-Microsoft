using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanhiaAerea
{
    [Table("FormaDePagamento")]
    public class FormaPagamento
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public Decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }

        public Passagem Passagem { get; set; }
    }
}
