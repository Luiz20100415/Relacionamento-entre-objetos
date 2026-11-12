using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
 public class EntregaExpressa : Entrega
    {
        public EntregaExpressa(double distancia) : base(distancia) { }

        public override decimal CalcularFrete()
        {
            decimal tarifaBasePorKm = 2.00m;
            decimal taxaAdicional = 15.00m;
            return ((decimal)Distancia * tarifaBasePorKm) + taxaAdicional;
        }
    }
}