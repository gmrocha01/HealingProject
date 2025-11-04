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

        public FormBasePadrao(formPrincipal formPrincipal)
        {
            InitializeComponent();

            this.formPrincipal = formPrincipal;
            this.Size = new Size(1083, 577);
            this.Font = new Font("Arial Narrow", 16);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Properties.Resources.ico_padrao;
        }


    }
}
