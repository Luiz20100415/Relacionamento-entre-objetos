using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
 public class Notebook : Equipamento
    {
        public int MemoriaRAM { get; set; }

        public Notebook(string modelo, string numeroSerie, int memoriaRAM) 
            : base(modelo, numeroSerie)
        {
            MemoriaRAM = memoriaRAM;
        }

        // 3 e 4. Sobrescrita reutilizando base.ExibirInformacoes()
        public override void ExibirInformacoes()
        {
            Console.WriteLine("--- Dados do Notebook ---");
            base.ExibirInformacoes();
            Console.WriteLine($"Memória RAM: {MemoriaRAM} GB\n");
        }
    }
}