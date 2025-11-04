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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPessoas
            // 
            this.btnPessoas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPessoas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPessoas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPessoas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPessoas.Location = new System.Drawing.Point(17, 150);
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
            this.lblWelcome.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(11, 10);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(178, 31);
            this.lblWelcome.TabIndex = 325;
            this.lblWelcome.Text = "Seja bem-vindo";
            // 
            // btnTerapias
            // 
            this.btnTerapias.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTerapias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerapias.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTerapias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerapias.Location = new System.Drawing.Point(17, 102);
            this.btnTerapias.Name = "btnTerapias";
            this.btnTerapias.Size = new System.Drawing.Size(148, 33);
            this.btnTerapias.TabIndex = 324;
            this.btnTerapias.Text = "Terapias";
            this.btnTerapias.UseVisualStyleBackColor = false;
            this.btnTerapias.Click += new System.EventHandler(this.btnTerapias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 18);
            this.label1.TabIndex = 327;
            this.label1.Text = "Selecione o módulo abaixo para continuar:";
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPessoas);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnTerapias);
            this.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPessoas;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnTerapias;
        private System.Windows.Forms.Label label1;
    }
}