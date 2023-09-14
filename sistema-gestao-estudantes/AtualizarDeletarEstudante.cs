using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestao_estudantes
{
    public partial class AtualizarDeletarEstudante : Form
    {
        //Cria uma instancia de um estudante
        Estudante estudante = new Estudante();
        public AtualizarDeletarEstudante()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArquivo = new OpenFileDialog();
            abrirArquivo.Filter =
                "Seleciona a foto(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(abrirArquivo.FileName);
            }
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            //Atualizar as informações do Estudante
            Estudante estudantes = new Estudante();
            int id = Convert.ToInt32(textBoxID.Text);
            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobrenome.Text;
            DateTime nascimento = dateTimePickerNascimento.Value;
            string telefone = textBoxTelefone.Text;
            string endereco = textBoxEndereco.Text;
            string genero = "Feminino";

            if (radioButtonMasculino.Checked)
            {
                genero = "Masculino";
            }
            MemoryStream foto = new MemoryStream();

            int anoDeNascimento = dateTimePickerNascimento.Value.Year;
            int anoAtual = DateTime.Now.Year;
            if ((anoAtual - anoDeNascimento) > 10 ||
                (anoAtual - anoDeNascimento) < 100)
            {
                MessageBox.Show("a idade precisa ser de 10 e 100 anos.",
                    "Idade inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verificar())
            {
                pictureBoxFoto.Image.Save(foto, pictureBoxFoto.Image.RawFormat);
                if (estudantes.atualizarestudante(id, nome, sobrenome, nascimento, telefone, genero, endereco, foto))
                {
                    MessageBox.Show("Informações atualizadas",
                    "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro", "Inserir Estudante",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Campos não preenchidos",
                    "Inserir Estudantes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verificar()
        {
            if ((textBoxNome.Text.Trim() == "") ||
               (textBoxSobrenome.Text.Trim() == "") ||
               (textBoxTelefone.Text.Trim() == "") ||
               (textBoxEndereco.Text.Trim() == "") ||
               (pictureBoxFoto.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            //Remove o studante selecionado
            int id = Convert.ToInt32(textBoxID.Text);

            //Exibe uma caixa de dialogo perguntando se realmente quer remover o estuante
            if (MessageBox.Show("Tem certeza que quer remover o estudante", "Remover Estudante", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (estudante.deletarEstudantes(id))
                {
                    // Parâmnetro: mensagem, titulo, 
                    MessageBox.Show("Estudante Removido", "Remover Estudante",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //limpa os campos de textos
                    textBoxID.Text = ""; //obs: dará errp se tentar apagar o mesmo estudante 2x
                    textBoxNome.Text = "";
                    textBoxSobrenome.Text = "";
                    textBoxTelefone.Text = "";
                    textBoxEndereco.Text = "";
                    dateTimePickerNascimento.Value = DateTime.Now;
                    pictureBoxFoto.Image = null;
                }
                else
                {
                    MessageBox.Show("Estudante não removido", "Remover Estudante", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            // Procura estudante pela ID.
            int Id = Convert.ToInt32(textBoxID.Text);
            MySqlCommand comando = new MySqlCommand("SELECT `Id`,`nome`,`sobrenome`,`nascimento`,`genero`,`telefone`,`endereco`,`foto` FROM `estudantes` WHERE `Id` =" + Id);

            DataTable tabela = estudante.pegarEstudantes(comando);

            if (tabela.Rows.Count > 0)
            {
                textBoxNome.Text = tabela.Rows[0]["nome"].ToString();
                textBoxSobrenome.Text = tabela.Rows[0]["sobrenome"].ToString();
                textBoxTelefone.Text = tabela.Rows[0]["telefone"].ToString();
                textBoxEndereco.Text = tabela.Rows[0]["endereco"].ToString();

                dateTimePickerNascimento.Value = (DateTime)tabela.Rows[0]["nascimento"];

                if (tabela.Rows[0]["genero"].ToString() == "Feminino")
                {
                    radioButtonFeminino.Checked = true;
                }
                else
                {
                    radioButtonMasculino.Checked = true;
                }

                // foto do estudante.
                byte[] fotoDaTabela = (byte[]) tabela.Rows[0]["foto"];
                MemoryStream fotoDaInterface = new MemoryStream(fotoDaTabela);
                pictureBoxFoto.Image = Image.FromStream(fotoDaInterface);
                
            }
        }
    }
}
