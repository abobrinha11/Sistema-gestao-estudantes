using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace sistema_gestao_estudantes
{
    internal class Estudante
    {
        MEU_BD bancodedados = new MEU_BD();
        
        //funcao que inclui o estudante no banco de dados.
        public bool inserirestudante(string nome, string sobrenome, DateTime nascimento, 
        string telefone, string genero, string endereco, MemoryStream foto)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO `estudantes`(`nome`, `sobrenome`, `nascimento`, `genero`, `telefone`, `endereco`, `foto`) VALUES (@nm,@sbn,@ns,@gen,@tel,@end,@fot)",bancodedados.getConexao);
            
            comando.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@sbn", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@ns", MySqlDbType.Date).Value = nascimento;
            comando.Parameters.Add("@gen", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@tel", MySqlDbType.VarChar).Value = telefone;
            comando.Parameters.Add("@end", MySqlDbType.VarChar).Value = endereco;
            comando.Parameters.Add("@fot", MySqlDbType.LongBlob).Value = foto.ToArray();

            bancodedados.abrirConexao();

            if (comando.ExecuteNonQuery() == 1)
            {
                bancodedados.fecharConexao();
                return true;
            }
            else
            {
                bancodedados.fecharConexao();
                return false;
            }
    
        }

        public bool atualizarestudante(int id, string nome, string sobrenome, DateTime nascimento,
        string telefone, string genero, string endereco, MemoryStream foto)
        {
            MySqlCommand comando = new MySqlCommand("UPDATE `estudantes` SET `nome`= @nm,`sobrenome`= @sbn,`nascimento`= @nsc,`genero`= @gen,`telefone`= @tel,`endereco`= @end,`foto`= @ft WHERE `id` = @id", bancodedados.getConexao);

            comando.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            comando.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@sbn", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@ns", MySqlDbType.Date).Value = nascimento;
            comando.Parameters.Add("@gen", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@tel", MySqlDbType.VarChar).Value = telefone;
            comando.Parameters.Add("@end", MySqlDbType.VarChar).Value = endereco;
            comando.Parameters.Add("@fot", MySqlDbType.LongBlob).Value = foto.ToArray();

            bancodedados.abrirConexao();

            if (comando.ExecuteNonQuery() == 1)
            {
                bancodedados.fecharConexao();
                return true;
            }
            else
            {
                bancodedados.fecharConexao();
                return false;
            }

        }
        // deletar o estudante
        public bool deletarEstudantes(int id)
        {
            MySqlCommand comando = new MySqlCommand("DELETE FROM `estudantes` WHERE `Id` = @studentid");
            comando.Parameters.Add("@studentsid", MySqlDbType.Int32).Value = id;

            bancodedados.abrirConexao();

            if (comando.ExecuteNonQuery() == 1)
            {
                bancodedados.fecharConexao();
                return true;
            }
            else
            {
                bancodedados.fecharConexao();
                return false;
            }
        }

        public DataTable pegarEstudantes(MySqlCommand comando)
        {
            comando.Connection = bancodedados.getConexao;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);

            return tabela;
        }
    }
}
