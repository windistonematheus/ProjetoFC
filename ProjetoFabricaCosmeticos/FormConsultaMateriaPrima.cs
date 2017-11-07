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
    public partial class FormConsultaMateriaPrima : Form
    {
        List<MateriaPrima> listaMateriaPrima = new List<MateriaPrima>();

        public FormConsultaMateriaPrima()
        {
            InitializeComponent();
        }
        
        private void AlterarMateriaPrima()
        {
            try
            {
                if (listViewMateriaPrima.FocusedItem != null)
                {
                    int posicao = listViewMateriaPrima.FocusedItem.Index;
                    MateriaPrima materiaprimaSelecionada = this.listaMateriaPrima.ElementAt(posicao);
                    FormCadastroMateriaPrima form = new FormCadastroMateriaPrima(materiaprimaSelecionada);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Favor selecionar a materia prima");
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
                MateriaPrimaNegocio dados = new MateriaPrimaNegocio();
                MateriaPrima filtro = new MateriaPrima();
                if (textBoxNome.Text.Trim().Equals("") == false)
                {
                    filtro.Nome = textBoxNome.Text.Trim();
                }
                filtro.Descricao = textBoxDescricao.Text;
                listaMateriaPrima = dados.Select(filtro);
                listViewMateriaPrima.Items.Clear();
                foreach (MateriaPrima m in listaMateriaPrima)
                {
                    ListViewItem linha = listViewMateriaPrima.Items.Add(m.Id.ToString());
                    linha.SubItems.Add(m.Nome);
                    linha.SubItems.Add(m.Descricao);
                    linha.SubItems.Add(m.Lote);
                    linha.SubItems.Add(Convert.ToString(m.Validade));
                    linha.SubItems.Add(Convert.ToString(m.EstoqueAtual));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            AlterarMateriaPrima();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMateriaPrima.FocusedItem != null)
                {
                    int posicao = listViewMateriaPrima.FocusedItem.Index;
                    MateriaPrima materiaprimaSelecionada = this.listaMateriaPrima.ElementAt(posicao);
                    MateriaPrimaNegocio dados = new MateriaPrimaNegocio();
                    dados.Delete(materiaprimaSelecionada);
                    listViewMateriaPrima.Items.Clear();
                    MessageBox.Show("Materia prima removida com sucesso");

                }
                else
                {
                    MessageBox.Show(" Favor selecionar a materia prima");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
