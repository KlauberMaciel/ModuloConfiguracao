using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PermissaoBLL
    {
        private void ValiDados(Permissao _permissao)
        {
            if (_permissao.Descrisaao.Length <= 15)
            {
                throw new Exception("A Descrisaao deve ter mais de 15 caracteres");
            }

        }
        public void Inserir(Permissao _permissao)
        {
            ValiDados(_permissao);
            new PermisaoDAL().Inserir(_permissao);
        }

        public void Excluir(int _id)
        {
            new PermisaoDAL().Excluir(_id);
        }
        public void Alterar(Permissao _permissao)
        {
            ValiDados(_permissao);
            new PermisaoDAL().Alterar(_permissao);
        }
        public List<Permissao> BuscarTodos()
        {
            return new PermisaoDAL().BuscarPorTudo();
        }

        public List<Permissao> BuscarPorId(int _id)
        {
            return new PermisaoDAL().BuscarPorId(_id);
        }
        public List<Permissao> BuscarPorDescricao(string _descricao)
        {
            return new PermisaoDAL().BuscarPorDescricao(_descricao);
        }
    }
}
