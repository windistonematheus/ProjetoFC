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
                foreach (MateriaPrima a in listaMateriaPrima)
                {
                    ListViewItem linha = listViewMateriaPrima.Items.Add(a.Id.ToString());
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

        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {

        }
    }
}
