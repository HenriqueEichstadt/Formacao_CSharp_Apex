namespace Capitulo18_19_20_21.WindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxNome = new TextBox();
            label2 = new Label();
            buttonSalvar = new Button();
            Painel = new Panel();
            label3 = new Label();
            buttonMostrarEsconderPainel = new Button();
            CampoNumeroUpDown = new NumericUpDown();
            BotaoImprimirNumero = new Button();
            CampoDateTime = new DateTimePicker();
            BotaoImprimirData = new Button();
            ComboBoxMarca = new ComboBox();
            GridViewPessoas = new DataGridView();
            ColunaId = new DataGridViewTextBoxColumn();
            ColunaNome = new DataGridViewTextBoxColumn();
            Painel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CampoNumeroUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridViewPessoas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(274, 7);
            label1.Name = "label1";
            label1.Size = new Size(156, 37);
            label1.TabIndex = 0;
            label1.Text = "Meu Sistema";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(27, 76);
            textBoxNome.Margin = new Padding(3, 2, 3, 2);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(126, 23);
            textBoxNome.TabIndex = 1;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 59);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome do usuário";
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(27, 101);
            buttonSalvar.Margin = new Padding(3, 2, 3, 2);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.RightToLeft = RightToLeft.No;
            buttonSalvar.Size = new Size(126, 28);
            buttonSalvar.TabIndex = 3;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // Painel
            // 
            Painel.Controls.Add(label3);
            Painel.Location = new Point(187, 59);
            Painel.Margin = new Padding(3, 2, 3, 2);
            Painel.Name = "Painel";
            Painel.Size = new Size(108, 54);
            Painel.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 10);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // buttonMostrarEsconderPainel
            // 
            buttonMostrarEsconderPainel.Location = new Point(186, 117);
            buttonMostrarEsconderPainel.Name = "buttonMostrarEsconderPainel";
            buttonMostrarEsconderPainel.Size = new Size(109, 23);
            buttonMostrarEsconderPainel.TabIndex = 5;
            buttonMostrarEsconderPainel.Text = "Mostrar/Esconder";
            buttonMostrarEsconderPainel.UseVisualStyleBackColor = true;
            buttonMostrarEsconderPainel.Click += buttonMostrarEsconderPainel_Click;
            // 
            // CampoNumeroUpDown
            // 
            CampoNumeroUpDown.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            CampoNumeroUpDown.Location = new Point(310, 57);
            CampoNumeroUpDown.Name = "CampoNumeroUpDown";
            CampoNumeroUpDown.Size = new Size(120, 23);
            CampoNumeroUpDown.TabIndex = 6;
            // 
            // BotaoImprimirNumero
            // 
            BotaoImprimirNumero.Location = new Point(328, 86);
            BotaoImprimirNumero.Name = "BotaoImprimirNumero";
            BotaoImprimirNumero.Size = new Size(75, 23);
            BotaoImprimirNumero.TabIndex = 7;
            BotaoImprimirNumero.Text = "Imprimir";
            BotaoImprimirNumero.UseVisualStyleBackColor = true;
            BotaoImprimirNumero.Click += BotaoImprimirNumero_Click;
            // 
            // CampoDateTime
            // 
            CampoDateTime.Location = new Point(27, 160);
            CampoDateTime.Name = "CampoDateTime";
            CampoDateTime.Size = new Size(200, 23);
            CampoDateTime.TabIndex = 8;
            // 
            // BotaoImprimirData
            // 
            BotaoImprimirData.Location = new Point(68, 189);
            BotaoImprimirData.Name = "BotaoImprimirData";
            BotaoImprimirData.Size = new Size(116, 23);
            BotaoImprimirData.TabIndex = 9;
            BotaoImprimirData.Text = "Imprimir Data";
            BotaoImprimirData.UseVisualStyleBackColor = true;
            BotaoImprimirData.Click += BotaoImprimirData_Click;
            // 
            // ComboBoxMarca
            // 
            ComboBoxMarca.FormattingEnabled = true;
            ComboBoxMarca.Items.AddRange(new object[] { "Chevrolet", "Volkswagen", "Ford", "Jeep" });
            ComboBoxMarca.Location = new Point(309, 160);
            ComboBoxMarca.Name = "ComboBoxMarca";
            ComboBoxMarca.Size = new Size(121, 23);
            ComboBoxMarca.TabIndex = 10;
            // 
            // GridViewPessoas
            // 
            GridViewPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewPessoas.Columns.AddRange(new DataGridViewColumn[] { ColunaId, ColunaNome });
            GridViewPessoas.Location = new Point(448, 160);
            GridViewPessoas.Name = "GridViewPessoas";
            GridViewPessoas.RowTemplate.Height = 25;
            GridViewPessoas.Size = new Size(240, 150);
            GridViewPessoas.TabIndex = 11;
            // 
            // ColunaId
            // 
            ColunaId.HeaderText = "Id";
            ColunaId.Name = "ColunaId";
            // 
            // ColunaNome
            // 
            ColunaNome.HeaderText = "Nome";
            ColunaNome.Name = "ColunaNome";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(GridViewPessoas);
            Controls.Add(ComboBoxMarca);
            Controls.Add(BotaoImprimirData);
            Controls.Add(CampoDateTime);
            Controls.Add(BotaoImprimirNumero);
            Controls.Add(CampoNumeroUpDown);
            Controls.Add(buttonMostrarEsconderPainel);
            Controls.Add(Painel);
            Controls.Add(buttonSalvar);
            Controls.Add(label2);
            Controls.Add(textBoxNome);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Painel.ResumeLayout(false);
            Painel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CampoNumeroUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridViewPessoas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNome;
        private Label label2;
        private Button buttonSalvar;
        private Panel Painel;
        private Label label3;
        private Button buttonMostrarEsconderPainel;
        private NumericUpDown CampoNumeroUpDown;
        private Button BotaoImprimirNumero;
        private DateTimePicker CampoDateTime;
        private Button BotaoImprimirData;
        private ComboBox ComboBoxMarca;
        private DataGridView GridViewPessoas;
        private DataGridViewTextBoxColumn ColunaId;
        private DataGridViewTextBoxColumn ColunaNome;
    }
}