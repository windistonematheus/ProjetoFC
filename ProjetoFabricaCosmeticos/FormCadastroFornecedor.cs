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
        int filtro;

        public FormCadastroFornecedor()
        {
            InitializeComponent();
            this.operacao = 0;
            buttonCadastraFornecedor.Text = "Cadastrar";
            this.Text = "Cadastro de Fornecedor";
        }

        public FormCadastroFornecedor(Fornecedor f)
        {
            InitializeComponent();
            textBoxCnpj.Text = f.Cnpj;
            textBoxRazaoSocial.Text = f.RazaoSocial;
            textBoxEmail.Text = f.Email;
            textBoxTelefone.Text = f.Telefone;
            textBoxCep.Text = f.Cep;
            textBoxLogradouro.Text = f.Logradouro;
            textBoxComplemento.Text = f.Complemento;
            textBoxBairro.Text = f.Bairro;
            textBoxCidade.Text = f.Cidade;
            textBoxEstado.Text = f.Estado;
            this.filtro = f.Id;
            this.operacao = 1;
            buttonCadastraFornecedor.Text = "Atualizar";
            this.Text = "Atualização de Fornecedor";
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
                if (this.operacao == 0)
                {
                    dados.Insert(f);
                    MessageBox.Show("Fornecedor cadastrado com sucesso");
                }
                else
                {
                    f.Id = this.filtro;
                    dados.Update(f);
                    MessageBox.Show("Fornecedor alterado com sucesso");
                }

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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
