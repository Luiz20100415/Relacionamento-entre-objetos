using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
    public class Relatorio : IImprimivel, IExportavel
    {
        public string Titulo { get; set; }

        public Relatorio(string titulo)
        {
            Titulo = titulo;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo o relatório '{Titulo}' na impressora padrão...");
        }

        public void Exportar()
        {
            Console.WriteLine($"Exportando o relatório '{Titulo}' para formato PDF e Excel...");
        }
    }
}