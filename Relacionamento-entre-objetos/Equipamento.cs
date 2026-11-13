using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
  
        public abstract class Equipamento
    {
        public string Modelo { get; set; }
        protected string NumeroSerie;

        public Equipamento(string modelo, string numeroSerie)
        {
            Modelo = modelo;
            NumeroSerie = numeroSerie;
        }
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo} | Nº de Série: {NumeroSerie}");
        }
    }
    }
