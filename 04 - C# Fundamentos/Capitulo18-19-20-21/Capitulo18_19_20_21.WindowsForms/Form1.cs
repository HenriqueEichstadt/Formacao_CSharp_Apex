namespace Capitulo18_19_20_21.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridViewPessoas.Rows.Add("1", "João");
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text;
            MessageBox.Show("O nome é: " + nome);
            textBoxNome.Clear();
        }

        private void buttonMostrarEsconderPainel_Click(object sender, EventArgs e)
        {
            var estaAparecendo = Painel.Visible;

            if (estaAparecendo)
            {
                Painel.Visible = false;
            }
            else
            {
                Painel.Visible = true;
            }
        }

        private void BotaoImprimirNumero_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Valor do campo é: {CampoNumeroUpDown.Value}");
        }

        private void BotaoImprimirData_Click(object sender, EventArgs e)
        {
            var dataFormatada = CampoDateTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
            MessageBox.Show($"Valor do campo é: {dataFormatada}");

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}