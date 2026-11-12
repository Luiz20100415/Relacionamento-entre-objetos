
namespace RelacionamentoEntreObjetos
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
        }
    }
}

