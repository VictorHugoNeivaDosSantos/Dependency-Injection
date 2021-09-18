using Injeção.Interface;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Injeção.ContextDB
{
    public class Context : IContext
    {

        string connectString = "";

        NpgsqlConnection Connection;

        public Context()
        {

          //   Connection = new NpgsqlConnection(connectString);
          //  Connection.Open();

          //Criação de conexão DB.
            
        }

        public Boolean CadastrarPedido(string sql)
        {
            try
            {
              // NpgsqlCommand command = new NpgsqlCommand(sql, Connection);
              //  command.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                return false;

            }
            


        }





    }



}
