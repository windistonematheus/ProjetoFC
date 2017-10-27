using Biblioteca.Classes_Basicas;
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
        public FormConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            try
            {
                Fornecedor filtro = new Fornecedor();
                if (textBoxCnpj.Text.Trim().Equals("") == false)
                {
                    filtro.Cnpj = textBoxCnpj.Text.Trim();
                }
                filtro.RazaoSocial = textBoxRazaoSocial.Text;
                listViewFornecedor.Items.Clear();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
