using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Classes_Basicas;

namespace Biblioteca.Negocio
{
    public class FormulaNegocio : InterfaceFormula
    {
        public void CadastrarFormula(Produto produto)
        {
            if (produto == null)
            {
                throw new Exception("Informar os dados do produto");
            }

            if (produto.Id <= 0)
            {
                throw new Exception("O Id do produto não poderá ser menor ou igual a zero");
            }

            if (produto.MateriaPrima == null)
            {
                throw new Exception("Informar os dados da materia prima");
            }

            FormulaDados dados = new FormulaDados();

            dados.CadastrarFormula(produto);
        }

        public List<MateriaPrima> SelectFormula(Produto filtro)
        {
            if (filtro == null)
            {
                throw new Exception("Informar os dados do produto");
            }

            if (filtro.Id <= 0)
            {
                throw new Exception("O Id do produto não poderá ser menor ou igual a zero");
            }
            return new FormulaDados().SelectFormula(filtro);
        }
    }
}
