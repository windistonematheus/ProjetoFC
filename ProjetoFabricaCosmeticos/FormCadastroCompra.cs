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
    public partial class FormCadastroCompra : Form
    {
        List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        List<MateriaPrima> listaMateriaPrima = new List<MateriaPrima>();
        List<MateriaPrima> listaComboMateriaPrima = new List<MateriaPrima>();


        public FormCadastroCompra()
        {
            InitializeComponent();
            ListarFornecedorCombo();
            ListarMateriaCombo();

        }

        private void ListarFornecedorCombo()
        {
            try
            {
                Service1 dados = new Service1();
                Fornecedor filtro = new Fornecedor();
                listaFornecedor = dados.SelectFornecedor(filtro).ToList();
                comboBoxFornecedor.Items.Clear();
                foreach (Fornecedor f in listaFornecedor)
                {
                    comboBoxFornecedor.Items.Add(f.razaoSocial);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarMateriaCombo()
        {
            try
            {
                Service1 dados = new Service1();
                MateriaPrima filtro = new MateriaPrima();
                listaMateriaPrima = dados.SelectMateriaPrima(filtro).ToList();
                comboBoxMateriaPrima.Items.Clear();
                foreach (MateriaPrima m in listaMateriaPrima)
                {
                    comboBoxMateriaPrima.Items.Add(m.nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            int indexFornecedor = comboBoxFornecedor.SelectedIndex;
            if (indexFornecedor < 0)
            {
                MessageBox.Show("Selecionar o produto");
                comboBoxFornecedor.Focus();
                return;
            }

            int indexMateriaPrima = comboBoxMateriaPrima.SelectedIndex;
            if (indexMateriaPrima < 0)
            {
                MessageBox.Show("Selecionar a matéria prima");
                comboBoxMateriaPrima.Focus();
                return;
            }
            Compra compra = new Compra();
            compra.fornecedor = listaFornecedor.ElementAt(indexFornecedor);
            compra.materiaPrima = listaMateriaPrima.ElementAt(indexMateriaPrima);
            compra.preco = Convert.ToDouble(textBoxPreco.Text);
            compra.quantidade = Convert.ToInt32(textBoxQuantidade.Text);

            Service1 dados = new Service1();

            dados.InsertCompra(compra);
            MessageBox.Show("Compra cadastrada com sucesso");

            comboBoxFornecedor.SelectedIndex = -1;
            comboBoxMateriaPrima.SelectedIndex = -1;
            textBoxPreco.Clear();
            textBoxQuantidade.Clear();
        }
    }
}
