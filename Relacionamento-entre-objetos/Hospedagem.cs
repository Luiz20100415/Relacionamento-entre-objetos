using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
   public class Hospedagem : Servico, IContratavel, ICancelavel
    {
        public Hospedagem(string nome) : base(nome) { }

        public void Contratar()
        {
            Console.WriteLine($"[Hospedagem] O serviço '{Nome}' foi contratado com ativação imediata.");
        }

        public void Cancelar()
        {
            Console.WriteLine($"[Hospedagem] A assinatura do serviço '{Nome}' foi cancelada com sucesso.");
        }
    }
}