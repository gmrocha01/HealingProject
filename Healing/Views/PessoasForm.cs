using System;
using System.Windows.Forms;
using Healing.Controllers;
using Healing.Models;
using System.Collections.Generic;

namespace Healing.Views
{
    public class PessoasForm : Form
    {
        private DataGridView dgv;
        private PessoaController _ctrl = new PessoaController();

        public PessoasForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent()
        {
            this.Text = "Cadastro de Pessoas";
            this.Width = 700;
            this.Height = 450;
            this.StartPosition = FormStartPosition.CenterParent;

            dgv = new DataGridView() { Left = 10, Top = 10, Width = 660, Height = 360, ReadOnly = true, SelectionMode = DataGridViewSelectionMode.FullRowSelect, AutoGenerateColumns = true };

            var btnNovo = new Button() { Left = 10, Top = 380, Width = 100, Text = "Novo" };
            btnNovo.Click += BtnNovo_Click;

            this.Controls.Add(dgv);
            this.Controls.Add(btnNovo);
        }

        private void LoadData()
        {
            List<Pessoa> lista = _ctrl.GetAll();
            dgv.DataSource = lista;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade de novo registro nÃ£o implementada neste esqueleto. Implemente Insert via PessoaController.");
        }
    }
}
