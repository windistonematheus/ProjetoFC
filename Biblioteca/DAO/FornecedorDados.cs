using Biblioteca.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Classes_Basicas;
using System.Data;

namespace Biblioteca.DAO
{
    public class FornecedorDados : GerenciadorConexaoSqlServer, InterfaceFornecedor
    {

        public void Insert(Fornecedor fornecedor)
        {
            try
            {
                this.Conectar();
                string sql = "insert into Fornecedor(CNPJ,RazaoSocial,Email,CEP,Telefone,Estado,Cidade,Bairro,Logradouro,Complemento) ";
                sql += " values(@CNPJ,@RazaoSocial,@Email,@CEP,@Telefone,@Estado,@Cidade,@Bairro,@Logradouro,@Complemento)";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@CNPJ", SqlDbType.VarChar);
                cmd.Parameters["@CNPJ"].Value = fornecedor.Cnpj;

                cmd.Parameters.Add("@RazaoSocial", SqlDbType.VarChar);
                cmd.Parameters["@RazaoSocial"].Value = fornecedor.RazaoSocial;

                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters["@Email"].Value = fornecedor.Email;

                cmd.Parameters.Add("@CEP", SqlDbType.VarChar);
                cmd.Parameters["@CEP"].Value = fornecedor.Cep;

                cmd.Parameters.Add("@Telefone", SqlDbType.VarChar);
                cmd.Parameters["@Telefone"].Value = fornecedor.Telefone;

                cmd.Parameters.Add("@Estado", SqlDbType.VarChar);
                cmd.Parameters["@Estado"].Value = fornecedor.Estado;

                cmd.Parameters.Add("@Cidade", SqlDbType.VarChar);
                cmd.Parameters["@Cidade"].Value = fornecedor.Cidade;

                cmd.Parameters.Add("@Bairro", SqlDbType.VarChar);
                cmd.Parameters["@Bairro"].Value = fornecedor.Bairro;

                cmd.Parameters.Add("@Logradouro", SqlDbType.VarChar);
                cmd.Parameters["@Logradouro"].Value = fornecedor.Logradouro;

                cmd.Parameters.Add("@Complemento", SqlDbType.VarChar);
                cmd.Parameters["@Complemento"].Value = fornecedor.Complemento;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
        }

        public List<Fornecedor> Select(Fornecedor filtro)
        {
            throw new NotImplementedException();
        }

        public void Update(Fornecedor fornecedor)
        {
            try
            {
                this.Conectar();
                string sql = "update Fornecedor set CNPJ = @CNPJ,RazaoSocial = @RazaoSocial,Email = @Email,";
                sql += "CEP = @CEP,Telefone = @Telefone,Estado = @Estado,";
                sql += "Cidade = @Cidade,Bairro = @Bairro,Logradouro = @Logradouro,Complemento = @Complemento)";
                sql += " Where ID = @ID";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);

                cmd.Parameters.Add("@CNPJ", SqlDbType.VarChar);
                cmd.Parameters["@CNPJ"].Value = fornecedor.Cnpj;

                cmd.Parameters.Add("@RazaoSocial", SqlDbType.VarChar);
                cmd.Parameters["@RazaoSocial"].Value = fornecedor.RazaoSocial;

                cmd.Parameters.Add("@Email", SqlDbType.VarChar);
                cmd.Parameters["@Email"].Value = fornecedor.Email;

                cmd.Parameters.Add("@CEP", SqlDbType.VarChar);
                cmd.Parameters["@CEP"].Value = fornecedor.Cep;

                cmd.Parameters.Add("@Telefone", SqlDbType.VarChar);
                cmd.Parameters["@Telefone"].Value = fornecedor.Telefone;

                cmd.Parameters.Add("@Estado", SqlDbType.VarChar);
                cmd.Parameters["@Estado"].Value = fornecedor.Estado;

                cmd.Parameters.Add("@Cidade", SqlDbType.VarChar);
                cmd.Parameters["@Cidade"].Value = fornecedor.Cidade;

                cmd.Parameters.Add("@Bairro", SqlDbType.VarChar);
                cmd.Parameters["@Bairro"].Value = fornecedor.Bairro;

                cmd.Parameters.Add("@Logradouro", SqlDbType.VarChar);
                cmd.Parameters["@Logradouro"].Value = fornecedor.Logradouro;

                cmd.Parameters.Add("@Complemento", SqlDbType.VarChar);
                cmd.Parameters["@Complemento"].Value = fornecedor.Complemento;

                cmd.Parameters.Add("ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = fornecedor.Id;

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e atualizar" + ex.Message);
            }
        }

        
        public void Delete(Fornecedor fornecedor)
        {
            try
            {
                this.Conectar();
                string sql = "delete from Fornecedor where ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, this.sqlcon);
                cmd.Parameters.Add("@ID", SqlDbType.Int);
                cmd.Parameters["@ID"].Value = fornecedor.Id;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.Desconectar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conecar e remover " + ex.Message);
            }
        }

        public bool VerificarDuplicidade(Fornecedor fornecedor)
        {
            throw new NotImplementedException();
        }

       
    }
}
