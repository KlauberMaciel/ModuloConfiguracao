
using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        private void ValiDados(GrupoUsuario _grupoUsuario)
        {
            if (_grupoUsuario.NomeGrupo.Length <= 3)
            {
                throw new Exception("o nome do usuario deve ter mais de 3 caracteres");
            }
        }
        public void Excluir(int _id)
        {
            new GrupoUsuarioDAL().Excluir(_id);
        }
        public void Inserir(GrupoUsuario _grupoUsuario)
        {
            ValiDados(_grupoUsuario);
            new GrupoUsuarioDAL().Inserir(_grupoUsuario);
        }
        public void Alterar(GrupoUsuario _grupoUsuario)
        {
            ValiDados(_grupoUsuario);
            new GrupoUsuarioDAL().Alterar(_grupoUsuario);
        }
        public GrupoUsuario BuscarPorId(int _id)
        {
            return new GrupoUsuarioDAL().BuscarPorID(_id);
        }
        public List<GrupoUsuario> BuscarTodos()
        {
            return new GrupoUsuarioDAL().BuscarTodos();
        }
        public List<GrupoUsuario> BuscarPorNomeUsuario(string _nomeGrupo)
        {
            return new GrupoUsuarioDAL().BuscarPorNomeUsuario(_nomeGrupo);
        }

    }
}
