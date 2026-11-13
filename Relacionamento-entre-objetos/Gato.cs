using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
   public class Gato : Animal
    {
        public Gato(string nome) : base(nome) { }

        // 6. Implementação com override
        public override void EmitirSom()
        {
            Console.WriteLine("Som: Miau! (Miado)\n");
        }
    }
}