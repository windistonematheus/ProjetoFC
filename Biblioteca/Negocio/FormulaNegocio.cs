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
            ProdutoNegocio dadosProduto = new ProdutoNegocio();
            MateriaPrimaNegocio dadosMateriaPrima = new MateriaPrimaNegocio();

            if (dadosProduto.VerificarDuplicidade(produto) == false)
            {
                throw new Exception("O produto não esta cadastrado");
            }

            foreach (MateriaPrima materiaPrima in produto.MateriaPrima)
            {
                if (dadosMateriaPrima.VerificarDuplicidade(materiaPrima) == false)
                {
                    throw new Exception("A materia prima não esta cadastrado");
                }
            }

            dados.CadastrarFormula(produto);
        }

        public void DeleteFormula(Produto produto)
        {
            if (produto == null)
            {
                throw new Exception("Informar os dados da Formula");
            }
            if (produto.Id <= 0)
            {
                throw new Exception("O Id do produto não poderá ser menor ou igual a zero");
            }
            FormulaDados dados = new FormulaDados();

            if (this.VerificarDuplicidadeFormula(produto) == false)
            {
                throw new Exception("A formula não esta cadastrado");
            }

            dados.DeleteFormula(produto);
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

        public bool VerificarDuplicidadeFormula(Produto produto)
        {
            return new FormulaDados().VerificarDuplicidadeFormula(produto);
        }
    }
}
