using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes_Basicas
{
    [Serializable]
    public class Fornecedor
    {
        //Declaração dos atributos
        private int id;
        private string cnpj;
        private string cep;
        private string razaoSocial;
        private string logradouro;
        private string cidade;
        private string estado;
        private string bairro;
        private string email;
        private string telefone;
        private string complemento;
        private List<Compra> compra;

        public Fornecedor()
        {
            List<Compra> compra = new List<Compra>();
        }
        //Métodos Gets e Sets
        [DataMember]
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        [DataMember]
        public string Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
        }

        [DataMember]
        public string Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        [DataMember]
        public string RazaoSocial
        {
            get
            {
                return razaoSocial;
            }

            set
            {
                razaoSocial = value;
            }
        }

        [DataMember]
        public string Logradouro
        {
            get
            {
                return logradouro;
            }

            set
            {
                logradouro = value;
            }
        }

        [DataMember]
        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        [DataMember]
        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        [DataMember]
        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        [DataMember]
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        [DataMember]
        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        [DataMember]
        public List<Compra> Compra
        {
            get
            {
                return compra;
            }

            set
            {
                compra = value;
            }
        }

        [DataMember]
        public string Complemento
        {
            get
            {
                return complemento;
            }

            set
            {
                complemento = value;
            }
        }
    }
}
