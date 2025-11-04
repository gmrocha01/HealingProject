using Healing.Properties;
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
    public partial class FormBasePadrao : Form
    {
        formPrincipal formPrincipal;

        public FormBasePadrao()
        {
            InitializeComponent();
        }

        public FormBasePadrao(formPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;
            //this.Size = new Size(1083, 577);
            //this.Font = new Font("Arial Narrow", 16);
            //this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Properties.Resources.ico_padrao;
        }

        private void FormBasePadrao_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //e.SuppressKeyPress = true; // impede o "bip" e quebra de linha
                    SendKeys.Send("{TAB}");
                }
            }
            catch (Exception)
            {

            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Se apertou Enter e o controle atual NÃO é um TextBox multiline
            if (keyData == Keys.Enter && !(ActiveControl is TextBox tb && tb.Multiline))
            {
                SendKeys.Send("{TAB}");
                return true; // impede o comportamento padrão do Enter
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
