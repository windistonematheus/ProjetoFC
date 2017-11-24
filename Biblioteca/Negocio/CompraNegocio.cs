using Biblioteca.DAO;
using Biblioteca.Classes_Basicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class CompraNegocio : InterfaceCompra
    {
        public void Delete(Compra compra)
        {
            throw new NotImplementedException();
        }

        public void Insert(Compra compra)
        {
            if (compra == null)
            {
                throw new Exception("Informar os dados da compra");
            }

            if (Convert.ToString(compra.Preco)  == null)
            {
                throw new Exception("Informar o preço do produto");
            }

            if (Convert.ToString(compra.Preco).Length > 14)
            {
                throw new Exception("O preço do produto não pode ter mais de 14 caracteres");
            }

            if (Convert.ToString(compra.Preco).Trim().Equals("") == true)
            {
                throw new Exception("Informar o preço do produto");
            }

            if (Convert.ToString(compra.Quantidade) == null)
            {
                throw new Exception("Informar a quantiade do produto");
            }

            if (Convert.ToString(compra.Quantidade).Length > 8)
            {
                throw new Exception("a quantidade do produto não pode ter mais de 8 caracteres");
            }

            if (Convert.ToString(compra.Quantidade).Trim().Equals("") == true)
            {
                throw new Exception("Informar a quantidade do produto");
            }

            CompraDados dados = new CompraDados();

            dados.Insert(compra);
        }

        public List<Compra> Select(Compra compra)
        {
             return new CompraDados().Select(compra);
        }

        public void Update(Compra compra)
        {
            CompraDados dados = new CompraDados();

            dados.Update(compra);
        }

        public bool VerificarDuplicidade(Compra compra)
        {
            return new CompraDados().VerificarDuplicidade(compra);
        }
    }

        
   
}
