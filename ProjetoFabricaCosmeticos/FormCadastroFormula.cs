using Biblioteca.DAO;
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
    public partial class FormCadastroFormula : Form
    {
        List<MateriaPrima> listaComboMateria = new List<MateriaPrima>();
        List<MateriaPrima> listaMateria = new List<MateriaPrima>();
        List<Produto> listaProduto = new List<Produto>();

        public FormCadastroFormula()
        {
            InitializeComponent();
            ListarProdutoCombo();
            ListarMateriaCombo();
        }

        private void ListarMateria()
        {
            listViewMateriaPrima.Items.Clear();
            foreach (MateriaPrima materia in this.listaMateria)
            {
                ListViewItem item = listViewMateriaPrima.Items.Add(materia.Nome);
            }
        }

        private void ListarProdutoCombo()
        {
            try
            {
                ProdutoNegocio dados = new ProdutoNegocio();
                Produto filtro = new Produto();
                listaProduto = dados.Select(filtro);
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

        private void ListarMateriaCombo()
        {
            try
            {
                MateriaPrimaNegocio dados = new MateriaPrimaNegocio();
                MateriaPrima filtro = new MateriaPrima();
                listaComboMateria = dados.Select(filtro);
                comboBoxMateriaPrima.Items.Clear();
                foreach (MateriaPrima m in listaComboMateria)
                {
                    comboBoxMateriaPrima.Items.Add(m.Nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = comboBoxProduto.SelectedIndex;
                if (index < 0)
                {
                    MessageBox.Show("Selecionar o produto");
                    comboBoxProduto.Focus();
                    return;
                }

                Produto p = listaProduto.ElementAt(index);
                p.MateriaPrima = listaMateria;

                FormulaDados dados = new FormulaDados();
                dados.CadastrarFormula(p);
                MessageBox.Show("Formula cadastrada com sucesso");

                this.listaMateria = new List<MateriaPrima>();
                comboBoxProduto.SelectedIndex = -1;
                comboBoxMateriaPrima.SelectedIndex = -1;

                ListarMateria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void buttonAdicionarMateriaPrima_Click(object sender, EventArgs e)
        {
            MateriaPrima ma = new MateriaPrima();
            int index = comboBoxMateriaPrima.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Selecionar a matéria prima");
                comboBoxMateriaPrima.Focus();
                return;
            }
            ma = listaComboMateria.ElementAt(index);
            this.listaMateria.Add(ma);
            ListarMateria();
            comboBoxMateriaPrima.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewMateriaPrima.FocusedItem != null)
            {
                int index = listViewMateriaPrima.FocusedItem.Index;
                this.listaMateria.RemoveAt(index);
                this.ListarMateria();
            }
        }
    }
}
