
using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class UsuarioBLL
   {
        public void Inserir(Usuario _usuario, string _confirmaSenha)
        {
            ValidaPermissao(2);
           ValiDados(_usuario, _confirmaSenha);
            new Usuario_DAL().Inserir(_usuario);
        }
        public void Alterar(Usuario _usuario, string _confirmaSenha)
        {
           ValidaPermissao(2);
            ValiDados(_usuario, _confirmaSenha);
            new Usuario_DAL().Alterar(_usuario);
        }
        private void ValiDados(Usuario _usuario, string _confirmaSenha)
        {
            if (_usuario.Senha != _confirmaSenha)
                throw new Exception("A senha e a Confirmação devem ser iguais");

            if (_usuario.Senha.Length <= 3)
            {
                throw new Exception("A senha deve ter mais de 3 caracteres");
            }

            if (_usuario.Nome.Length <= 2)
            {
                throw new Exception("A nome deve ter mais de Caracteres");
            }

        }

        public void Excluir(int _id)
        {
           ValidaPermissao(4);
            new Usuario_DAL().Excluir(_id);
        }
        
        public List<Usuario> BuscarPorTodos()
        {
            ValidaPermissao(2);
            return new Usuario_DAL().BuscarPorTodos();
        }
        public Usuario BuscarPorId(int _id)
        {
            ValidaPermissao(2);
            return new Usuario_DAL().BuscarPorId(_id);
        }
        public Usuario BuscarPorCPF(string _cpf)
        {
           ValidaPermissao(2);
            return new Usuario_DAL().BuscarPorCPF(_cpf);
        }
        
        public List<Usuario> BuscarPorNome(string _nome)
        {
           ValidaPermissao(2);
            return new Usuario_DAL().BuscarPorNome(_nome);
        }
         
        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            ValidaPermissao(2);
            return new Usuario_DAL().BuscarPorNomeUsuario(_nomeUsuario);
        }

        public void  ValidaPermissao(int _idPermissao)
        {
           
           if (! new  Usuario_DAL().ValidarPermissao(Constantes.IdUsuarioLogado, _idPermissao))
           {
                throw new Exception("Voce não tem permissão de realizar essa operação. Procurre o admnistrador do sistema");
           }
        }

        public void AdicionarGrupo(int _idUsuario, int _idGrupoUsuario)
        {
            if (!new Usuario_DAL().UsuarioPernceAoGrupo(_idGrupoUsuario, _idUsuario))
                new Usuario_DAL().AdicionarGrupoUsuario(_idUsuario, _idGrupoUsuario);
        }

        public void RemoverGrupoUsuario(int _idGrupoUsuario, int _idUsuario)
        {
            new Usuario_DAL().RemoverGrupoUsuario(_idGrupoUsuario, _idUsuario);
        }

        public void Altenticar(string _noneUsuario, string _senha)
        {
            Usuario usuario= new Usuario_DAL().BuscarPorNomeUsuario(_noneUsuario);
            if (_senha == usuario.Senha && usuario.Ativo) 
            Constantes.IdUsuarioLogado = usuario.Id;
            else
                throw new Exception("Usuario ou senha inválida");
        }
    }
}
