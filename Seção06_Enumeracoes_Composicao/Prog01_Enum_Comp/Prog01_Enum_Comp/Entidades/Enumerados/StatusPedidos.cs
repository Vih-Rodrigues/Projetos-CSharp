// ENUMERAÇÃO - STATUS DO PEDIDO

namespace Prog01_Enum_Comp.Entidades.Enumerados
{
    enum StatusPedidos : int // ': int' especifica que cada valor da enumaração StatusPedidos será um número inteiro
    {
        PagamentoPendente = 0,
        Processando = 1,
        Enviado = 2,
        Entregue = 3
    }
}
