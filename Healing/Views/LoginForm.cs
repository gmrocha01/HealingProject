using System;
using System.Windows.Forms;
using Healing.Controllers;
using Healing.Models;

namespace Healing.Views
{
    public class LoginForm : Form
    {
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnLogin;
        private UsuarioController _auth = new UsuarioController();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Healing - Login";
            this.Width = 360;
            this.Height = 220;
            this.StartPosition = FormStartPosition.CenterScreen;

            var lblU = new Label() { Left = 20, Top = 20, Text = "Usuário", AutoSize = true };
            txtUsuario = new TextBox() { Left = 20, Top = 40, Width = 300, Name = "txtUsuario" };

            var lblS = new Label() { Left = 20, Top = 70, Text = "Senha", AutoSize = true };
            txtSenha = new TextBox() { Left = 20, Top = 90, Width = 300, Name = "txtSenha", UseSystemPasswordChar = true };

            btnLogin = new Button() { Left = 120, Top = 130, Width = 100, Text = "Entrar" };
            btnLogin.Click += BtnLogin_Click;

            this.Controls.Add(lblU);
            this.Controls.Add(txtUsuario);
            this.Controls.Add(lblS);
            this.Controls.Add(txtSenha);
            this.Controls.Add(btnLogin);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var user = _auth.Authenticate(txtUsuario.Text.Trim(), txtSenha.Text);
            if (user != null)
            {
                var main = new MainForm(user);
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha inválidos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
