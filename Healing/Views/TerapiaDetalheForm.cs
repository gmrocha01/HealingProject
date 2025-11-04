using Healing.Controllers;
using Healing.Models;
using Healing.Repositories;
using Healing.Tools;
using Healing.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Healing.Views
{
    public partial class TerapiaDetalheForm : FormBasePadrao
    {
        TerapiaTipoController terapiaTipoController = new TerapiaTipoController();
        TerapiaController terapiaController = new TerapiaController();

        formPrincipal formPrincipal;
        TerapiaConsulta terapia;
        formListarTerapias formListarTerapias;

        List<TerapiaTipo> listaTipoTerapia = new List<TerapiaTipo>();
        Dictionary<string, string> valoresStatus = new Dictionary<string, string>();

        bool iniciando = true;

        public TerapiaDetalheForm(formPrincipal formPrincipal, formListarTerapias formListarTerapias, TerapiaConsulta terapia = null) : base(formPrincipal)
        {
            InitializeComponent();
            this.formListarTerapias = formListarTerapias;
            this.terapia = terapia;
            this.formPrincipal = formPrincipal;
        }

        private void TerapiaDetalheForm_Load(object sender, EventArgs e)
        {
            try
            {
                CarregaCombos();

                Init();

                iniciando = false;

                cmbTipo_SelectedIndexChanged(null, null);
            }
            catch (Exception)
            {

            }
        }
        public void Init()
        {
            if (terapia != null)
            {
                txtDataAbertura.Text = terapia.DataAbertura.ToString("dd/MM/yyyy HH:mm");
                dtpDataAgendamento.Value = terapia.DataConsulta;
                txtUsuarioAbertura.Text = terapia.UsuarioResponsavel;
                cmbTipo.SelectedValue = terapia.TipoTerapia;
                cmbStatus.SelectedValue = terapia.Status;
                txtNome.Text = terapia.PessoaNome;
                txtIdade.Text = terapia.PessoaIdade;
                txtCNPJCPF.Text = terapia.PessoaCpfCnpj;
                txtTelefone.Text = terapia.PessoaTelefone;
                txtEmail.Text = terapia.PessoaEmail;
                txtResumo.Text = terapia.Observacoes;
                chkPago.Checked = terapia.Pago == "S" ? true : false;

                //Aba Financeiro

                txtValor.Text = terapia.TerapiaValor.ToString("N2");
                txtDesconto.Text = terapia.TerapiaValorDesconto.ToString("N2");
                txtTotalAReceber.Text = terapia.TerapiaValorTotal.ToString("N2");
            }
            else
            {
                txtDataAbertura.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                dtpDataAgendamento.Value = DateTime.Now;
                txtUsuarioAbertura.Text = formPrincipal.usuarioLogado.UsuarioLogin;

                cmbTipo.SelectedValue = listaTipoTerapia.FirstOrDefault().Id;

                txtValor.Text = "0,00";
                txtDesconto.Text = "0,00";
                txtTotalAReceber.Text = "0,00";

                btnExcluir.Visible = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Você deseja realmente realizar a exclusão?", "Healing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (this.terapia != null)
                    {
                        terapiaController.Delete(this.terapia);

                        MessageBox.Show("Registro excluído com sucesso!", "Healing Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.formListarTerapias.CarregarGrid();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void CarregaCombos()
        {
            listaTipoTerapia = terapiaTipoController.GetAll();

            listaTipoTerapia = listaTipoTerapia.OrderBy(x => x.Descricao).ToList();

            this.cmbTipo.DataSource = new BindingSource(listaTipoTerapia, null);
            this.cmbTipo.ValueMember = "Id";
            this.cmbTipo.DisplayMember = "Descricao";
            this.cmbTipo.SelectedValue = listaTipoTerapia.FirstOrDefault().Id;

            valoresStatus = new Dictionary<string, string>();

            //valoresStatus.Add("PRE-AGENDADO", "PRE-AGENDADO");
            valoresStatus.Add("AGENDADO", "AGENDADO");
            valoresStatus.Add("FINALIZADO", "FINALIZADO");

            this.cmbStatus.DataSource = new BindingSource(valoresStatus, null);
            this.cmbStatus.ValueMember = "Key";
            this.cmbStatus.DisplayMember = "Value";
            this.cmbStatus.SelectedValue = "AGENDADO";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "")
                {
                    throw new Exception("Preencha o nome do cliente!");
                }

                if (txtTotalAReceber.Text.GetDecimal() < 0)
                {
                    throw new Exception("O valor total não pode ser menor que zero!");
                }

                if (this.terapia == null)
                {
                    this.terapia = new TerapiaConsulta();
                }

                this.terapia.DataAbertura = DateTime.Now;
                this.terapia.DataConsulta = dtpDataAgendamento.Value;
                this.terapia.UsuarioResponsavel = txtUsuarioAbertura.Text;
                this.terapia.TipoTerapia = cmbTipo.SelectedValue.ToString();
                this.terapia.Status = cmbStatus.SelectedValue.ToString();
                this.terapia.PessoaNome = txtNome.Text;
                this.terapia.PessoaIdade = txtIdade.Text;
                this.terapia.PessoaCpfCnpj = txtCNPJCPF.Text;
                this.terapia.PessoaTelefone = txtTelefone.Text;
                this.terapia.PessoaEmail = txtEmail.Text;
                this.terapia.Observacoes = txtResumo.Text;
                this.terapia.Pago = chkPago.Checked ? "S" : "N";

                this.terapia.TerapiaValor = txtValor.Text.GetDecimal();
                this.terapia.TerapiaValorDesconto = txtDesconto.Text.GetDecimal();
                this.terapia.TerapiaValorTotal = txtTotalAReceber.Text.GetDecimal();

                terapiaController.Save(this.terapia);

                MessageBox.Show("Registro salvo com sucesso!", "Healing Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.formListarTerapias.CarregarGrid();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Healing Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.terapia = null;
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!iniciando)
                {
                    var tipoSelecionado = listaTipoTerapia.FirstOrDefault(x => x.Id == cmbTipo.SelectedValue.ToString());

                    if (tipoSelecionado != null)
                    {
                        decimal valorDaTerapia = tipoSelecionado.Valor;

                        txtValor.Text = tipoSelecionado.Valor.ToString("N2");

                        decimal valorTotal = valorDaTerapia - txtDesconto.Text.GetDecimal();

                        txtTotalAReceber.Text = valorTotal.ToString("N2");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal valorTerapia = txtValor.Text.GetDecimal();
                decimal desconto = txtDesconto.Text.GetDecimal();

                decimal total = valorTerapia - desconto;

                txtTotalAReceber.Text = total.ToString("N2");
            }
            catch (Exception ex)
            {

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
