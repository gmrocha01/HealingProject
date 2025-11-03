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
    public partial class formListarTerapias : Form
    {
        private TerapiaController _ctrl = new TerapiaController();

        public formListarTerapias()
        {
            InitializeComponent();
        }        

        private void formListarTerapias_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            CarregarGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregarGrid()
        {
            List<TerapiaConsulta> listaRegistros = _ctrl.GetAll();

            DataTable dtTab = new DataTable("sqls");
            dtTab.Clear();
            dtTab.Columns.Add("Numero", typeof(string));
            dtTab.Columns.Add("Cliente", typeof(string));
            dtTab.Columns.Add("Data", typeof(string));
            dtTab.Columns.Add("Status", typeof(string));
            dtTab.Columns.Add("Tipo", typeof(string));
            DataRow row;
            var ultimaSituacao = "";

            foreach (var item in listaRegistros)
            {
                row = dtTab.NewRow();
                row["Numero"] = item.Id;               
                row["Cliente"] = item.PessoaNome;
                row["Data"] = item.DataConsulta.ToString("dd/MM/yyyy HH:mm"); 
                row["Status"] = item.Status;
                row["Tipo"] = item.TipoTerapia;
                dtTab.Rows.Add(row);
            }

            this.dgv.DataSource = dtTab;            

            this.dgv.Columns["Número"].Width = 100;
            this.dgv.Columns["Cliente"].Width = dgv.Width - 100 - 125 - 100 - 100 - 17 - 3;
            this.dgv.Columns["Data"].Width = 125;
            this.dgv.Columns["Status"].Width = 100;
            this.dgv.Columns["Tipo"].Width = 100;

            if (!dgv.Controls.OfType<VScrollBar>().First().Enabled)
            {
                this.dgv.Columns["Cliente"].Width += 17;
            }

        }        
    }
}
