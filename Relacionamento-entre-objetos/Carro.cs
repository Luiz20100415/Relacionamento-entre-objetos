using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
    public class Carro : Veiculo    
    {
         public int  QuantidadePortas { get; set; }
        public Carro(int quantidadePortas) : base("Marca do Carro", "Modelo do Carro")
        {
            QuantidadePortas = quantidadePortas;
        }
        public void ExibirInformacoesCarro()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Número de Portas: {QuantidadePortas}");
        }
    }
}

