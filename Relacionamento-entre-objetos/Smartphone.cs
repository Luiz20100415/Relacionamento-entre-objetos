using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
public class Smartphone : Equipamento
    {
        public int Armazenamento { get; set; }

        public Smartphone(string modelo, string numeroSerie, int armazenamento) 
            : base(modelo, numeroSerie)
        {
            Armazenamento = armazenamento;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("--- Dados do Smartphone ---");
            base.ExibirInformacoes();
            Console.WriteLine($"Armazenamento: {Armazenamento} GB\n");
        }
    }
}