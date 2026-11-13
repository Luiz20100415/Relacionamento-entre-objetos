using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
        public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome) { }

        // 6. Implementação com override
        public override void EmitirSom()
        {
            Console.WriteLine("Som: Au au! (Latido)\n");
        }
    }
}