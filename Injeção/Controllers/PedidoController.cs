using Injeção.Interface;
using Injeção.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Injeção.Controllers
{
    [ApiController]
    [Route("Injeção")]
    public class PedidoController : ControllerBase
    {
        private IPedido _pedido;

        public PedidoController(IPedido pedido)
        {
            _pedido = pedido;
        }

        //Efetuo a inserção de dependencia, atentar-se de que PedidoModel é diferente de Pedido;

        [HttpPost("Cadastrar-pedido")]
      
        public bool CadastrarPedido([FromBody] PedidoModel pedido)
        {
                     
           return _pedido.CadastrarPedido(pedido);
        }
    }
}
