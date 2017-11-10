using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Classes_Basicas;
using System.Data;

namespace Biblioteca.DAO
{
    public class CompraDados : Util.GerenciadorConexaoSqlServer, InterfaceCompras
    {
        

        public void Insert(Compra compra)
        {
          try
            {
                this.Conectar();
                string sql = "insert into Compras(Preco,Quantidade,ID_Fornecedor,ID_MateriaPrima) ";
                sql += " values(@Preco,@Quantidade,@ID_Fornecedor,@ID_MateriaPrima)";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@Preco", SqlDbType.Decimal);
                cmd.Parameters["@Preco"].Value = compra.Preco;

                cmd.Parameters.Add("@Quantidade", SqlDbType.VarChar);
                cmd.Parameters["@Quantidade"].Value = compra.Quantidade;

                cmd.Parameters.Add("@ID_Fornecedor", SqlDbType.Int);
                cmd.Parameters["@ID_Fornecedor"].Value = compra.Fornecedor.Id;

                cmd.Parameters.Add("@ID_MateriaPrima", SqlDbType.Int);
                cmd.Parameters["@ID_MateriaPrima"].Value = compra.MateriaPrima.Id;
                
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir " + ex.Message);
            }
        }

        public void Update(Compra compra)
        {
            try
            {
                this.Conectar();
                string sql = "update MateriaPrima set Preco = @Preco,Quantidade = @Quantidade, ";
                sql += " ID_Fornecedor = @ID_Fornecedor,ID_MateriaPrima = @ID_MateriaPrima ";
                sql += " Where ID_Fornecedor = @ID_Fornecedor and ID_MateriaPrima = @ID_MateriaPrima";

                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@Preco", SqlDbType.Decimal);
                cmd.Parameters["@Preco"].Value = compra.Preco;

                cmd.Parameters.Add("@Quantidade", SqlDbType.VarChar);
                cmd.Parameters["@Quantidade"].Value = compra.Quantidade;

                cmd.Parameters.Add("@ID_Fornecedor", SqlDbType.Int);
                cmd.Parameters["@ID_Fornecedor"].Value = compra.Fornecedor.Id;

                cmd.Parameters.Add("@ID_MateriaPrima", SqlDbType.Int);
                cmd.Parameters["@ID_MateriaPrima"].Value = compra.MateriaPrima.Id;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e atualizar " + ex.Message);
            }
        }

        public void Delete(Compra compra)
        {
            try
            {
                this.Conectar();
                string sql = "delete from MateriaPrima where ID_Fornecedor = @ID_Fornecedor and ID_MateriaPrima = @ID_MateriaPrima";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);
                cmd.Parameters.Add("@ID_Fornecedor", SqlDbType.Int);
                cmd.Parameters["@ID_Fornecedor"].Value = compra.Fornecedor.Id;
                cmd.Parameters.Add("@ID_MateriaPrima", SqlDbType.Int);
                cmd.Parameters["@ID_MateriaPrima"].Value = compra.MateriaPrima.Id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e remover " + ex.Message);
            }
        }

        public bool VerificarDuplicidade(Compra compra)
        {
            bool retorno = false;
            try
            {
                this.Conectar();
                string sql = "SELECT Preco,Quantidade,ID_Fornecedor,ID_MateriaPrima ";
                sql += " FROM Compras where ID_Fornecedor=@ID_Fornecedor ";
                sql += " and ID_MateriaPrima=@ID_MateriaPrima";

                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                cmd.Parameters.Add("@ID_Fornecedor", SqlDbType.Int);
                cmd.Parameters["@ID_Fornecedor"].Value = compra.Fornecedor.Id;

                cmd.Parameters.Add("@ID_Fornecedor", SqlDbType.VarChar);
                cmd.Parameters["@ID_Fornecedor"].Value = compra.MateriaPrima.Id;

                SqlDataReader DbReader = cmd.ExecuteReader();

                while (DbReader.Read())
                {
                    retorno = true;
                    break;
                }

                DbReader.Close();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
            return retorno;
        }
        public List<Compra> Select(Compra filtro)
        {
            List<Compra> retorno = new List<Compra>();
            try
            {
                this.Conectar();
                string sql = " select MateriaPrima.Nome AS NomeMateriaPrima, Fornecedor.RazaoSocial AS NomeFornecedor, ";
                sql += " Compra.Preco, Compra.Quantidade from Compra ";
                sql += " inner join MateriaPrima on Compra.ID_MateriaPrima = MateriaPrima.ID ";
                sql += " inner join Fornecedor on Compra.ID_Fornecedor = Fornecedor.ID ";
               
                if (filtro.MateriaPrima.Nome != null && filtro.MateriaPrima.Nome.Trim().Equals("") == false)
                {
                    sql += " where and MateriaPrima.Nome = @NomeMateriaPrima";
                }
                SqlCommand cmd = new SqlCommand(sql, sqlcon);

                if (filtro.MateriaPrima.Nome != null && filtro.MateriaPrima.Nome.Trim().Equals("") == false)
                {
                    cmd.Parameters.Add("@NomeMateriaPrima", SqlDbType.VarChar);
                    cmd.Parameters["@NomeMateriaPrima"].Value = filtro.MateriaPrima.Nome;
                }

                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Compra compra = new Compra();
                    compra.Preco = DbReader.GetDouble(DbReader.GetOrdinal("Preco"));
                    compra.Quantidade = DbReader.GetInt32(DbReader.GetOrdinal("Quantidade"));
                    compra.Fornecedor.RazaoSocial = DbReader.GetString(DbReader.GetOrdinal("RazaoSocial"));
                    compra.MateriaPrima.Nome = DbReader.GetString(DbReader.GetOrdinal("Materia Prima"));
                    retorno.Add(compra);
                }

                DbReader.Close();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e selecionar " + ex.Message);
            }
            return retorno;
        }
    }
}
