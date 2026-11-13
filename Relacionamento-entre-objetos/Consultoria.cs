using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
   public class Consultoria : Servico, IContratavel
    {
        public Consultoria(string nome) : base(nome) { }

        public void Contratar()
        {
            Console.WriteLine($"[Consultoria] O pacote de '{Nome}' foi contratado e agendado com um especialista.");
        }
    }
}