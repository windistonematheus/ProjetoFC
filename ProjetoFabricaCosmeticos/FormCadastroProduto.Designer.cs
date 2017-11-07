namespace ProjetoFabricaCosmeticos
{
    partial class FormCadastroProduto
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxUnidadeFornecimento = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdicionarMateria = new System.Windows.Forms.Button();
            this.listViewMateria = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonRemoverMateria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(150, 12);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(333, 20);
            this.textBoxNome.TabIndex = 0;
            // 
            // textBoxUnidadeFornecimento
            // 
            this.textBoxUnidadeFornecimento.Location = new System.Drawing.Point(150, 44);
            this.textBoxUnidadeFornecimento.Name = "textBoxUnidadeFornecimento";
            this.textBoxUnidadeFornecimento.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnidadeFornecimento.TabIndex = 1;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(150, 79);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(333, 20);
            this.textBoxDescricao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unidade de Fornecimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição:";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(224, 315);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Location = new System.Drawing.Point(150, 115);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(266, 21);
            this.comboBoxMateria.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Matéria Prima:";
            // 
            // buttonAdicionarMateria
            // 
            this.buttonAdicionarMateria.Location = new System.Drawing.Point(422, 113);
            this.buttonAdicionarMateria.Name = "buttonAdicionarMateria";
            this.buttonAdicionarMateria.Size = new System.Drawing.Size(61, 23);
            this.buttonAdicionarMateria.TabIndex = 10;
            this.buttonAdicionarMateria.Text = "Add";
            this.buttonAdicionarMateria.UseVisualStyleBackColor = true;
            // 
            // listViewMateria
            // 
            this.listViewMateria.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewMateria.FullRowSelect = true;
            this.listViewMateria.Location = new System.Drawing.Point(150, 155);
            this.listViewMateria.Name = "listViewMateria";
            this.listViewMateria.Size = new System.Drawing.Size(333, 97);
            this.listViewMateria.TabIndex = 11;
            this.listViewMateria.UseCompatibleStateImageBehavior = false;
            this.listViewMateria.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Matéria Prima";
            this.columnHeader1.Width = 289;
            // 
            // buttonRemoverMateria
            // 
            this.buttonRemoverMateria.Location = new System.Drawing.Point(150, 258);
            this.buttonRemoverMateria.Name = "buttonRemoverMateria";
            this.buttonRemoverMateria.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoverMateria.TabIndex = 12;
            this.buttonRemoverMateria.Text = "Remover";
            this.buttonRemoverMateria.UseVisualStyleBackColor = true;
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 350);
            this.Controls.Add(this.buttonRemoverMateria);
            this.Controls.Add(this.listViewMateria);
            this.Controls.Add(this.buttonAdicionarMateria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxMateria);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textBoxUnidadeFornecimento);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxUnidadeFornecimento;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdicionarMateria;
        private System.Windows.Forms.ListView listViewMateria;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonRemoverMateria;
    }
}