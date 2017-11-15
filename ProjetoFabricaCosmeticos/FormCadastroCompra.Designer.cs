namespace ProjetoFabricaCosmeticos
{
    partial class FormCadastroCompra
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.comboBoxMateriaPrima = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLote = new System.Windows.Forms.TextBox();
            this.textBoxValidade = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.listBoxCompra = new System.Windows.Forms.ListBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornecedor";
            // 
            // comboBoxFornecedor
            // 
            this.comboBoxFornecedor.FormattingEnabled = true;
            this.comboBoxFornecedor.Location = new System.Drawing.Point(100, 9);
            this.comboBoxFornecedor.Name = "comboBoxFornecedor";
            this.comboBoxFornecedor.Size = new System.Drawing.Size(242, 21);
            this.comboBoxFornecedor.TabIndex = 1;
            // 
            // comboBoxMateriaPrima
            // 
            this.comboBoxMateriaPrima.FormattingEnabled = true;
            this.comboBoxMateriaPrima.Location = new System.Drawing.Point(100, 37);
            this.comboBoxMateriaPrima.Name = "comboBoxMateriaPrima";
            this.comboBoxMateriaPrima.Size = new System.Drawing.Size(242, 21);
            this.comboBoxMateriaPrima.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Materia Prima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lote";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Validade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantidade";
            // 
            // textBoxLote
            // 
            this.textBoxLote.Location = new System.Drawing.Point(100, 65);
            this.textBoxLote.Name = "textBoxLote";
            this.textBoxLote.Size = new System.Drawing.Size(140, 20);
            this.textBoxLote.TabIndex = 7;
            // 
            // textBoxValidade
            // 
            this.textBoxValidade.Location = new System.Drawing.Point(100, 94);
            this.textBoxValidade.Name = "textBoxValidade";
            this.textBoxValidade.Size = new System.Drawing.Size(140, 20);
            this.textBoxValidade.TabIndex = 8;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(100, 123);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(140, 20);
            this.textBoxQuantidade.TabIndex = 9;
            // 
            // listBoxCompra
            // 
            this.listBoxCompra.FormattingEnabled = true;
            this.listBoxCompra.Location = new System.Drawing.Point(100, 149);
            this.listBoxCompra.Name = "listBoxCompra";
            this.listBoxCompra.Size = new System.Drawing.Size(413, 134);
            this.listBoxCompra.TabIndex = 10;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(26, 294);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 11;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(172, 294);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 12;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(338, 294);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 13;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            // 
            // FormCadastroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 345);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.listBoxCompra);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.textBoxValidade);
            this.Controls.Add(this.textBoxLote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMateriaPrima);
            this.Controls.Add(this.comboBoxFornecedor);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroCompra";
            this.Text = "FormCadastroCompra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFornecedor;
        private System.Windows.Forms.ComboBox comboBoxMateriaPrima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLote;
        private System.Windows.Forms.TextBox textBoxValidade;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.ListBox listBoxCompra;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonRemover;
    }
}