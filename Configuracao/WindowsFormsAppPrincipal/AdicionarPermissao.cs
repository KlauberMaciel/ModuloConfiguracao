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
    public partial class AdicionarPermissao : Form
    {
         public int Id;
        public AdicionarPermissao(int _id = 0)
        {
                InitializeComponent();
                Id = _id;
        
        }

        private void AdicionarPermissao_Load(object sender, EventArgs e)
        {
            if (Id == 0)
                permissaoBindingSource.AddNew();
            else
            {
                permissaoBindingSource.DataSource = new PermissaoBLL().BuscarPorId(Id);

            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalver_Click(object sender, EventArgs e)
        {
            try
            {


                PermissaoBLL permissaoBLL = new PermissaoBLL();
                permissaoBindingSource.EndEdit();
                if (Id == 0)
                    permissaoBLL.Inserir((Permissao)permissaoBindingSource.Current);
                else
                    permissaoBLL.Alterar((Permissao)permissaoBindingSource.Current);
                MessageBox.Show("Registro salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
