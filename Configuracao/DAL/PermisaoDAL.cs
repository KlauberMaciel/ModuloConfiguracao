using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class PermisaoDAL
    {
        public void Inserir(Permissao _permisao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Permissao(Descrisaao)
                                      VALUES(@Descrisaao)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _permisao.Descrisaao);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um Permissao no Banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Permissao> BuscarPorDescricao(string _descricao)
        {
            List<Permissao> permissaos = new List<Permissao>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();

                Permissao permissao = new Permissao();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Permissao, Id From Permissao
                                    WHERE Descricao LIKE @Descricao";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", "% " + _descricao + "%");
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descrisaao = rd["Descricao"].ToString();

                        permissaos.Add(permissao);



                    }

                }
                return permissaos;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar nome os grupoUsuarios na buscar", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Permissao> BuscarPorTudo()
        {
            List<Permissao> permissaos = new List<Permissao>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();

                Permissao permissao = new Permissao();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Descricao, Id From Permissao";


                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descrisaao = rd["Descricao"].ToString();

                        permissaos.Add(permissao);



                    }

                }
                return permissaos;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os grupoUsuarios na buscar", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Permissao BuscarPorId(int _id)
        {
            List<Permissao> permissaos = new List<Permissao>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();

                Permissao permissao = new Permissao();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Permissao, Id From Permissao
                                    WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        permissao = new Permissao();
                        permissao.Id = Convert.ToInt32(rd["Id"]);
                        permissao.Descrisaao = rd["Descricao"].ToString();

                        



                    }

                }
                return permissao;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar id  Permissao na buscar", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Permissao _permisao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Permissao SET Descrisaao= @Descrisaao
                                        Where Id= @ID";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descrisaao", _permisao.Descrisaao);

                cmd.Parameters.AddWithValue("@ID", _permisao.Id);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar Alterar um Permissao no Banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROW Permissao 
                                    WHERE ID= @ID";

                cmd.CommandType = System.Data.CommandType.Text;
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@ID", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir um Permissao no Banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
