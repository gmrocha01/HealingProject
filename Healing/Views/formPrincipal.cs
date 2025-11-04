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

                // Garante que o PictureBox fique atrás
                lblSelecioneModulo.Parent = panel1;

                // Labels (assumindo que foram criados no Designer diretamente no Form)
                lblWelcome.BackColor = Color.Transparent;
                lblWelcome.ForeColor = Color.White;
                lblSelecioneModulo.BackColor = Color.Transparent;
                lblSelecioneModulo.ForeColor = Color.White;

                // Só pra garantir a ordem
                lblWelcome.BringToFront();
                lblSelecioneModulo.BringToFront();
            }
            catch (Exception)
            {

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {

            }
        }

        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                btnFechar.PerformClick();
            }
            catch (Exception)
            {

            }
        }
    }
}
