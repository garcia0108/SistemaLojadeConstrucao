using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLojadeConstrucao
{
    public class Conexao //Classe para realizar a conexão com o Banco de Dados
    {  
        private static string cenexao = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=Construcao;Integrated Security=true";
        public static string stringConexao
        {
            get { return cenexao; } 
        }
    }
}
