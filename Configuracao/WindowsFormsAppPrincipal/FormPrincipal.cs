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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        /*    Usuario usuario = new Usuario();
            usuario.Nome = "Test1";
            usuario.NomeUsuario = "OIIee";
            usuario.Ativo = true;
            usuario.CPF = "0228112388";
            usuario.Senha = "123334";
            usuario.Email = "gmail@.com";

            new UsuarioBLL().Inserir(usuario);*/
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            using(FormLogin frm = new FormLogin())
            {
                frm.ShowDialog();
                if(!frm.Logou)
                    Application.Exit();
            }
           
        }

        private void gruposUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(BuscarGrupoUsuario frm = new BuscarGrupoUsuario())
            {
                frm.ShowDialog();
            }
        }
    }
}
