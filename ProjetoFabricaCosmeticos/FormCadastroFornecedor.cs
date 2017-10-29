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
    public partial class FormCadastroFornecedor : Form
    {
        int operacao;
        public FormCadastroFornecedor()
        {
            InitializeComponent();
        }
        public FormCadastroFornecedor(Fornecedor f)
        {
            InitializeComponent();
            this.operacao = 0;
            buttonCadastraFornecedor.Text = "Cadastrar";
            this.Text = "Cadastro de Fornecedor";

        }

        private void buttonCadastraFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedor f = new Fornecedor();
                f.Cnpj = textBoxCnpj.Text;
                f.RazaoSocial = textBoxRazaoSocial.Text;
                f.Email = textBoxEmail.Text;
                f.Telefone = textBoxTelefone.Text;
                f.Cep = textBoxCep.Text;
                f.Logradouro = textBoxLogradouro.Text;
                f.Complemento = textBoxComplemento.Text;
                f.Bairro = textBoxBairro.Text;
                f.Cidade = textBoxCidade.Text;
                f.Estado = textBoxEstado.Text;

                FornecedorNegocio dados = new FornecedorNegocio();
                dados.Insert(f);
                textBoxCnpj.Clear();
                textBoxRazaoSocial.Clear();
                textBoxEmail.Clear();
                textBoxCep.Clear();
                textBoxTelefone.Clear();
                textBoxEstado.Clear();
                textBoxCidade.Clear();
                textBoxBairro.Clear();
                textBoxLogradouro.Clear();
                textBoxComplemento.Clear();
                
                MessageBox.Show("Fornecedor cadastrado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
