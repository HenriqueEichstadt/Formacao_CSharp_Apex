namespace Capitulo21.ExercicioExtra1
{
    partial class FormProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlProduto = new TabControl();
            TabPageListagem = new TabPage();
            label1 = new Label();
            GridProdutos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            PrecoCompra = new DataGridViewTextBoxColumn();
            PrecoVenda = new DataGridViewTextBoxColumn();
            TabPageLCadastro = new TabPage();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BotaoCadastrar = new Button();
            CampoNome = new TextBox();
            CampoMarca = new TextBox();
            CampoPrecoCompra = new TextBox();
            CampoPrecoVenda = new TextBox();
            tabControlProduto.SuspendLayout();
            TabPageListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridProdutos).BeginInit();
            TabPageLCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlProduto
            // 
            tabControlProduto.Controls.Add(TabPageListagem);
            tabControlProduto.Controls.Add(TabPageLCadastro);
            tabControlProduto.Location = new Point(1, 1);
            tabControlProduto.Margin = new Padding(3, 2, 3, 2);
            tabControlProduto.Name = "tabControlProduto";
            tabControlProduto.SelectedIndex = 0;
            tabControlProduto.Size = new Size(699, 328);
            tabControlProduto.TabIndex = 0;
            // 
            // TabPageListagem
            // 
            TabPageListagem.Controls.Add(label1);
            TabPageListagem.Controls.Add(GridProdutos);
            TabPageListagem.Location = new Point(4, 24);
            TabPageListagem.Margin = new Padding(3, 2, 3, 2);
            TabPageListagem.Name = "TabPageListagem";
            TabPageListagem.Padding = new Padding(3, 2, 3, 2);
            TabPageListagem.Size = new Size(691, 300);
            TabPageListagem.TabIndex = 0;
            TabPageListagem.Text = "Listagem";
            TabPageListagem.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(155, 9);
            label1.Name = "label1";
            label1.Size = new Size(349, 32);
            label1.TabIndex = 1;
            label1.Text = "Listagem de Produtos";
            // 
            // GridProdutos
            // 
            GridProdutos.AllowUserToAddRows = false;
            GridProdutos.AllowUserToDeleteRows = false;
            GridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridProdutos.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Marca, PrecoCompra, PrecoVenda });
            GridProdutos.Location = new Point(49, 40);
            GridProdutos.Margin = new Padding(3, 2, 3, 2);
            GridProdutos.Name = "GridProdutos";
            GridProdutos.ReadOnly = true;
            GridProdutos.RowHeadersWidth = 51;
            GridProdutos.RowTemplate.Height = 29;
            GridProdutos.Size = new Size(594, 261);
            GridProdutos.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 125;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.Width = 125;
            // 
            // PrecoCompra
            // 
            PrecoCompra.HeaderText = "PrecoCompra";
            PrecoCompra.MinimumWidth = 6;
            PrecoCompra.Name = "PrecoCompra";
            PrecoCompra.ReadOnly = true;
            PrecoCompra.Width = 125;
            // 
            // PrecoVenda
            // 
            PrecoVenda.HeaderText = "PrecoVenda";
            PrecoVenda.MinimumWidth = 6;
            PrecoVenda.Name = "PrecoVenda";
            PrecoVenda.ReadOnly = true;
            PrecoVenda.Width = 125;
            // 
            // TabPageLCadastro
            // 
            TabPageLCadastro.Controls.Add(CampoPrecoVenda);
            TabPageLCadastro.Controls.Add(CampoPrecoCompra);
            TabPageLCadastro.Controls.Add(CampoMarca);
            TabPageLCadastro.Controls.Add(CampoNome);
            TabPageLCadastro.Controls.Add(BotaoCadastrar);
            TabPageLCadastro.Controls.Add(label6);
            TabPageLCadastro.Controls.Add(label5);
            TabPageLCadastro.Controls.Add(label4);
            TabPageLCadastro.Controls.Add(label3);
            TabPageLCadastro.Controls.Add(label2);
            TabPageLCadastro.Location = new Point(4, 24);
            TabPageLCadastro.Margin = new Padding(3, 2, 3, 2);
            TabPageLCadastro.Name = "TabPageLCadastro";
            TabPageLCadastro.Padding = new Padding(3, 2, 3, 2);
            TabPageLCadastro.Size = new Size(691, 300);
            TabPageLCadastro.TabIndex = 1;
            TabPageLCadastro.Text = "Cadastro";
            TabPageLCadastro.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(153, 14);
            label2.Name = "label2";
            label2.Size = new Size(369, 32);
            label2.TabIndex = 2;
            label2.Text = "Cadastro de Produtos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(100, 76);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 3;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(371, 76);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 4;
            label4.Text = "Marca";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(100, 152);
            label5.Name = "label5";
            label5.Size = new Size(127, 21);
            label5.TabIndex = 5;
            label5.Text = "Preço de compra";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(371, 152);
            label6.Name = "label6";
            label6.Size = new Size(116, 21);
            label6.TabIndex = 6;
            label6.Text = "Preço de venda";
            // 
            // BotaoCadastrar
            // 
            BotaoCadastrar.Location = new Point(273, 242);
            BotaoCadastrar.Name = "BotaoCadastrar";
            BotaoCadastrar.Size = new Size(124, 39);
            BotaoCadastrar.TabIndex = 7;
            BotaoCadastrar.Text = "Cadastrar";
            BotaoCadastrar.UseVisualStyleBackColor = true;
            BotaoCadastrar.Click += BotaoCadastrar_Click;
            // 
            // CampoNome
            // 
            CampoNome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CampoNome.Location = new Point(100, 100);
            CampoNome.Name = "CampoNome";
            CampoNome.Size = new Size(200, 34);
            CampoNome.TabIndex = 8;
            // 
            // CampoMarca
            // 
            CampoMarca.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CampoMarca.Location = new Point(371, 100);
            CampoMarca.Name = "CampoMarca";
            CampoMarca.Size = new Size(200, 34);
            CampoMarca.TabIndex = 9;
            // 
            // CampoPrecoCompra
            // 
            CampoPrecoCompra.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CampoPrecoCompra.Location = new Point(100, 176);
            CampoPrecoCompra.Name = "CampoPrecoCompra";
            CampoPrecoCompra.Size = new Size(200, 34);
            CampoPrecoCompra.TabIndex = 10;
            // 
            // CampoPrecoVenda
            // 
            CampoPrecoVenda.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CampoPrecoVenda.Location = new Point(371, 176);
            CampoPrecoVenda.Name = "CampoPrecoVenda";
            CampoPrecoVenda.Size = new Size(200, 34);
            CampoPrecoVenda.TabIndex = 11;
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(tabControlProduto);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormProduto";
            Text = "Produto";
            Load += FormProduto_Load;
            tabControlProduto.ResumeLayout(false);
            TabPageListagem.ResumeLayout(false);
            TabPageListagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridProdutos).EndInit();
            TabPageLCadastro.ResumeLayout(false);
            TabPageLCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlProduto;
        private TabPage TabPageListagem;
        private Label label1;
        private DataGridView GridProdutos;
        private TabPage TabPageLCadastro;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn PrecoCompra;
        private DataGridViewTextBoxColumn PrecoVenda;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox CampoPrecoVenda;
        private TextBox CampoPrecoCompra;
        private TextBox CampoMarca;
        private TextBox CampoNome;
        private Button BotaoCadastrar;
        private Label label6;
        private Label label5;
    }
}