using Biblioteca.Classes_Basicas;
using Biblioteca.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFabricaCosmeticos
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto p = new Produto();
                p.Nome = textBoxNome.Text;
                p.UnidadeFornecimento = textBoxUnidadeFornecimento.Text;
                p.Descricao = textBoxDescricao.Text;

                ProdutoNegocio dados = new ProdutoNegocio();
                dados.Insert(p);
                MessageBox.Show("Produto cadastrado com sucesso");

                textBoxNome.Clear();
                textBoxUnidadeFornecimento.Clear();
                textBoxDescricao.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
