namespace ProjetoFabricaCosmeticos
{
    partial class FormConsultaFormula
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
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewMateriaPrima = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(75, 42);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(398, 21);
            this.comboBoxProduto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto";
            // 
            // listViewMateriaPrima
            // 
            this.listViewMateriaPrima.Location = new System.Drawing.Point(63, 112);
            this.listViewMateriaPrima.Name = "listViewMateriaPrima";
            this.listViewMateriaPrima.Size = new System.Drawing.Size(121, 97);
            this.listViewMateriaPrima.TabIndex = 2;
            this.listViewMateriaPrima.UseCompatibleStateImageBehavior = false;
            // 
            // FormConsultaFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 261);
            this.Controls.Add(this.listViewMateriaPrima);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxProduto);
            this.Name = "FormConsultaFormula";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewMateriaPrima;
    }
}