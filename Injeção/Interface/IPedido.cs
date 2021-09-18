using Injeção.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Injeção.Interface
{
    public interface IPedido
    {

        Boolean CadastrarPedido(PedidoModel pedido);

    }
}
