using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
    public class Ebook : ProdutoDigital
    {
         public int QuantidadePaginas { get; set; }

        public Ebook(string nome, decimal preco, int quantidadePaginas) : base(nome, preco)
        {
            QuantidadePaginas = quantidadePaginas;
        }   

        public void ExibirInformacoesEbook()
        {
            Console.WriteLine($"Nome: {Nome}, Preço: {Preco:C}, Quantidade de Páginas: {QuantidadePaginas}");
        }
    }
}
