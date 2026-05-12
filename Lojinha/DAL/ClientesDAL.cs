using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lojinha.Modelos;


namespace Lojinha.DAL
{
    public class ClientesDAL
    {
        public void Incluir(ClienteInformation cliente)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "insere_cliente";

                //Parametros da Stored Procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", System.Data.SqlDbType.Int);
                pcodigo.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@nome", System.Data.SqlDbType.VarChar, 100);
                pnome.Value = cliente.Nome;
                cmd.Parameters.Add(pnome);

                SqlParameter pemail = new SqlParameter("@email", System.Data.SqlDbType.VarChar, 100);
                pnome.Value = cliente.Email;
                cmd.Parameters.Add(pemail);

                SqlParameter ptelefone = new SqlParameter("@telefone", System.Data.SqlDbType.VarChar, 20);
                pnome.Value = cliente.Telefone;
                cmd.Parameters.Add(ptelefone);

                cn.Open();
                cmd.ExecuteNonQuery();

                cliente.Codigo = (Int32)cmd.Parameters["@codigo"].Value;


            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao acessar o banco de dados." + ex.Message);
            }
            catch
            {
                throw new Exception("Erro desconhecido ao acessar o banco de dados.");
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(ClienteInformation cliente)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "altera_cliente";

                //Parametros da Stored Procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", System.Data.SqlDbType.Int);
                pcodigo.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                SqlParameter pnome = new SqlParameter("@nome", System.Data.SqlDbType.VarChar, 100);
                pnome.Value = cliente.Nome;
                cmd.Parameters.Add(pnome);

                SqlParameter pemail = new SqlParameter("@email", System.Data.SqlDbType.VarChar, 100);
                pnome.Value = cliente.Email;
                cmd.Parameters.Add(pemail);

                SqlParameter ptelefone = new SqlParameter("@telefone", System.Data.SqlDbType.VarChar, 20);
                pnome.Value = cliente.Telefone;
                cmd.Parameters.Add(ptelefone);

                cn.Open();
                cmd.ExecuteNonQuery();

                cliente.Codigo = (Int32)cmd.Parameters["@codigo"].Value;


            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao acessar o banco de dados." + ex.Message);
            }
            catch
            {
                throw new Exception("Erro desconhecido ao acessar o banco de dados.");
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(ClienteInformation cliente)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "exclui_cliente";

                //Parametros da Stored Procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", System.Data.SqlDbType.Int);
                pcodigo.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                cmd.ExecuteNonQuery();

                cliente.Codigo = (Int32)cmd.Parameters["@codigo"].Value;

            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao acessar o banco de dados." + ex.Message);
            }
            catch
            {
                throw new Exception("Erro desconhecido ao acessar o banco de dados.");
            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable Seleciona(string filtro)
        {
            //Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "seleciona_cliente";

                //Parametros da Stored Procedure
                SqlParameter pfiltro = new SqlParameter("@filtro", System.Data.SqlDbType.VarChar, 100);
                pfiltro.Value = filtro;
                cmd.Parameters.Add(pfiltro);
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabela);
                return tabela;

            }
            catch (SqlException ex)
            {
                throw new Exception("Erro ao acessar o banco de dados." + ex.Message);
            },

            catch
            {
                throw new Exception("Erro desconhecido ao acessar o banco de dados.");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}