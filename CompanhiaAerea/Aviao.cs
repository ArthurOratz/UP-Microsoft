using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanhiaAerea
{
    public class Aviao
    {
        public int Id { get; set; }

        IList<Voo> Voos { get; set; }


    }
}
