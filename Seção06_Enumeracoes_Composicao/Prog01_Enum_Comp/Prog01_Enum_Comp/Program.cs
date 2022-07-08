// PROGRAMA PRINCIPAL

using System;
using Prog01_Enum_Comp.Entidades;
using Prog01_Enum_Comp.Entidades.Enumerados;

namespace Prog01_Enum_Comp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                Id = 1080,
                InstantePedido = DateTime.Now,
                Status = StatusPedidos.PagamentoPendente
            };
            Console.WriteLine(pedido);

            // Convertendo um valor tipo enumarado para string
            string texto;
            texto = StatusPedidos.PagamentoPendente.ToString();
            Console.WriteLine("\n" + texto);

            // Convertendo um valor tipo string para enumerado
            StatusPedidos enumerado;
            enumerado = Enum.Parse<StatusPedidos>("Entregue");
            Console.WriteLine("\n" + enumerado);
        }
    }
}
