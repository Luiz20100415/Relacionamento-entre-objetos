using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
    public class ArquivoTexto : IArmazenavel
    {
        public void Salvar(string conteudo)
        {
            Console.WriteLine($"[Arquivo de Texto] Salvando conteúdo no arquivo .txt: \"{conteudo}\"");
        }

        public void Ler()
        {
            Console.WriteLine("[Arquivo de Texto] Lendo dados armazenados no arquivo .txt.\n");
        }
    }
}