using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
    public class JogoDigital : Jogo
    {
        public double TamanhoGB { get; set; }
        
        public JogoDigital(string nome, string plataforma, double tamanhoGB) : base(nome, plataforma)
        {
            TamanhoGB = tamanhoGB;
        }
       public override void ExibirInformacoesJogo()
    {
        Console.WriteLine($"Jogo Digital - Nome: {Nome} | Plataforma: {Plataforma} | Tamanho para download: {TamanhoGB} GB");
    }
    }
}