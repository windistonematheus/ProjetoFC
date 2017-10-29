using System;
using Biblioteca.Util;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GerenciadorConexaoSqlServer sqlconnection = new GerenciadorConexaoSqlServer();
            sqlconnection.Conectar();
            sqlconnection.Desconectar();
            MessageBox.Show("OK");
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedor form = new FormCadastroFornecedor();
            form.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaFornecedor formc = new FormConsultaFornecedor();
            formc.Show();
        }
    }
}
