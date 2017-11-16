using Biblioteca.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.DAO
{
    interface InterfaceFormula
    {
        void CadastrarFormula(Produto produto);
        void CadastrarItemFormula(Produto produto);
        void DeleteFormula(Produto produto);
        void DeleteItemFormula(Produto produto);
        bool VerificarDuplicidadeFormula(Produto produto);
        bool VerificarDuplicidadeItemFormula(Produto produto);
        List<MateriaPrima> SelectFormula(Produto filtro);
    }
}
