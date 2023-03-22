﻿using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace DAL
{
    public class Usuario_DAL
    {
        public void Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Usuario(Nome, NomeUsuario, Email,Senha ,CPF, Ativo)
                                      VALUES(@Nome, @NomeUsuario, @Email,@Senha, @CPF, @Ativo)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@CPF", _usuario.CPF);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um Usuario no Banco de Dados",ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public Usuario BuscarPorId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
               
                Usuario usuario = new Usuario();
                cmd.Connection= cn;
                cmd.CommandText = @"SELECT Id, Nome, NomeUsuario, Email,Senha ,CPF, Ativo From Usuario
                                       where Id=@ID";

                cmd.CommandType= System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                   while (rd.Read())
                    {
                       
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.GruposUsuarios = new GrupoUsuarioDAL().BuscarPorIdUsuario(usuario.Id);



                    }  
                   
                }
               return usuario;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuario na buscar", ex);
            }
            finally
            {
                cn.Close();
            }

        }

        public Usuario BuscarPorNomeUsuario(string _nomeusuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();

                Usuario usuario = new Usuario();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Nome, NomeUsuario, Email,Senha ,CPF, Ativo From Usuario
                                       where NomeUsuario=@NomeUsuario"
                ;

                cmd.Parameters.AddWithValue("@NomeUsuario", _nomeusuario);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.GruposUsuarios = new GrupoUsuarioDAL().BuscarPorIdUsuario(usuario.Id);



                    }

                }
                return usuario;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuario na buscar", ex);
            }
            finally
            {
                cn.Close();
            }
        }
         
        public List<Usuario> BuscarPorTodos()
        {
            
            List<Usuario> usuarios = new List<Usuario>(); 
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();

               
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, NomeUsuario, Email,Senha ,CPF, Ativo From Usuario";

              
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuario.Senha = rd["Senha"].ToString();
                        usuario.GruposUsuarios = new GrupoUsuarioDAL().BuscarPorIdUsuario(usuario.Id);
                        usuarios.Add(usuario);



                    }

                }
                return usuarios;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuario na buscar", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Usuario SET Nome= @Nome, NomeUsuario= @NomeUsuario, Email= @Email,Senha=@Senha ,CPF = @CPF
                                        Where Id= @ID";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@CPF", _usuario.CPF);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@ID", _usuario.Id);
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
                cmd.CommandText = @"DELETE FROM Usuario 
                                    WHERE Id= @ID";

                cmd.CommandType = System.Data.CommandType.Text;
                SqlParameter sqlParameter = cmd.Parameters.AddWithValue("@ID", _id);
               
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar excluir um Usuario no Banco de Dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Usuario> BuscarPorNome(string _nome)
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();

                
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Nome, NomeUsuario, Email,Senha ,CPF, Ativo From Usuario
                                         where Nome like @Nome";

                cmd.Parameters.AddWithValue("@NomeUsuario", "%"+ _nome + "%");
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuario.Senha = rd["Senha"].ToString();
                        usuarios.Add(usuario);



                    }

                }
                return usuarios;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuario na buscar", ex);
            }
            finally
            {
                cn.Close();
            }

        }

        public Usuario BuscarPorCPF (string _cpf)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();

                Usuario usuario = new Usuario();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Nome, NomeUsuario, Email,Senha ,CPF, Ativo From Usuario
                                       where CPF = @CPF"
                ;

                cmd.Parameters.AddWithValue("@NomeUsuario", _cpf);
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuario.Senha = rd["Senha"].ToString();




                    }

                }
                return usuario;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar buscar todos os usuario na buscar", ex);
            }
            finally
            {
                cn.Close();
            }

        }

        public bool ValidarPermissao(int _idUsuario, int _idPermissao)
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"select 1 from Permissao_GrupoUsuario
                        inner Join Usuario_GrupoUsuario on Permissao_GrupoUsuario.IdGrupoUsuario= Usuario_GrupoUsuario.IdGrupoUsuario
                        where Usuario_GrupoUsuario.IdUsuario = @IdUsuario and Permissao_GrupoUsuario.IdPermisao=@IdPermissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cmd.Parameters.AddWithValue("@IdPermissao", _idPermissao);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                        return true;
                }
                return false; 
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar valida permissão os usuario na buscar", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void AdicionarGrupoUsuario(int _idUsuario, int _idGrupoUsuario)
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();


                cmd.Connection = cn;
                cmd.CommandText = @"insert into Usuario_GrupoUsuario(IdGrupoUsuario, IdUsuario) 
                                                values(@IdUsuario, @IdGrupoUsuario)";


                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoUsuario);
                cn.Open();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar vinculor a um usuario", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public bool UsuarioPernceAoGrupo(int _idGrupoUsuario, int _idUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();

              
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT 1 From Usuario_GrupoUsuario
                                        WHERE IdUsuario = @IdUsuario AND IdGrupoUsuario = @IdGrupoUsuario";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cmd.Parameters.AddWithValue("@IdGrupoUsuario", _idGrupoUsuario);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return true;
                    }

                }
                return false;

            }
            catch (Exception ex)
            {

                throw new Exception("Ocorreu um erro ao tentar confirir usuario", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
