using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
    public class JogoFisico : Jogo
    {
        public string Midia { get; set; }

        public JogoFisico(string nome, string plataforma, string midia) : base(nome, plataforma)
        {
            Midia = midia;
        }

        public override void ExibirInformacoesJogo()
        {
            Console.WriteLine($"Jogo Físico - Nome: {Nome} | Plataforma: {Plataforma} | Mídia: {Midia}");
        }
    }
}