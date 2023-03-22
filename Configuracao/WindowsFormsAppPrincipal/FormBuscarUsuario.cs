using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarUsuario : Form
    {
      
        public FormBuscarUsuario()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                using (FormConsultaGrupoUsuario frm = new FormConsultaGrupoUsuario())
                {
                    frm.ShowDialog();

                    if (frm.Id != 0)
                    {
                        int idUsuario = ((Usuario)usuarioBindingSource.Current).Id;
                        new UsuarioBLL().AdicionarGrupo(idUsuario, frm.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
          
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            using(CadastroDeUsuario frm = new CadastroDeUsuario())
            {
                frm.ShowDialog();
            }
            Buscar_Click(null, null);   
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Count<= 0 )
            {
                MessageBox.Show("Não existo para ser exluido");
                return;
            }
            if(MessageBox.Show("Deseja realmente excluir este registro?","Atenção ", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id =((Usuario)usuarioBindingSource.Current).Id;
            new UsuarioBLL().Excluir(id);
            usuarioBindingSource.RemoveCurrent();

            MessageBox.Show("Registro Excluido com Sucesso!");
        }

        private void FormBuscarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            int id = ((Usuario)usuarioBindingSource.Current).Id;
            using (CadastroDeUsuario frm = new CadastroDeUsuario(id))
            {
                frm.ShowDialog();
            }
            Buscar_Click(null, null);
        }
    }
}
