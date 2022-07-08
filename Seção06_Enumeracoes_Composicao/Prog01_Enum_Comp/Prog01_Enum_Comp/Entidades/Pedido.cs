// CLASSE PEDIDO

using System;
using Prog01_Enum_Comp.Entidades.Enumerados;

namespace Prog01_Enum_Comp.Entidades
{
    internal class Pedido
    {
        public int Id { get; set; }
        public DateTime InstantePedido { get; set; }
        public StatusPedidos Status { get; set; } // Tipo enumerado

        public override string ToString()
        {
            return "Código id: " + Id + "\nPedido solicitado em: " + InstantePedido + "\nStatus: " + Status;
        }
    }
}
