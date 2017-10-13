using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes_Basicas
{
    public class Produto
    {
        //Declaração dos atributos
        private int id;
        private string unidadeFornecimento;
        private string status;
        private List<MateriaPrima> materiaPrima;
        private string descricao;

        public Produto()
        {
            List<MateriaPrima> materiaPrima = new List<MateriaPrima>();
        }

        //Métodos Gets e Sets
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

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

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
    }
}
