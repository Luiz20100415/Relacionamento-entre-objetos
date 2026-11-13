using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
    public class Passaro : Animal
    {
        public Passaro(string nome) : base(nome) { }

        // 6. Implementação com override
        public override void EmitirSom()
        {
            Console.WriteLine("Som: Piu piu! (Canto)\n");
        }
    }
}