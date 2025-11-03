using Healing.Controllers;
using Healing.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healing.Views
{
    public partial class LoginForm : Form
    {
        private UsuarioController _auth = new UsuarioController();

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
