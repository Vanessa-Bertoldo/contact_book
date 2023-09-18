using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoAgenda

{
    public class Conexao
    {
        private static string conexao = "Data Source=DESKTOP-H7AI42F;Initial Catalog=agenda;Integrated Security=True";
        public static string stringConexao
        {
            get { return conexao; }
        }
    }
}
