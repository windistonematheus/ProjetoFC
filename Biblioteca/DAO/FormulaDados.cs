using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Classes_Basicas;
using System.Data.SqlClient;
using System.Data;

namespace Biblioteca.DAO
{
    public class FormulaDados : GerenciadorConexaoSqlServer, InterfaceFormula
    {
        public void CadastrarFormula(Produto p)
        {
            try
            {
                foreach (MateriaPrima ma in p.MateriaPrima)
                {
                this.Conectar();
                string sql = "insert into Compoe (ID_Produto, ID_MateriaPrima) ";
                sql += " values(@IdProduto, @IdMateriaPrima)";

                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@IdProduto", SqlDbType.Int);
                cmd.Parameters["@IdProduto"].Value = p.Id;

                cmd.Parameters.Add("@IdMateriaPrima", SqlDbType.Int);
                cmd.Parameters["@IdMateriaPrima"].Value = ma.Id;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e inserir " + ex.Message);
            }
        }
    }
}
