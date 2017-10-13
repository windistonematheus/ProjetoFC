using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes_Basicas
{
    public class MateriaPrima
    {
        //Declaração dos atributos
        private int id;
        private DateTime validade;
        private string descricao;
        private string lote;
        private string nome;
        private int estoqueAtual;
        private List<Produto> produto;
        private List<Compra> compra;

        public MateriaPrima()
        {
            List<Produto> produto = new List<Produto>();
            List<Compra> compra = new List<Compra>();
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

        public DateTime Validade
        {
            get
            {
                return validade;
            }

            set
            {
                validade = value;
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

        public string Lote
        {
            get
            {
                return lote;
            }

            set
            {
                lote = value;
            }
        }

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

        public int EstoqueAtual
        {
            get
            {
                return estoqueAtual;
            }

            set
            {
                estoqueAtual = value;
            }
        }

        public List<Produto> Produto
        {
            get
            {
                return produto;
            }

            set
            {
                produto = value;
            }
        }

        internal List<Compra> Compra
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

        public Produto Produto1
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
