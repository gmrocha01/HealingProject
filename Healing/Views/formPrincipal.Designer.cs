namespace Healing.Views
{
    partial class formPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.btnPessoas = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnTerapias = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblSelecioneModulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPessoas
            // 
            this.btnPessoas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPessoas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPessoas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPessoas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPessoas.Location = new System.Drawing.Point(19, 144);
            this.btnPessoas.Name = "btnPessoas";
            this.btnPessoas.Size = new System.Drawing.Size(148, 33);
            this.btnPessoas.TabIndex = 326;
            this.btnPessoas.Text = "Pessoas";
            this.btnPessoas.UseVisualStyleBackColor = false;
            this.btnPessoas.Visible = false;
            this.btnPessoas.Click += new System.EventHandler(this.btnPessoas_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(205, 31);
            this.lblWelcome.TabIndex = 325;
            this.lblWelcome.Text = "Seja bem-vindo !!!";
            // 
            // btnTerapias
            // 
            this.btnTerapias.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTerapias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerapias.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTerapias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerapias.Location = new System.Drawing.Point(19, 92);
            this.btnTerapias.Name = "btnTerapias";
            this.btnTerapias.Size = new System.Drawing.Size(148, 33);
            this.btnTerapias.TabIndex = 324;
            this.btnTerapias.Text = "Terapias";
            this.btnTerapias.UseVisualStyleBackColor = false;
            this.btnTerapias.Click += new System.EventHandler(this.btnTerapias_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(847, 493);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(156, 33);
            this.btnFechar.TabIndex = 347;
            this.btnFechar.Text = "Sair do Sistema";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblSelecioneModulo
            // 
            this.lblSelecioneModulo.AutoSize = true;
            this.lblSelecioneModulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSelecioneModulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecioneModulo.ForeColor = System.Drawing.Color.White;
            this.lblSelecioneModulo.Location = new System.Drawing.Point(16, 51);
            this.lblSelecioneModulo.Name = "lblSelecioneModulo";
            this.lblSelecioneModulo.Size = new System.Drawing.Size(304, 18);
            this.lblSelecioneModulo.TabIndex = 327;
            this.lblSelecioneModulo.Text = "Selecione o módulo abaixo para continuar:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Healing.Properties.Resources.imagem_fundo_formprincipal;
            this.panel1.Controls.Add(this.btnPessoas);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.btnTerapias);
            this.panel1.Controls.Add(this.lblSelecioneModulo);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 541);
            this.panel1.TabIndex = 348;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 538);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPessoas;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnTerapias;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblSelecioneModulo;
        private System.Windows.Forms.Panel panel1;
    }
}