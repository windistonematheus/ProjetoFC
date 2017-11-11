using ProjetoFabricaCosmeticos.localhost;
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
    public partial class FormConsultaFormula : Form
    {
        List<Produto> listaProduto = new List<Produto>();

        public FormConsultaFormula()
        {
            InitializeComponent();
            ListarProdutoCombo();
        }

        private void ListarProdutoCombo()
        {
            try
            {
                Service1 dados = new Service1();
                Produto filtro = new Produto();
                filtro.Descricao = "";
                filtro.Nome = "";
                listaProduto = dados.SelectProduto(filtro).ToList();
                comboBoxProduto.Items.Clear();
                foreach (Produto p in listaProduto)
                {
                    comboBoxProduto.Items.Add(p.Nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {

        }
    }
}
