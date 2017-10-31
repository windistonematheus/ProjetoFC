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
    public partial class FormConsultaProduto : Form
    {
        List<Produto> listaProduto = new List<Produto>();

        public FormConsultaProduto()
        {
            InitializeComponent();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {

            try
            {
                ProdutoNegocio dados = new ProdutoNegocio();
                Produto filtro = new Produto();

                if (textBoxId.Text.Trim().Equals("") == false)
                {
                    filtro.Id = Int32.Parse(textBoxId.Text.Trim());
                }
                filtro.Nome = textBoxNome.Text;
                listaProduto = dados.Select(filtro);

                listViewProduto.Items.Clear();
                foreach (Produto p in listaProduto)
                {
                    ListViewItem linha = listViewProduto.Items.Add(p.Id.ToString());
                    linha.SubItems.Add(p.Nome);
                    linha.SubItems.Add(p.UnidadeFornecimento);
                    linha.SubItems.Add(p.Descricao);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
