using Capitulo21.ExercicioExtra1.Modelos;
using Capitulo21.ExercicioExtra1.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo21.ExercicioExtra1
{
    /*
     Crie uma interface gráfica contendo os campos da tabela 'Produtos'
     do exercício 'Capitulo15-16-17.ExercicioExtra1' e no clique no botão salvar,
     salve o item no banco de dados.
     */
    public partial class FormProduto : Form
    {
        public ProdutoRepositorio repositorio = new ProdutoRepositorio();

        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            ObterProdutosEAdicionarNoGrid();
        }

        private void BotaoCadastrar_Click(object sender, EventArgs e)
        {
            var produtoParaAdicionar = new Produto();
            produtoParaAdicionar.Nome = CampoNome.Text;
            produtoParaAdicionar.Marca = CampoMarca.Text;
            produtoParaAdicionar.PrecoCompra = Convert.ToDouble(CampoPrecoCompra.Text.Replace(".", ","));
            produtoParaAdicionar.PrecoVenda = Convert.ToDouble(CampoPrecoVenda.Text.Replace(".", ","));

            var linhasAfetadas = repositorio.Adicionar(produtoParaAdicionar);

            if(linhasAfetadas > 0)
            {
                LimparCamposFormulario();
                ObterProdutosEAdicionarNoGrid();
                MessageBox.Show("Produto cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar produto!");
            }

        }

        private void ObterProdutosEAdicionarNoGrid()
        {
            var todosProdutos = repositorio.ObterTodos();

            foreach (var produto in todosProdutos)
            {
                GridProdutos.Rows.Add(
                    produto.Id,
                    produto.Nome,
                    produto.Marca,
                    produto.PrecoCompra,
                    produto.PrecoVenda
                    );
            }
        }

        private void LimparCamposFormulario()
        {
            CampoNome.Text = "";
            CampoMarca.Text = "";
            CampoPrecoCompra.Text = "";
            CampoPrecoVenda.Text = "";
        }
    }
}
