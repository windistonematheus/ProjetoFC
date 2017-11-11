using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Biblioteca.Classes_Basicas;
using Biblioteca.Negocio;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void Delete(Fornecedor fornecedor)
        {
            new FornecedorNegocio().Delete(fornecedor);
        }

        public void Insert(Fornecedor fornecedor)
        {
            new FornecedorNegocio().Insert(fornecedor);
        }

        public List<Fornecedor> Select(Fornecedor filtro)
        {
           return new FornecedorNegocio().Select(filtro);
        }

        public void Update(Fornecedor fornecedor)
        {
            new FornecedorNegocio().Update(fornecedor);
        }

        public bool VerificarDuplicidade(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public void Insert(Produto produto)
        {
            new ProdutoNegocio().Insert(produto);
        }

        public void Update(Produto produto)
        {
            new ProdutoNegocio().Update(produto);
        }

        public void Delete(Produto produto)
        {
            new ProdutoNegocio().Delete(produto);
        }

        public bool VerificarDuplicidade(Produto produto)
        {
            return new ProdutoNegocio().VerificarDuplicidade(produto);
        }

        public List<Produto> Select(Produto filtro)
        {
            return new ProdutoNegocio().Select(filtro);
        }

        public void Insert(MateriaPrima materiaprima)
        {
            new MateriaPrimaNegocio().Insert(materiaprima);
        }

        public void Update(MateriaPrima materiaprima)
        {
            new MateriaPrimaNegocio().Update(materiaprima);
        }

        public void Delete(MateriaPrima materiaprima)
        {
            new MateriaPrimaNegocio().Delete(materiaprima);
        }

        public bool VerificarDuplicidade(MateriaPrima materiaprima)
        {
            return new MateriaPrimaNegocio().VerificarDuplicidade(materiaprima);
        }

        public List<MateriaPrima> Select(MateriaPrima filtro)
        {
            return new MateriaPrimaNegocio().Select(filtro);
        }

        public void CadastrarFormula(Produto p)
        {
            throw new NotImplementedException();
        }

        public Produto SelectFormula(Produto filtro)
        {
            throw new NotImplementedException();
        }

        public void Insert(Compra compra)
        {
            throw new NotImplementedException();
        }

        public void Update(Compra compra)
        {
            throw new NotImplementedException();
        }

        public void Delete(Compra compra)
        {
            throw new NotImplementedException();
        }

        public bool VerificarDuplicidade(Compra compra)
        {
            throw new NotImplementedException();
        }

        public List<Compra> Select(Compra compra)
        {
            throw new NotImplementedException();
        }
    }
}
