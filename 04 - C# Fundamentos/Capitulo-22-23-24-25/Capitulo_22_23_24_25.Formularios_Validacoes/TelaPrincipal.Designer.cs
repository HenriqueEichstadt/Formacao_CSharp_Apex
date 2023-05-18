namespace Capitulo_22_23_24_25.Formularios_Validacoes
{
    partial class TelaPrincipal
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
            BotaoCliqueAqui = new Button();
            CampoTexto = new TextBox();
            BotaoSalvar = new Button();
            CampoComboBox = new ComboBox();
            SuspendLayout();
            // 
            // BotaoCliqueAqui
            // 
            BotaoCliqueAqui.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            BotaoCliqueAqui.Location = new Point(409, 12);
            BotaoCliqueAqui.Name = "BotaoCliqueAqui";
            BotaoCliqueAqui.Size = new Size(379, 53);
            BotaoCliqueAqui.TabIndex = 0;
            BotaoCliqueAqui.Text = "Clica aqui por favor";
            BotaoCliqueAqui.UseVisualStyleBackColor = true;
            BotaoCliqueAqui.Click += BotaoCliqueAqui_Click;
            // 
            // CampoTexto
            // 
            CampoTexto.Location = new Point(25, 106);
            CampoTexto.Name = "CampoTexto";
            CampoTexto.Size = new Size(203, 27);
            CampoTexto.TabIndex = 1;
            // 
            // BotaoSalvar
            // 
            BotaoSalvar.Location = new Point(371, 365);
            BotaoSalvar.Name = "BotaoSalvar";
            BotaoSalvar.Size = new Size(94, 29);
            BotaoSalvar.TabIndex = 3;
            BotaoSalvar.Text = "Salvar";
            BotaoSalvar.UseVisualStyleBackColor = true;
            BotaoSalvar.Click += BotaoSalvar_Click;
            // 
            // CampoComboBox
            // 
            CampoComboBox.FormattingEnabled = true;
            CampoComboBox.Items.AddRange(new object[] { "Nenhum", "Masculino", "Feminino" });
            CampoComboBox.Location = new Point(27, 191);
            CampoComboBox.Name = "CampoComboBox";
            CampoComboBox.Size = new Size(201, 28);
            CampoComboBox.TabIndex = 4;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CampoComboBox);
            Controls.Add(BotaoSalvar);
            Controls.Add(CampoTexto);
            Controls.Add(BotaoCliqueAqui);
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotaoCliqueAqui;
        private TextBox CampoTexto;
        private Button BotaoSalvar;
        private ComboBox CampoComboBox;
    }
}