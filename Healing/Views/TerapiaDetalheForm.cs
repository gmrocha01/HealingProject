using System;
using System.Windows.Forms;
using Healing.Controllers;
using Healing.Models;

namespace Healing.Views
{
    public class TerapiaDetalheForm : Form
    {
        private int _id;
        private TerapiaController _ctrl = new TerapiaController();
        private Label lblInfo;
        public TerapiaDetalheForm(int id)
        {
            _id = id;
            InitializeComponent();
            LoadDetail();
        }

        private void InitializeComponent()
        {
            this.Text = "Detalhe da Terapia";
            this.Width = 500;
            this.Height = 320;
            this.StartPosition = FormStartPosition.CenterParent;

            lblInfo = new Label() { Left = 10, Top = 10, Width = 460, Height = 260, AutoSize = false };
            this.Controls.Add(lblInfo);
        }

        private void LoadDetail()
        {
            var t = _ctrl.GetById(_id);
            if (t != null)
            {
                lblInfo.Text = $"Id: {t.Id}\nIdPessoa: {t.IdPessoa}\nData: {t.DataConsulta}\nTipo: {t.TipoTerapia}\n\nObservaÃ§Ãµes:\n{t.Observacoes}";
            }
            else
            {
                lblInfo.Text = "Terapia não encontrada.";
            }
        }
    }
}
