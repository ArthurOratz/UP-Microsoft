using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanhiaAerea
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa p = new Pessoa() { Nome = "Alex Pinheiro"};
            Cidade cwb = new Cidade() { Nome = "Curitiba" };
            Cidade bsb = new Cidade() { Nome = "Brasilia" };
            Cidade vix = new Cidade() { Nome = "Vitoria" };
            Voo vooCwbBsb = new Voo();
            vooCwbBsb.Origem = cwb;
            vooCwbBsb.Destino = bsb;

            Voo vooBsbVix = new Voo();
            vooBsbVix.Origem = bsb;
            vooBsbVix.Destino = vix;

            Passagem passagem = new Passagem();
            passagem.Passageiro = p;
            passagem.Trechos.Add(vooCwbBsb);
            passagem.Trechos.Add(vooBsbVix);







        }

        

    }
    
}
