using System;
using System.Windows.Forms;
using Healing.Controllers;
using Healing.Models;
using System.Collections.Generic;

namespace Healing.Views
{
    public class TerapiasListForm : Form
    {
        private DataGridView dgv;
        private TerapiaController _ctrl = new TerapiaController();

        public TerapiasListForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            this.Text = "Terapias - Lista";
            this.Width = 800;
            this.Height = 450;
            this.StartPosition = FormStartPosition.CenterParent;

            dgv = new DataGridView() { Left = 10, Top = 10, Width = 760, Height = 380, ReadOnly = true, SelectionMode = DataGridViewSelectionMode.FullRowSelect, AutoGenerateColumns = true };
            dgv.CellDoubleClick += Dgv_CellDoubleClick;

            this.Controls.Add(dgv);
        }

        private void LoadData()
        {
            List<TerapiaConsulta> lista = _ctrl.GetAll();
            dgv.DataSource = lista;
        }

        private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var terapia = (TerapiaConsulta)dgv.Rows[e.RowIndex].DataBoundItem;
            var f = new TerapiaDetalheForm(terapia.Id);
            f.ShowDialog();
            LoadData();
        }
    }
}
