

using Models;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;

namespace DAL
{
    public class GrupoUsuarioDAL
    {
        public void Inserir(GrupoUsuario _GrupoUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO GrupoUsuario (NomeGrupo)
                                   VALUES (@NomeGrupo)  ";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _GrupoUsuario.NomeGrupo);
            
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um Grupo Usuario no Banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<GrupoUsuario> BuscarTodos()
        {
            List<GrupoUsuario> grupoUsuarios = new List<GrupoUsuario>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();

                GrupoUsuario grupoUsuario = new GrupoUsuario();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT NomeGrupo, Id From GrupoUsuario";


                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.Id = Convert.ToInt32(rd["Id"]);
                        grupoUsuario.NomeGrupo = rd["NomeGrupo"].ToString();
                        grupoUsuario.Permissaos = new PermisaoDAL().BuscarPorIdGrupoUsuario(grupoUsuario.Id);
                        grupoUsuarios.Add(grupoUsuario);

                       

                    }

                }
                return grupoUsuarios;

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

        public List<GrupoUsuario> BuscarPorNomeUsuario(string _nomegrupo)
        {
            List<GrupoUsuario> grupoUsuarios = new List<GrupoUsuario>();
           
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {  
                GrupoUsuario grupoUsuario = new GrupoUsuario();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT NomeGrupo, Id From GrupoUsuario
                                    WHERE NomeGrupo LIKE @GrupoUsuario";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@GrupoUsuario", "% "+ _nomegrupo + "%");
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.Id = Convert.ToInt32(rd["Id"]);
                        grupoUsuario.NomeGrupo = rd["NomeGrupo"].ToString();

                        grupoUsuarios.Add(grupoUsuario);
                    }

                }
                return grupoUsuarios;

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

        public GrupoUsuario BuscarPorID(int _id)
        {
            List<GrupoUsuario> grupoUsuarios = new List<GrupoUsuario>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();

                GrupoUsuario grupoUsuario = new GrupoUsuario();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT NomeGrupo, Id From GrupoUsuario
                                    WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", +_id);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.Id = Convert.ToInt32(rd["Id"]);
                        grupoUsuario.NomeGrupo = rd["NomeGrupo"].ToString();

                        



                    }

                }
                return grupoUsuario;

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

        public void Alterar(GrupoUsuario _GrupoUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE GrupoUsuario SET NomeGrupo= @NomeGrupo
                                        Where Id= @ID";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@NomeGrupo", _GrupoUsuario.NomeGrupo);
                cmd.Parameters.AddWithValue("@ID", _GrupoUsuario.Id);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar Alterar um Usuario no Banco de Dados", ex);
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
                cmd.CommandText = @"DELETE FROM GrupoUsuario 
                                    WHERE Id= @ID";

                cmd.CommandType = System.Data.CommandType.Text;
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@ID", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir um Grupo Usuario no Banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<GrupoUsuario> BuscarPorIdUsuario(int _IdUsuario)
        {
            List<GrupoUsuario> grupoUsuarios = new List<GrupoUsuario>();
            GrupoUsuario grupoUsuario;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @" Select GrupoUsuario.Id ,GrupoUsuario.NomeGrupo from GrupoUsuario 
                                    INNER JOIN		Usuario_GrupoUsuario on GrupoUsuario.Id = Usuario_GrupoUsuario.IdGrupoUsuario
                                    where Usuario_GrupoUsuario.IdUsuario= @IdUsuario";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _IdUsuario);
                cn.Open();                  

                using(SqlDataReader rd= cmd.ExecuteReader())
                {
                    while(rd.Read())
                    {
                        grupoUsuario = new GrupoUsuario();
                        grupoUsuario.Id = Convert.ToInt32(rd["Id"]);
                        grupoUsuario.NomeGrupo = rd["NomeGrupo"].ToString();

                        grupoUsuarios.Add(grupoUsuario);
                    }
                    return grupoUsuarios;
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar Alterar um Usuario no Banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
