using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema_gestao_estudantes
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //define a image da picture box via codigo
            pictureBox1.Image = Image.FromFile("../../images/user cat.gif");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            MEU_BD bancoDeDados = new MEU_BD();

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `usuarios` WHERE `username` = @usn AND `password` = @psd", bancoDeDados.getConexao); 

            comando.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtUsuario.Text;
            comando.Parameters.Add("@psd", MySqlDbType.VarChar).Value = txtSenha.Text;

            adaptador.SelectCommand = comando;
            adaptador.Fill(tabela);

            if (tabela.Rows.Count > 0)
            {
                MessageBox.Show("SIM");
            }
            else 
            {
                MessageBox.Show("Nome de usuário ou senha inválido", 
                    "Erro de login", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
