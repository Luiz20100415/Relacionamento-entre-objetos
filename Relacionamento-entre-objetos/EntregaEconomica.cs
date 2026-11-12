using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
        public class EntregaEconomica : Entrega
    {
        public EntregaEconomica(double distancia) : base(distancia) { }

        public override decimal CalcularFrete()
        {
            decimal tarifaReduzidaPorKm = 0.80m;
            return (decimal)Distancia * tarifaReduzidaPorKm;
        }
    }
    }
