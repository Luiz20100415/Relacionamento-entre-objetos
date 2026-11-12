

namespace RelacionamentoEntreObjetos
{
    public class CursosOnline : ProdutoDigital
    {
        public int CargaHoraria { get; set; }

        public CursosOnline(string nome, decimal preco, int cargaHoraria) : base(nome, preco)
        {
            CargaHoraria = cargaHoraria;
        }

        public virtual void ExibirInformacoesCursoOnline()
        {
            Console.WriteLine($"Nome: {Nome}, Preço: {Preco:C}, Carga Horária: {CargaHoraria} horas");
        }
    }
}
