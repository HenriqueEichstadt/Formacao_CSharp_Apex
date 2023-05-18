using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo_22_23_24_25.Formularios_Validacoes
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void BotaoCliqueAqui_Click(object sender, EventArgs e)
        {
            var telaCadastro = new TelaCadastro();

            // não bloqueia a janela que abriu
            //telaCadastro.Show();

            // bloqueia a janela que abriu
            telaCadastro.ShowDialog();
        }

        private void BotaoValidarCampoTexto_Click(object sender, EventArgs e)
        {
            CampoTextoEhValido();

        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            if (CampoTextoEhValido() && CampoComboBoxEhValido())
            {
                // salvo o registro no banco
                MessageBox.Show("Salvo com sucesso");
            }
        }

        private bool CampoTextoEhValido()
        {
            // validando se é nulo ou string vazia
            if (string.IsNullOrEmpty(CampoTexto.Text))
            {
                MessageBox.Show("O campo de texto é obrigatório");
                return false;
            }
            // validando tamanho mínimo
            if (CampoTexto.Text.Length < 10)
            {
                MessageBox.Show("O campo de texto deve ter no mínino 10 caracteres");
                return false;
            }
            // validando tamanho máximo
            if (CampoTexto.Text.Length > 100)
            {
                MessageBox.Show("O campo de texto deve ter no máximo 100 caracteres");
                return false;
            }
            // não pode ter o caractere @
            if (CampoTexto.Text.Contains("@") || CampoTexto.Text.Contains("#"))
            {
                MessageBox.Show("O campo de texto não pode ter @ ou #");
                return false;
            }
            // quero somente texto, não pode ter números
            if (CampoTexto.Text.Any(char.IsDigit))
            {
                MessageBox.Show("O campo de texto não pode ter números");
                return false;
            }


            return true;
        }

        private bool CampoComboBoxEhValido()
        {
            if (CampoComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Item inválido");
                return false;
            }
            if (CampoComboBox.SelectedItem.ToString() == "Nenhum")
            {
                MessageBox.Show("Selecione um item");
                return false;
            }



            return true;
        }
    }
}
