using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; set; }
        public Moto(int cilindrada) : base("Marca da Moto", "Modelo da Moto")
        {
            Cilindrada = cilindrada;
        }
        public void ExibirInformacoesMoto()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Cilindrada: {Cilindrada}");
        }
    }
}