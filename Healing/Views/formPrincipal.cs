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
    public partial class formPrincipal : Form
    {
        LoginForm loginForm;
        public Usuario usuarioLogado;

        public formPrincipal(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void btnTerapias_Click(object sender, EventArgs e)
        {
            try
            {
                formListarTerapias frm = new formListarTerapias(this);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnPessoas_Click(object sender, EventArgs e)
        {

        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                this.usuarioLogado = loginForm.usuarioLogado;
            }
            catch (Exception)
            {

            }
        }
    }
}
