
using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class UsuarioBLL
   {
        public void Inserir(Usuario _usuario)
        {
           ValiDados(_usuario);
            new Usuario_DAL().Inserir(_usuario);
        }
        public void Alterar(Usuario _usuario)
        {
            ValiDados(_usuario);
            new Usuario_DAL().Altear(_usuario);
        }
        private void ValiDados(Usuario _usuario)
        {
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
            new Usuario_DAL().Excluir(_id);
        }
        
        public List<Usuario> BuscarTodos()
        {
            return new Usuario_DAL().BuscarPorTodos();
        }
        public Usuario BuscarPorId(int _id)
        {
            return new Usuario_DAL().BuscarPorId(_id);
        }
        public Usuario BuscarPorCPF(string _cpf)
        {
            return new Usuario_DAL().BuscarPorCPF(_cpf);
        }
        
        public List<Usuario> BuscarPorNome(String _nome)
        {
            return new Usuario_DAL().BuscarPorNome(_nome);
        }
         
        public Usuario BuscarPorNomeUsuario(String _nomeUsuario)
        {
            return new Usuario_DAL().BuscarPorNomeUsuario(_nomeUsuario);
        }
    }
}
