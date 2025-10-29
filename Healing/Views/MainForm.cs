using System;
using System.Windows.Forms;
using Healing.Models;

namespace Healing.Views
{
    public class MainForm : Form
    {
        private Button btnTerapias;
        private Label lblWelcome;
        private Button btnPessoas;

        //private Button btnTerapias;
        //private Button btnPessoas;
        //private Label lblWelcome;
        //private Button btnFinalizarAtendimento;
        private Usuario _usuario;

        public MainForm(Usuario usuario)
        {
            _usuario = usuario;
            //InitializeComponent();
        }

        //private void InitializeComponent()
        //{
        //    this.lblWelcome = new System.Windows.Forms.Label();
        //    this.btnTerapias = new System.Windows.Forms.Button();
        //    this.btnPessoas = new System.Windows.Forms.Button();
        //    this.btnFinalizarAtendimento = new System.Windows.Forms.Button();
        //    this.SuspendLayout();
        //    // 
        //    // lblWelcome
        //    // 
        //    this.lblWelcome.Location = new System.Drawing.Point(0, 0);
        //    this.lblWelcome.Name = "lblWelcome";
        //    this.lblWelcome.Size = new System.Drawing.Size(100, 23);
        //    this.lblWelcome.TabIndex = 0;
        //    // 
        //    // btnTerapias
        //    // 
        //    this.btnTerapias.Location = new System.Drawing.Point(0, 0);
        //    this.btnTerapias.Name = "btnTerapias";
        //    this.btnTerapias.Size = new System.Drawing.Size(75, 23);
        //    this.btnTerapias.TabIndex = 1;
        //    // 
        //    // btnPessoas
        //    // 
        //    this.btnPessoas.Location = new System.Drawing.Point(0, 0);
        //    this.btnPessoas.Name = "btnPessoas";
        //    this.btnPessoas.Size = new System.Drawing.Size(75, 23);
        //    this.btnPessoas.TabIndex = 2;
        //    // 
        //    // btnFinalizarAtendimento
        //    // 
        //    this.btnFinalizarAtendimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
        //    this.btnFinalizarAtendimento.Location = new System.Drawing.Point(21, 127);
        //    this.btnFinalizarAtendimento.Name = "btnFinalizarAtendimento";
        //    this.btnFinalizarAtendimento.Size = new System.Drawing.Size(148, 33);
        //    this.btnFinalizarAtendimento.TabIndex = 321;
        //    this.btnFinalizarAtendimento.Text = "Terapias";
        //    this.btnFinalizarAtendimento.UseVisualStyleBackColor = true;
        //    this.btnFinalizarAtendimento.Visible = false;
        //    // 
        //    // MainForm
        //    // 
        //    this.ClientSize = new System.Drawing.Size(513, 272);
        //    this.Controls.Add(this.btnFinalizarAtendimento);
        //    this.Controls.Add(this.lblWelcome);
        //    this.Controls.Add(this.btnTerapias);
        //    this.Controls.Add(this.btnPessoas);
        //    this.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
        //    this.Name = "MainForm";
        //    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        //    this.Text = "Healing - Principal";
        //    this.ResumeLayout(false);

        //}

        private void BtnTerapias_Click(object sender, EventArgs e)
        {
            var f = new TerapiasListForm();
            f.ShowDialog();
        }

        private void BtnPessoas_Click(object sender, EventArgs e)
        {
            var f = new PessoasForm();
            f.ShowDialog();
        }

        private void InitializeComponent()
        {
            this.btnTerapias = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnPessoas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTerapias
            // 
            this.btnTerapias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerapias.Location = new System.Drawing.Point(19, 63);
            this.btnTerapias.Name = "btnTerapias";
            this.btnTerapias.Size = new System.Drawing.Size(148, 33);
            this.btnTerapias.TabIndex = 321;
            this.btnTerapias.Text = "Terapias";
            this.btnTerapias.UseVisualStyleBackColor = true;
            this.btnTerapias.Visible = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(13, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(178, 31);
            this.lblWelcome.TabIndex = 322;
            this.lblWelcome.Text = "Seja bem-vindo";
            // 
            // btnPessoas
            // 
            this.btnPessoas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPessoas.Location = new System.Drawing.Point(364, 63);
            this.btnPessoas.Name = "btnPessoas";
            this.btnPessoas.Size = new System.Drawing.Size(148, 33);
            this.btnPessoas.TabIndex = 323;
            this.btnPessoas.Text = "Pessoas";
            this.btnPessoas.UseVisualStyleBackColor = true;
            this.btnPessoas.Visible = false;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(535, 123);
            this.Controls.Add(this.btnPessoas);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnTerapias);
            this.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "MainForm";
            this.Text = "Healing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
