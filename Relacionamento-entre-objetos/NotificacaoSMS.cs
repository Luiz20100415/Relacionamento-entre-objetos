using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentoEntreObjetos
{
    public class NotificacaoSMS : Notificacao
    {
     
        public override void Enviar()
        {
            Console.WriteLine("Enviando notificação por SMS...");
        }
    }
}