using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
    public class Contrato : IImprimivel
    {
        public string NumeroContrato { get; set; }

        public Contrato(string numeroContrato)
        {
            NumeroContrato = numeroContrato;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo o contrato nº {NumeroContrato} em papel timbrado...");
        }
    }
}