using Biblioteca.Classes_Basicas;
using Biblioteca.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocio
{
    public class MateriaPrimaNegocio

    {
        public void Delete(MateriaPrima  materiaprima)
        {
            if (materiaprima == null)
            {
                throw new Exception("Informar os dados do fornecedor");
            }
            if (materiaprima.Id <= 0)
            {
                throw new Exception("O Id da Materia não poderá ser menor ou igual a zero");
            }
            MateriaPrimaDados dados = new MateriaPrimaDados();

            if (this.VerificarDuplicidade(materiaprima) == false)
            {
                throw new Exception("A materia prima não esta cadastrado");
            }

            dados.Delete(materiaprima);
        }

        public void Insert(MateriaPrima materiaprima)
        {
            if (materiaprima == null)
            {
                throw new Exception("Informar os dados da materia prima");
            }

            if (materiaprima.Nome == null)
            {
                throw new Exception("Informar o Nome da materia prima");
            }

            if (materiaprima.Nome.Length > 20)
            {
                throw new Exception("O nome da materia prima não pode ter mais de 20 caracteres");
            }

            if (materiaprima.Nome.Trim().Equals("") == true)
            {
                throw new Exception("Informar o Nome da Materia prima");
            }

            if (materiaprima.Descricao == null)
            {
                throw new Exception("Informar a descrição da materia prima");
            }

            if (materiaprima.Descricao.Trim().Equals("") == true)
            {
                throw new Exception("Informar a descricao da materia prima");
            }

            if (materiaprima.Descricao.Length > 50)
            {
                throw new Exception("A descricao da materia prima não pode ter mais de 50 caracteres");
            }

            if (materiaprima.Lote == null)
            {
                throw new Exception("Informar o lote da materia prima");
            }

            if (materiaprima.Lote.Trim().Equals("") == true)
            {
                throw new Exception("Informar o lote da materia prima");
            }

            if (materiaprima.Lote.Length > 10)
            {
                throw new Exception("O lote da materia prima não pode ter mais de 10 caracteres");
            }

            if (materiaprima.Validade == null)
            {
                throw new Exception("Informar a validade da materia prima");
            }

            if (materiaprima.Validade.Equals("") == true)
            {
                throw new Exception("Informar a validade da materia prima");
            }

            if (materiaprima.EstoqueAtual == 0)
            {
                throw new Exception("Informar o estoque atual");
            }
            if (materiaprima.EstoqueAtual.Equals("") == true)
            {
                throw new Exception("Informar o estoque da mataria prima");
            }

            MateriaPrimaDados dados = new MateriaPrimaDados();

            if (this.VerificarDuplicidade(materiaprima) == true)
            {
                throw new Exception("a materia já se encontra cadastrada");
            }

            dados.Insert(materiaprima);
        }

        public List<MateriaPrima> Select(MateriaPrima filtro)
        {
            return new MateriaPrimaDados().Select(filtro);
        }

        public void Update(MateriaPrima materiaprima)
        {
            if (materiaprima == null)
            {
                throw new Exception("Informar os dados da materia prima");
            }

            if (materiaprima.Nome == null)
            {
                throw new Exception("Informar o Nome da materia prima");
            }

            if (materiaprima.Nome.Length > 20)
            {
                throw new Exception("O nome da materia prima não pode ter mais de 20 caracteres");
            }

            if (materiaprima.Nome.Trim().Equals("") == true)
            {
                throw new Exception("Informar o Nome da Materia prima");
            }

            if (materiaprima.Descricao == null)
            {
                throw new Exception("Informar a descrição da materia prima");
            }

            if (materiaprima.Descricao.Trim().Equals("") == true)
            {
                throw new Exception("Informar a descricao da materia prima");
            }

            if (materiaprima.Descricao.Length > 50)
            {
                throw new Exception("A descricao da materia prima não pode ter mais de 50 caracteres");
            }

            if (materiaprima.Lote == null)
            {
                throw new Exception("Informar o lote da materia prima");
            }

            if (materiaprima.Lote.Trim().Equals("") == true)
            {
                throw new Exception("Informar o lote da materia prima");
            }

            if (materiaprima.Lote.Length > 10)
            {
                throw new Exception("O lote da materia prima não pode ter mais de 10 caracteres");
            }

            if (materiaprima.Validade == null)
            {
                throw new Exception("Informar a validade da materia prima");
            }

            if (materiaprima.Validade.Equals("") == true)
            {
                throw new Exception("Informar a validade da materia prima");
            }

            if (materiaprima.EstoqueAtual == 0)
            {
                throw new Exception("Informar o estoque atual");
            }
            if (materiaprima.EstoqueAtual.Equals("") == true)
            {
                throw new Exception("Informar o estoque da mataria prima");
            }
            MateriaPrimaDados dados = new MateriaPrimaDados();

            if (this.VerificarDuplicidade(materiaprima) == false)
            {
                throw new Exception("a materia prima não esta cadastrada");
            }

            dados.Update(materiaprima);
        }

        public bool VerificarDuplicidade(MateriaPrima materiaprima)
        {
            return new MateriaPrimaDados().VerificarDuplicidade(materiaprima);
        }
    }
}
