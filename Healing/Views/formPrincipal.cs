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
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void btnTerapias_Click(object sender, EventArgs e)
        {
            try
            {
                TerapiasListForm frm = new TerapiasListForm();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnPessoas_Click(object sender, EventArgs e)
        {

        }
    }
}
