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
    public partial class FormCadastroMateriaPrima : Form
    {
        int operacao;
        int filtro;
        public FormCadastroMateriaPrima()
        {
            InitializeComponent();
            this.operacao = 0;
            buttonCadastrarMateriaPrima.Text = "Cadastrar";
            this.Text = "Cadastro de materia prima";
        }       
        public FormCadastroMateriaPrima(MateriaPrima m)
        {
            InitializeComponent();
            textBoxNome.Text = m.Nome;
            textBoxDescricao.Text = m.Descricao;
            textBoxLote.Text = m.Lote;
            textBoxValidade.Text = Convert.ToString(m.Validade);
            textBoxEstoqueAtual.Text = Convert.ToString(m.EstoqueAtual);
            this.filtro = m.Id;
            this.operacao = 1;
            buttonCadastrarMateriaPrima.Text = "Atualizar";
            this.Text = "Atualização da materia prima";
         }

        private void buttonCadastrarMateriaPrima_Click(object sender, EventArgs e)
        {
            try
            {
                MateriaPrima m = new MateriaPrima();
                m.Nome = textBoxNome.Text;
                m.Descricao = textBoxDescricao.Text;
                m.Lote = textBoxLote.Text;
                m.Validade = Convert.ToDateTime(textBoxValidade.Text);
                m.EstoqueAtual = Convert.ToInt32(textBoxEstoqueAtual.Text);


                Service1 dados = new Service1();
                if (this.operacao == 0)
                {
                    dados.Insert(m);
                    MessageBox.Show("Materia prima cadastrada com sucesso");
                }
                else
                {
                    m.Id = this.filtro;
                    dados.Update(m);
                    MessageBox.Show("Materia Prima atualizada com sucesso");
                }

                textBoxNome.Clear();
                textBoxDescricao.Clear();
                textBoxLote.Clear();
                textBoxValidade.Clear();
                textBoxEstoqueAtual.Clear();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
