using System;
using System.Collections.Generic;
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
            return false;
        }
    }
}
