using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo21.Exercicio1
{
    /*
     1) Siga os seguintes passos:
        - Crie um novo projeto chamado “ExercicioCapTres”.
        - Crie um novo formulário chamado “Eventos”.
        Dentro desse formulário:
            - Adicione um componente TextBox referente ao nome do usuário.
            - Adicione um componente ComboBox referente ao sexo do usuário.
            - Adicione um componente Button referente ao envio da informação.

        - Implemente no evento Load do formulário um aviso de “Bem Vindo” com um MessageBox
            personalizado.
        - Implemente o evento TextChanged do TextBox fazendo com que se o texto digitado tiver mais de 15
            caracteres exiba uma mensagem “Nome muito grande, favor abreviar. ”.
        - Implemente o evento SelectedIndexChanged do ComboBox fazendo com que se o index selecionado for
        - Masculino o texto do TextBox torne-se inteiro Maiúsculo, caso contrário, minúsculo.
     
     */
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
        }

        private void Eventos_Load(object sender, EventArgs e)
        {

        }
    }
}
