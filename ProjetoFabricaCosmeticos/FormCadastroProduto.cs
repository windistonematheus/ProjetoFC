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
        List<MateriaPrima> listaComboMateria = new List<MateriaPrima>();
        List<MateriaPrima> listaMateria = new List<MateriaPrima>();
        int operacao;
        int filtro;

        public FormCadastroProduto()
        {
            InitializeComponent();
            this.operacao = 0;
            buttonCadastrar.Text = "Cadastrar";
            this.Text = "Cadastro de Produto";
            ListarMateriaCombo();
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
            ListarMateriaCombo();
        }

        private void ListarMateria()
        {
            listViewMateria.Items.Clear();
            foreach (MateriaPrima materia in this.listaMateria)
            {
                ListViewItem item = listViewMateria.Items.Add(materia.Nome.ToString());
            }
        }

        private void ListarMateriaCombo()
        {
            try
            {
                MateriaPrimaNegocio dados = new MateriaPrimaNegocio();
                MateriaPrima filtro = new MateriaPrima();
                listaComboMateria = dados.Select(filtro);
                comboBoxMateria.Items.Clear();
                foreach (MateriaPrima m in listaComboMateria)
                {
                    comboBoxMateria.Items.Add(m.Nome);
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
                Produto p = new Produto();
                p.Nome = textBoxNome.Text;
                p.UnidadeFornecimento = textBoxUnidadeFornecimento.Text;
                p.Descricao = textBoxDescricao.Text;
                p.MateriaPrima = listaMateria;

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
                this.listaMateria = new List<MateriaPrima>();
                comboBoxMateria.SelectedIndex = -1;

                ListarMateria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdicionarNota_Click(object sender, EventArgs e)
        {
            MateriaPrima ma = new MateriaPrima();
            int index = comboBoxMateria.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Selecionar a matéria prima");
                comboBoxMateria.Focus();
                return;
            }
            ma = listaComboMateria.ElementAt(index);
            this.listaMateria.Add(ma);
            ListarMateria();
            comboBoxMateria.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewMateria.FocusedItem != null)
            {
                int index = listViewMateria.FocusedItem.Index;
                this.listaMateria.RemoveAt(index);
                this.ListarMateria();
            }
        }
    }
}
