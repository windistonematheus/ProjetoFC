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
    public partial class FormConsultaFornecedor : Form
    {
        List<Fornecedor> listaFornecedor = new List<Fornecedor>();

        public FormConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void AlterarFornecedor()
        {
            try
            {
                if (listViewFornecedor.FocusedItem != null)
                {
                    int posicao = listViewFornecedor.FocusedItem.Index;
                    Fornecedor fornecedorSelecionado = this.listaFornecedor.ElementAt(posicao);
                    FormCadastroFornecedor form = new FormCadastroFornecedor(fornecedorSelecionado);
                    form.ShowDialog();                  
                }
                else
                {
                    MessageBox.Show(" Favor selecionar o Fornecedor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            try
            {
                FornecedorNegocio dados = new FornecedorNegocio();
                Fornecedor filtro = new Fornecedor();
                if (textBoxCnpj.Text.Trim().Equals("") == false)
                {
                    filtro.Cnpj = textBoxCnpj.Text.Trim();
                }
                filtro.RazaoSocial = textBoxRazaoSocial.Text;
                listaFornecedor = dados.Select(filtro);
                listViewFornecedor.Items.Clear();
                foreach (Fornecedor a in listaFornecedor)
                {
                    ListViewItem linha = listViewFornecedor.Items.Add(a.Id.ToString());
                    linha.SubItems.Add(a.Cnpj);
                    linha.SubItems.Add(a.RazaoSocial);
                    linha.SubItems.Add(a.Logradouro);
                    linha.SubItems.Add(a.Complemento);
                    linha.SubItems.Add(a.Bairro);
                    linha.SubItems.Add(a.Cidade);
                    linha.SubItems.Add(a.Estado);
                    linha.SubItems.Add(a.Cep);
                    linha.SubItems.Add(a.Email);
                    linha.SubItems.Add(a.Telefone);
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            AlterarFornecedor();
        }
        private void listViewsFornecedor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AlterarFornecedor();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFornecedor.FocusedItem != null)
                {
                    int posicao = listViewFornecedor.FocusedItem.Index;
                    Fornecedor fornecedorSelecionado = this.listaFornecedor.ElementAt(posicao);
                    FornecedorNegocio dados = new FornecedorNegocio();
                    dados.Delete(fornecedorSelecionado);
                    listViewFornecedor.Items.Clear();
                    MessageBox.Show("Fornecedor removido com sucesso");

                }
                else
                {
                    MessageBox.Show(" Favor selecionar o Fornecedor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
