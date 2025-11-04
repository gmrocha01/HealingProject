namespace Healing.Views
{
    partial class TerapiaDetalheForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCNPJCPF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePrincipal = new System.Windows.Forms.TabPage();
            this.tabPageFinanceiro = new System.Windows.Forms.TabPage();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtUsuarioAbertura = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResumo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblCustoDaOS = new System.Windows.Forms.Label();
            this.txtTotalAReceber = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDataAbertura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataAgendamento = new System.Windows.Forms.DateTimePicker();
            this.chkPago = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPagePrincipal.SuspendLayout();
            this.tabPageFinanceiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(333, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 26);
            this.txtEmail.TabIndex = 343;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(329, 158);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 20);
            this.label17.TabIndex = 342;
            this.label17.Text = "Email:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(216, 158);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 20);
            this.label16.TabIndex = 341;
            this.label16.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTelefone.Location = new System.Drawing.Point(220, 180);
            this.txtTelefone.Mask = "(99) 9999-99999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(107, 26);
            this.txtTelefone.TabIndex = 340;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(516, 129);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(80, 26);
            this.txtIdade.TabIndex = 328;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 327;
            this.label9.Text = "Idade:";
            // 
            // txtCNPJCPF
            // 
            this.txtCNPJCPF.Location = new System.Drawing.Point(7, 180);
            this.txtCNPJCPF.Name = "txtCNPJCPF";
            this.txtCNPJCPF.Size = new System.Drawing.Size(207, 26);
            this.txtCNPJCPF.TabIndex = 324;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 323;
            this.label7.Text = "CNPJ / CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(8, 129);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(502, 26);
            this.txtNome.TabIndex = 320;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 319;
            this.label5.Text = "Nome:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePrincipal);
            this.tabControl1.Controls.Add(this.tabPageFinanceiro);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 484);
            this.tabControl1.TabIndex = 344;
            // 
            // tabPagePrincipal
            // 
            this.tabPagePrincipal.Controls.Add(this.chkPago);
            this.tabPagePrincipal.Controls.Add(this.dtpDataAgendamento);
            this.tabPagePrincipal.Controls.Add(this.txtDataAbertura);
            this.tabPagePrincipal.Controls.Add(this.label3);
            this.tabPagePrincipal.Controls.Add(this.label1);
            this.tabPagePrincipal.Controls.Add(this.cmbStatus);
            this.tabPagePrincipal.Controls.Add(this.lblLocalizacao);
            this.tabPagePrincipal.Controls.Add(this.cmbTipo);
            this.tabPagePrincipal.Controls.Add(this.txtResumo);
            this.tabPagePrincipal.Controls.Add(this.label23);
            this.tabPagePrincipal.Controls.Add(this.txtUsuarioAbertura);
            this.tabPagePrincipal.Controls.Add(this.label28);
            this.tabPagePrincipal.Controls.Add(this.label2);
            this.tabPagePrincipal.Controls.Add(this.txtNome);
            this.tabPagePrincipal.Controls.Add(this.txtEmail);
            this.tabPagePrincipal.Controls.Add(this.label5);
            this.tabPagePrincipal.Controls.Add(this.label17);
            this.tabPagePrincipal.Controls.Add(this.label7);
            this.tabPagePrincipal.Controls.Add(this.label16);
            this.tabPagePrincipal.Controls.Add(this.txtCNPJCPF);
            this.tabPagePrincipal.Controls.Add(this.txtTelefone);
            this.tabPagePrincipal.Controls.Add(this.label9);
            this.tabPagePrincipal.Controls.Add(this.txtIdade);
            this.tabPagePrincipal.Location = new System.Drawing.Point(4, 29);
            this.tabPagePrincipal.Name = "tabPagePrincipal";
            this.tabPagePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrincipal.Size = new System.Drawing.Size(602, 451);
            this.tabPagePrincipal.TabIndex = 0;
            this.tabPagePrincipal.Text = "Principal";
            this.tabPagePrincipal.UseVisualStyleBackColor = true;
            // 
            // tabPageFinanceiro
            // 
            this.tabPageFinanceiro.Controls.Add(this.txtTotalAReceber);
            this.tabPageFinanceiro.Controls.Add(this.label40);
            this.tabPageFinanceiro.Controls.Add(this.txtDesconto);
            this.tabPageFinanceiro.Controls.Add(this.lblDesconto);
            this.tabPageFinanceiro.Controls.Add(this.txtValor);
            this.tabPageFinanceiro.Controls.Add(this.lblCustoDaOS);
            this.tabPageFinanceiro.Location = new System.Drawing.Point(4, 29);
            this.tabPageFinanceiro.Name = "tabPageFinanceiro";
            this.tabPageFinanceiro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFinanceiro.Size = new System.Drawing.Size(602, 451);
            this.tabPageFinanceiro.TabIndex = 1;
            this.tabPageFinanceiro.Text = "Financeiro";
            this.tabPageFinanceiro.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(536, 490);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 33);
            this.btnFechar.TabIndex = 346;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(5, 490);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 33);
            this.btnExcluir.TabIndex = 347;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtUsuarioAbertura
            // 
            this.txtUsuarioAbertura.Enabled = false;
            this.txtUsuarioAbertura.Location = new System.Drawing.Point(403, 23);
            this.txtUsuarioAbertura.Name = "txtUsuarioAbertura";
            this.txtUsuarioAbertura.Size = new System.Drawing.Size(193, 26);
            this.txtUsuarioAbertura.TabIndex = 376;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(399, 2);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(58, 20);
            this.label28.TabIndex = 375;
            this.label28.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 373;
            this.label2.Text = "Data Abertura:";
            // 
            // txtResumo
            // 
            this.txtResumo.AcceptsReturn = true;
            this.txtResumo.Location = new System.Drawing.Point(7, 232);
            this.txtResumo.Multiline = true;
            this.txtResumo.Name = "txtResumo";
            this.txtResumo.Size = new System.Drawing.Size(589, 180);
            this.txtResumo.TabIndex = 378;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 209);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(118, 20);
            this.label23.TabIndex = 377;
            this.label23.Text = "Resumo do Caso:";
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(4, 52);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(39, 20);
            this.lblLocalizacao.TabIndex = 381;
            this.lblLocalizacao.Text = "Tipo:";
            this.lblLocalizacao.Visible = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(8, 74);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(338, 28);
            this.cmbTipo.TabIndex = 382;
            this.cmbTipo.Visible = false;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 383;
            this.label1.Text = "Status:";
            this.label1.Visible = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(403, 74);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(193, 28);
            this.cmbStatus.TabIndex = 384;
            this.cmbStatus.Visible = false;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDesconto.Location = new System.Drawing.Point(116, 38);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(217, 26);
            this.txtDesconto.TabIndex = 332;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDesconto.Location = new System.Drawing.Point(4, 41);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(70, 20);
            this.lblDesconto.TabIndex = 331;
            this.lblDesconto.Text = "Desconto:";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.txtValor.Location = new System.Drawing.Point(116, 6);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(216, 26);
            this.txtValor.TabIndex = 330;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCustoDaOS
            // 
            this.lblCustoDaOS.AutoSize = true;
            this.lblCustoDaOS.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCustoDaOS.Location = new System.Drawing.Point(4, 10);
            this.lblCustoDaOS.Name = "lblCustoDaOS";
            this.lblCustoDaOS.Size = new System.Drawing.Size(44, 20);
            this.lblCustoDaOS.TabIndex = 329;
            this.lblCustoDaOS.Text = "Valor:";
            // 
            // txtTotalAReceber
            // 
            this.txtTotalAReceber.Enabled = false;
            this.txtTotalAReceber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAReceber.Location = new System.Drawing.Point(116, 69);
            this.txtTotalAReceber.Name = "txtTotalAReceber";
            this.txtTotalAReceber.Size = new System.Drawing.Size(216, 26);
            this.txtTotalAReceber.TabIndex = 334;
            this.txtTotalAReceber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label40.Location = new System.Drawing.Point(4, 72);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(108, 20);
            this.label40.TabIndex = 333;
            this.label40.Text = "Total a Receber:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Location = new System.Drawing.Point(455, 490);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 33);
            this.btnSalvar.TabIndex = 348;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDataAbertura
            // 
            this.txtDataAbertura.Enabled = false;
            this.txtDataAbertura.Location = new System.Drawing.Point(8, 23);
            this.txtDataAbertura.Name = "txtDataAbertura";
            this.txtDataAbertura.Size = new System.Drawing.Size(188, 26);
            this.txtDataAbertura.TabIndex = 386;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 385;
            this.label3.Text = "Data Agendamento:";
            // 
            // dtpDataAgendamento
            // 
            this.dtpDataAgendamento.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataAgendamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataAgendamento.Location = new System.Drawing.Point(202, 23);
            this.dtpDataAgendamento.Name = "dtpDataAgendamento";
            this.dtpDataAgendamento.Size = new System.Drawing.Size(144, 26);
            this.dtpDataAgendamento.TabIndex = 387;
            // 
            // chkPago
            // 
            this.chkPago.AutoSize = true;
            this.chkPago.Location = new System.Drawing.Point(8, 418);
            this.chkPago.Name = "chkPago";
            this.chkPago.Size = new System.Drawing.Size(60, 24);
            this.chkPago.TabIndex = 388;
            this.chkPago.Text = "Pago";
            this.chkPago.UseVisualStyleBackColor = true;
            // 
            // TerapiaDetalheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(615, 530);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.tabControl1);
            this.Name = "TerapiaDetalheForm";
            this.Text = "Terapia";
            this.Load += new System.EventHandler(this.TerapiaDetalheForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePrincipal.ResumeLayout(false);
            this.tabPagePrincipal.PerformLayout();
            this.tabPageFinanceiro.ResumeLayout(false);
            this.tabPageFinanceiro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCNPJCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePrincipal;
        private System.Windows.Forms.TabPage tabPageFinanceiro;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtUsuarioAbertura;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtResumo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblLocalizacao;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtTotalAReceber;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblCustoDaOS;
        public System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDataAbertura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataAgendamento;
        private System.Windows.Forms.CheckBox chkPago;
    }
}
