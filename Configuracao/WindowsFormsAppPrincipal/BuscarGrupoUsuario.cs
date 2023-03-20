using System;
using BLL;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
