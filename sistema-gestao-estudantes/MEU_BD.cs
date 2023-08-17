using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace sistema_gestao_estudantes
{
    // a classe do nosso banco de dados
    internal class MEU_BD
    {
        // o "objeto" que representa a nossa conexão 
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=t4_sga_bd");

        public MySqlConnection getConexao
        {
            get
            {
                //aaaaa
                return conexao;
            }
        }

        public void abrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }

        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }

        }
    }

}
