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
        formPrincipal formPrincipal;

        private TerapiaController _ctrl = new TerapiaController();

        List<TerapiaConsulta> listaRegistros = new List<TerapiaConsulta>();

        List<TerapiaTipo> terapiaTipos = new List<TerapiaTipo>();
        TerapiaTipoController tipoController = new TerapiaTipoController();

        public formListarTerapias(formPrincipal formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void formListarTerapias_Load(object sender, EventArgs e)
        {
            try
            {
                terapiaTipos = tipoController.GetAll();

                Init();
            }
            catch (Exception)
            {

            }
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
            listaRegistros = _ctrl.GetAll();

            listaRegistros = listaRegistros.OrderBy(x => x.Id).ToList();

            DataTable dtTab = new DataTable("sqls");
            dtTab.Clear();
            dtTab.Columns.Add("Numero", typeof(string));
            dtTab.Columns.Add("Cliente", typeof(string));
            dtTab.Columns.Add("Data", typeof(string));
            dtTab.Columns.Add("Status", typeof(string));
            dtTab.Columns.Add("Tipo", typeof(string));
            dtTab.Columns.Add("Valor", typeof(string));
            dtTab.Columns.Add("Pago", typeof(string));
            DataRow row;

            foreach (var item in listaRegistros)
            {
                row = dtTab.NewRow();
                row["Numero"] = item.Id;
                row["Cliente"] = item.PessoaNome;
                row["Data"] = item.DataConsulta.ToString("dd/MM/yyyy HH:mm");
                row["Status"] = item.Status;

                var tipoTerapia = terapiaTipos.FirstOrDefault(x => x.Id == item.TipoTerapia);

                row["Tipo"] = tipoTerapia.Descricao;
                row["Valor"] = item.TerapiaValorTotal.ToString("N2");
                row["Pago"] = item.Pago;
                dtTab.Rows.Add(row);
            }

            this.dgv.DataSource = dtTab;

            this.dgv.Columns["Numero"].Width = 70;
            this.dgv.Columns["Cliente"].Width = dgv.Width - 70 - 125 - 100 - 170 - 120 - 70 - 17 - 3;
            this.dgv.Columns["Data"].Width = 125;
            this.dgv.Columns["Status"].Width = 100;
            this.dgv.Columns["Tipo"].Width = 170;
            this.dgv.Columns["Valor"].Width = 120;
            this.dgv.Columns["Pago"].Width = 70;

            if (!dgv.Controls.OfType<VScrollBar>().First().Enabled)
            {
                this.dgv.Columns["Cliente"].Width += 17;
            }

        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (this.dgv.CurrentCell != null)
                {
                    int linhaAtual;

                    linhaAtual = this.dgv.CurrentCell.RowIndex;
                    this.dgv.Rows[linhaAtual].Selected = true;

                    string Id = this.dgv.Rows[linhaAtual].Cells[0].Value.ToString();

                    var terapia = listaRegistros.FirstOrDefault(p => p.Id.ToString() == Id);

                    if (terapia != null)
                    {
                        TerapiaDetalheForm frm = new TerapiaDetalheForm(this.formPrincipal, this, terapia);
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnNovaConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                TerapiaDetalheForm frm = new TerapiaDetalheForm(this.formPrincipal, this);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

            }
        }

        private void dgv_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
