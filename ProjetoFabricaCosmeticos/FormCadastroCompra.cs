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
        List<Produto> listacomboBoxProduto = new List<Produto>();
        List<MateriaPrima> listacomboBoxMateria = new List<MateriaPrima>();

        public FormCadastroCompra()
        {
            InitializeComponent();
        }

        
    }
}
