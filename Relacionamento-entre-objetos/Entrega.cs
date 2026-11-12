using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
    public abstract class Entrega
    {
        public double Distancia { get; set; }

        public Entrega(double distancia)
        {
            Distancia = distancia;
        }

        // Método abstrato (obriga as classes filhas a implementarem)
        public abstract decimal CalcularFrete();
    }
}