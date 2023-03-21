using System;
using BLL;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace WindowsFormsAppPrincipal
{
    public partial class BuscarGrupoUsuario : Form
    {
        public BuscarGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
           grupoUsuarioBindingSource.DataSource = new GrupoUsuarioBLL().BuscarTodos();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            using (adicionaGrupoUsuario frm = new adicionaGrupoUsuario())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
            using (adicionaGrupoUsuario frm = new adicionaGrupoUsuario(id))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (grupoUsuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existo para ser exluido");
                return;
            }
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção ", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
            new GrupoUsuarioBLL().Excluir(id);
            grupoUsuarioBindingSource.RemoveCurrent();

            MessageBox.Show("Registro Excluido com Sucesso!");
        }
    }
}
