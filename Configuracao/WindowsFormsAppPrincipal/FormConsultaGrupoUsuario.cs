using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace WindowsFormsAppPrincipal
{
    public partial class FormConsultaGrupoUsuario : Form
    {
        public int Id;
        public FormConsultaGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                grupoUsuarioBindingSource.DataSource = new GrupoUsuarioBLL().BuscarPorNomeUsuario(textBoxBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grupoUsuarioBindingSource.Count > 0)
                {
                    Id = ((GrupoUsuario)grupoUsuarioBindingSource.Current).Id;
                }
                else
                    MessageBox.Show("Não existe registro para ser Selecionado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConsultaGrupoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
