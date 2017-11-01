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
        int operacao;
        int filtro;

        public FormCadastroProduto()
        {
            InitializeComponent();
            this.operacao = 0;
            buttonCadastrar.Text = "Cadastrar";
            this.Text = "Cadastro de Produto";
        }

        public FormCadastroProduto(Produto p)
        {
            InitializeComponent();
            textBoxNome.Text = p.Nome;
            textBoxUnidadeFornecimento.Text = p.UnidadeFornecimento;
            textBoxDescricao.Text = p.Descricao;
            this.filtro = p.Id;
            this.operacao = 1;
            buttonCadastrar.Text = "Atualizar";
            this.Text = "Atualização de Produto";
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
                if (this.operacao == 0)
                {
                    dados.Insert(p);
                    MessageBox.Show("Produto cadastrado com sucesso");
                }
                else
                {
                    p.Id = this.filtro;
                    dados.Update(p);
                    MessageBox.Show("Produto alterado com sucesso");
                }
                 
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
