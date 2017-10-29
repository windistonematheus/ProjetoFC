using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Classes_Basicas;

namespace Biblioteca.Negocio
{
    public class FornecedorNegocio : InterfaceFornecedor

    {
        public void Delete(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

        public void Insert(Fornecedor fornecedor)
        {
            if (fornecedor == null)
            {
                throw new Exception("Informar os dados do fornecedor");
            }

            if (fornecedor.Cnpj == null)
            {
                throw new Exception("Informar o CNPJ do fornecedor");
            }

            if (fornecedor.Cnpj.Length > 14)
            {
                throw new Exception("O CNPJ do fornecedor não pode ter mais de 14 caracteres");
            }

            if (fornecedor.Cnpj.Trim().Equals("") == true)
            {
                throw new Exception("Informar CNPJ do fornecedor");
            }

            if (fornecedor.RazaoSocial == null)
            {
                throw new Exception("Informar a Razão Social do fornecedor");
            }

            if (fornecedor.RazaoSocial.Trim().Equals("") == true)
            {
                throw new Exception("Informar a Razão Social do fornecedor");
            }

            if (fornecedor.RazaoSocial.Length > 100)
            {
                throw new Exception("A Razão Social do fornecedor não pode ter mais de 100 caracteres");
            }

            if (fornecedor.Logradouro == null)
            {
                throw new Exception("Informar o Logradouro do fornecedor");
            }

            if (fornecedor.Logradouro.Trim().Equals("") == true)
            {
                throw new Exception("Informar o Logradouro do fornecedor");
            }

            if (fornecedor.Logradouro.Length > 100)
            {
                throw new Exception("O Logradouro do fornecedor não pode ter mais de 100 caracteres");
            }

            if (fornecedor.Complemento == null)
            {
                throw new Exception("Informar o Complemento do fornecedor");
            }

            if (fornecedor.Complemento.Trim().Equals("") == true)
            {
                throw new Exception("Informar o Complemento do fornecedor");
            }

            if (fornecedor.Complemento.Length > 20)
            {
                throw new Exception("O Complemento do fornecedor não pode ter mais de 20 caracteres");
            }

            if (fornecedor.Bairro == null)
            {
                throw new Exception("Informar o Bairro do fornecedor");
            }

            if (fornecedor.Bairro.Trim().Equals("") == true)
            {
                throw new Exception("Informar o Bairro do fornecedor");
            }

            if (fornecedor.Bairro.Length > 20)
            {
                throw new Exception("O Bairro do fornecedor não pode ter mais de 20 caracteres");
            }

            if (fornecedor.Cidade == null)
            {
                throw new Exception("Informar a Cidade do fornecedor");
            }

            if (fornecedor.Cidade.Trim().Equals("") == true)
            {
                throw new Exception("Informar a Cidade do fornecedor");
            }

            if (fornecedor.Cidade.Length > 20)
            {
                throw new Exception("A Cidade do fornecedor não pode ter mais de 20 caracteres");
            }

            if (fornecedor.Estado == null)
            {
                throw new Exception("Informar o Estado do fornecedor");
            }

            if (fornecedor.Estado.Trim().Equals("") == true)
            {
                throw new Exception("Informar o Estado do fornecedor");
            }

            if (fornecedor.Estado.Length > 2)
            {
                throw new Exception("O Estado do fornecedor não pode ter mais de 2 caracteres");
            }

            if (fornecedor.Cep == null)
            {
                throw new Exception("Informar o CEP do fornecedor");
            }

            if (fornecedor.Cep.Trim().Equals("") == true)
            {
                throw new Exception("Informar o CEP do fornecedor");
            }

            if (fornecedor.Cep.Length > 9)
            {
                throw new Exception("O CEP do fornecedor não pode ter mais de 9 caracteres");
            }

            if (fornecedor.Email == null)
            {
                throw new Exception("Informar o E-mail do fornecedor");
            }

            if (fornecedor.Email.Trim().Equals("") == true)
            {
                throw new Exception("Informar o E-mail do fornecedor");
            }

            if (fornecedor.Email.Length > 50)
            {
                throw new Exception("O E-mail do fornecedor não pode ter mais de 50 caracteres");
            }

            if (fornecedor.Telefone == null)
            {
                throw new Exception("Informar o Telefone do fornecedor");
            }

            if (fornecedor.Telefone.Trim().Equals("") == true)
            {
                throw new Exception("Informar o Telefone do fornecedor");
            }

            if (fornecedor.Telefone.Length > 50)
            {
                throw new Exception("O Telefone do fornecedor não pode ter mais de 50 caracteres");
            }

            FornecedorDados dados = new FornecedorDados();

            if (this.VerificarDuplicidade(fornecedor) == true)
            {
                throw new Exception("O fornecedor já se encontra cadastrado");
            }

            dados.Insert(fornecedor);
        }

        public List<Fornecedor> Select(Fornecedor filtro)
        {
            return new FornecedorDados().Select(filtro);
        }

        public void Update(Fornecedor fornecedor)
        {
            if (fornecedor == null)
            {
                throw new Exception("Informar os dados do fornecedor");
            }

            if (fornecedor.Cnpj == null)
            {
                throw new Exception("Informar o CNPJ do fornecedor");
            }

            if (fornecedor.Cnpj.Length > 14)
            {
                throw new Exception("O CNPJ do fornecedor não pode ter mais de 14 caracteres");
            }

            if (fornecedor.Cnpj.Trim().Equals("") == true)
            {
                throw new Exception("Informar CNPJ do fornecedor");
            }

            if (fornecedor.RazaoSocial == null)
            {
                throw new Exception("Informar a Razão Social do fornecedor");
            }

            if (fornecedor.RazaoSocial.Trim().Equals("") == true)
            {
                throw new Exception("Informar a Razão Social do fornecedor");
            }

            if (fornecedor.RazaoSocial.Length > 100)
            {
                throw new Exception("A Razão Social do fornecedor não pode ter mais de 100 caracteres");
            }

            if (fornecedor.Logradouro == null)
            {
                throw new Exception("Informar o Logradouro do fornecedor");
            }

            if (fornecedor.Logradouro.Trim().Equals("") == true)
            {
                throw new Exception("Informar o Logradouro do fornecedor");
            }

            if (fornecedor.Logradouro.Length > 100)
            {
                throw new Exception("O Logradouro do fornecedor não pode ter mais de 100 caracteres");
            }

            if (fornecedor.Complemento == null)
            {
                throw new Exception("Informar o Complemento do fornecedor");
            }

            if (fornecedor.Complemento.Trim().Equals("") == true)
            {
                throw new Exception("Informar o Complemento do fornecedor");
            }

            if (fornecedor.Complemento.Length > 20)
            {
                throw new Exception("O Complemento do fornecedor não pode ter mais de 20 caracteres");
            }

            if (fornecedor.Bairro == null)
            {
                throw new Exception("Informar o Bairro do fornecedor");
            }

            if (fornecedor.Bairro.Trim().Equals("") == true)
            {
                throw new Exception("Informar o Bairro do fornecedor");
            }

            if (fornecedor.Bairro.Length > 20)
            {
                throw new Exception("O Bairro do fornecedor não pode ter mais de 20 caracteres");
            }

            if (fornecedor.Cidade == null)
            {
                throw new Exception("Informar a Cidade do fornecedor");
            }

            if (fornecedor.Cidade.Trim().Equals("") == true)
            {
                throw new Exception("Informar a Cidade do fornecedor");
            }

            if (fornecedor.Cidade.Length > 20)
            {
                throw new Exception("A Cidade do fornecedor não pode ter mais de 20 caracteres");
            }

            if (fornecedor.Estado == null)
            {
                throw new Exception("Informar o Estado do fornecedor");
            }

            if (fornecedor.Estado.Trim().Equals("") == true)
            {
                throw new Exception("Informar o Estado do fornecedor");
            }

            if (fornecedor.Estado.Length > 2)
            {
                throw new Exception("O Estado do fornecedor não pode ter mais de 2 caracteres");
            }

            if (fornecedor.Cep == null)
            {
                throw new Exception("Informar o CEP do fornecedor");
            }

            if (fornecedor.Cep.Trim().Equals("") == true)
            {
                throw new Exception("Informar o CEP do fornecedor");
            }

            if (fornecedor.Cep.Length > 9)
            {
                throw new Exception("O CEP do fornecedor não pode ter mais de 9 caracteres");
            }

            if (fornecedor.Email == null)
            {
                throw new Exception("Informar o E-mail do fornecedor");
            }

            if (fornecedor.Email.Trim().Equals("") == true)
            {
                throw new Exception("Informar o E-mail do fornecedor");
            }

            if (fornecedor.Email.Length > 50)
            {
                throw new Exception("O E-mail do fornecedor não pode ter mais de 50 caracteres");
            }

            if (fornecedor.Telefone == null)
            {
                throw new Exception("Informar o Telefone do fornecedor");
            }

            if (fornecedor.Telefone.Trim().Equals("") == true)
            {
                throw new Exception("Informar o Telefone do fornecedor");
            }

            if (fornecedor.Telefone.Length > 50)
            {
                throw new Exception("O Telefone do fornecedor não pode ter mais de 50 caracteres");
            }
            if (fornecedor.Id <= 0)
            {
                throw new Exception("O Id do aluno não poderá ser menor ou igual a zero");
            }
            FornecedorDados dados = new FornecedorDados();
            
            if (this.VerificarDuplicidade(fornecedor)==false)
            {
                throw new Exception("O fornecedor não esta cadastrado");
            }
            
            dados.Update(fornecedor);
        }

        public bool VerificarDuplicidade(Fornecedor fornecedor)
        {
            return new FornecedorDados().VerificarDuplicidade(fornecedor);
        }
    }
}
