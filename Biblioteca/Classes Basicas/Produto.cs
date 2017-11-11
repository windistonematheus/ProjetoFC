using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes_Basicas
{
    [Serializable]
    public class Produto
    {
        //Declaração dos atributos
        private int id;
        private string unidadeFornecimento;
        private List<MateriaPrima> materiaPrima;
        private string descricao;
        private string nome;

        public Produto()
        {
            List<MateriaPrima> materiaPrima = new List<MateriaPrima>();
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
        public string UnidadeFornecimento
        {
            get
            {
                return unidadeFornecimento;
            }

            set
            {
                unidadeFornecimento = value;
            }
        }

        [DataMember]
        public List<MateriaPrima> MateriaPrima
        {
            get
            {
                return materiaPrima;
            }

            set
            {
                materiaPrima = value;
            }
        }

        [DataMember]
        public string Descricao
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        [DataMember]
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
    }
}
