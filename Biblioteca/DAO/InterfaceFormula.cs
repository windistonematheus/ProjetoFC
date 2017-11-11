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
        void CadastrarFormula(Produto p);
        Produto SelectFormula(Produto filtro);
    }
}
