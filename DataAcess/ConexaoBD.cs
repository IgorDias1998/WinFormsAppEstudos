using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppEstudos.SecurityBanco;

namespace WinFormsAppEstudos.DataAcess
{
    public static class ConexaoBD
    {
        private static Password senha = new Password();

        private static string connectionString = $"datasource=localhost;username=root;password={senha.PasswordStorage()};database=Venda_Produto";

        public static MySqlConnection ObterConexao()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
