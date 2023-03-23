﻿using BLL;
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
    public partial class CadastroDeUsuario : Form
    {
        public int Id;
        public CadastroDeUsuario(int _id = 0)
        {
            InitializeComponent();
            Id = _id;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {

           
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuarioBindingSource.EndEdit();
            if(Id==0)
            usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current, TextBoxConfimarSenha.Text);
            else
                usuarioBLL.Alterar((Usuario)usuarioBindingSource.Current,TextBoxConfimarSenha.Text);
            MessageBox.Show("Registro salvo com sucesso!");
            Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CadastroDeUsuario_Load(object sender, EventArgs e)
        {
            if (Id == 0)
                usuarioBindingSource.AddNew();
            else
            {
                usuarioBindingSource.DataSource = new UsuarioBLL().BuscarPorId(Id);
              
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
