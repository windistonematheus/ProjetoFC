using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes_Basicas
{
    public class Compra
    {
        //Declaração dos atributos
        private double preco;
        private int quantidade;
        private Fornecedor fornecedor;
        private MateriaPrima materiaPrima;

        public Compra()
        {
            Fornecedor fornecedor = new Fornecedor();
            MateriaPrima materiaPrima = new MateriaPrima();
        }

        //Métodos Gets e Sets
        public double Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }

        public Fornecedor Fornecedor
        {
            get
            {
                return fornecedor;
            }

            set
            {
                fornecedor = value;
            }
        }

        public MateriaPrima MateriaPrima
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

        public Fornecedor Fornecedor1
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public MateriaPrima MateriaPrima1
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Fornecedor Fornecedor2
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public MateriaPrima MateriaPrima2
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
