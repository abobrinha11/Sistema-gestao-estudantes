using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestao_estudantes
{
    public partial class formInserirEstudante : Form
    {
        public formInserirEstudante()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArquivo= new OpenFileDialog();
            abrirArquivo.Filter =
                "Seleciona a foto(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(abrirArquivo.FileName);
            }        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Estudante estudantes = new Estudante();
            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobrenome.Text;
            DateTime nascimento = dateTimePickerNascimento.Value;
            string telefone = textBoxTelefone.Text;
            string endereo = textBoxEndereco.Text;
            string genero = "Feminino";

            if (radioButtonMasculino.Checked)
            {
                genero = "Masculino";
            }
            MemoryStream foto = new MemoryStream();

            int anoDeNascimento = dateTimePickerNascimento.Value.Year;
            int  anoAtual = DateTime.Now.Year;
            if ((anoAtual - anoDeNascimento) < 10 ||
                (anoAtual - anoDeNascimento) < 100)
            {
                MessageBox.Show("a idade precisa ser de 10 e 100 anos.",
                    "Idade inválida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verificar())
            {
                
            }
        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {

        }

        bool verificar()
        {
            if ((textBoxNome.Text.Trim() == "")||
               (textBoxSobrenome.Text.Trim() =="") ||
               (textBoxTelefone.Text.Trim() =="") ||
               (textBoxEndereco.Text.Trim() =="") ||
               (pictureBoxFoto.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
