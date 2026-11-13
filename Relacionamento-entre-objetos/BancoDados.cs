using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
    public class BancoDados : IArmazenavel
    {
        public void Salvar(string conteudo)
        {
            Console.WriteLine($"[Banco de Dados] Inserindo registro na tabela: \"{conteudo}\"");
        }

        public void Ler()
        {
            Console.WriteLine("[Banco de Dados] Consultando dados armazenados no banco de dados.\n");
        }
    }
}
