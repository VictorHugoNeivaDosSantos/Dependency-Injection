using Injeção.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Injeção.Model
{
    public class Pedido : IPedido
    {

        private IContext _context;

        public Pedido(IContext context)
        {
            _context = context;

        }
        public bool CadastrarPedido(PedidoModel pedido)
        {
            string sql =  $"{pedido.Nome} + {pedido.Id} + {pedido.Email}"; // Comando sql para inserção em DB.

            return _context.CadastrarPedido(sql);
        }
    }
}
