using Healing.Controllers;
using Healing.DBConnection;
using Healing.Models;
using Healing.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healing.Views
{
    public partial class LoginForm : Form
    {
        private UsuarioController _auth = new UsuarioController();

        public Usuario usuarioLogado;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                Init();
            }
            catch (Exception ex)
            {

            }
        }

        public void Init()
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {              
                var usuario = _auth.Authenticate(txtUsuario.Text, txtSenha.Text);

                if (usuario != null)
                {
                    this.usuarioLogado = usuario;
                    formPrincipal frm = new formPrincipal(this);
                    frm.ShowDialog();
                }
                else
                {
                    throw new Exception("Usuário ou senha incorreto!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas ao efetuar Login!\n\n" + ex.Message, "Healing Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
