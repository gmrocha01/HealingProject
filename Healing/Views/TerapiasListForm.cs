using System;
using System.Windows.Forms;
using Healing.Controllers;
using Healing.Models;
using System.Collections.Generic;
using System.Data;

namespace Healing.Views
{
    public class TerapiasListForm : Form
    {
        //private DataGridView dgv;
        //private DataGridView dataGridViewRegistros;
        //private Button btnNovaConsulta;

        List<TerapiaConsulta> listaRegistros = new List<TerapiaConsulta>();
        private DataGridView dataGridViewRegistros;
        private Button btnNovaOS;
        private TerapiaController _ctrl = new TerapiaController();

        public TerapiasListForm()
        {
            //InitializeComponent();
        }

        private void TerapiasListForm_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }       

        public void CarregarGrid()
        {
            //List<TerapiaConsulta> listaRegistros = _ctrl.GetAll();

            //DataTable dtTab = new DataTable("sqls");
            //dtTab.Clear();
            //dtTab.Columns.Add("Id", typeof(string));            
            //dtTab.Columns.Add("D", typeof(string));
            //dtTab.Columns.Add("Data", typeof(string));
            //dtTab.Columns.Add("Cliente", typeof(string));
            //dtTab.Columns.Add("Objetos", typeof(string));
            //dtTab.Columns.Add("Total", typeof(string));
            //DataRow row;
            //var ultimaSituacao = "";

            ////foreach (var ordem in this.listaOrdemServicos)
            ////{
            ////    row = dtTab.NewRow();
            ////    row["Id"] = ordem.Id;//0                
            ////    row["Número"] = ordem.Numero;//1 
            ////    row["Cliente"] = ordem.ClienteRazaoSocial;//3
            ////    row["Total"] = ordem.Total.ToString("N2");//4
            ////    dtTab.Rows.Add(row);
            ////}

            //this.dgv.DataSource = dtTab;

            //this.dgv.Columns["Id"].Visible = false;            

            //this.dgv.Columns["Número"].Width = 100;
            //this.dgv.Columns["Data"].Width = 125;
            ////this.dataGridViewRegistros.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //this.dgv.Columns["Cliente"].Width = 250;
            //this.dgv.Columns["Objetos"].Width = 278; 
            //this.dgv.Columns["Objetos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //this.dgv.Columns["Total"].Width = 100;
            //this.dgv.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //this.dgv.Columns["Total"].DefaultCellStyle.Format = "N2";

            //847
        }

        private void Init()
        {
            CarregarGrid();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewRegistros = new System.Windows.Forms.DataGridView();
            this.btnNovaOS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRegistros
            // 
            this.dataGridViewRegistros.AllowUserToAddRows = false;
            this.dataGridViewRegistros.AllowUserToDeleteRows = false;
            this.dataGridViewRegistros.AllowUserToResizeColumns = false;
            this.dataGridViewRegistros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewRegistros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRegistros.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewRegistros.ColumnHeadersHeight = 30;
            this.dataGridViewRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRegistros.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewRegistros.Location = new System.Drawing.Point(3, 93);
            this.dataGridViewRegistros.MultiSelect = false;
            this.dataGridViewRegistros.Name = "dataGridViewRegistros";
            this.dataGridViewRegistros.ReadOnly = true;
            this.dataGridViewRegistros.RowHeadersVisible = false;
            this.dataGridViewRegistros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewRegistros.RowTemplate.Height = 25;
            this.dataGridViewRegistros.Size = new System.Drawing.Size(850, 357);
            this.dataGridViewRegistros.TabIndex = 305;
            // 
            // btnNovaOS
            // 
            this.btnNovaOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
            this.btnNovaOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovaOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaOS.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnNovaOS.ForeColor = System.Drawing.Color.White;
            this.btnNovaOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaOS.Location = new System.Drawing.Point(679, 3);
            this.btnNovaOS.Name = "btnNovaOS";
            this.btnNovaOS.Size = new System.Drawing.Size(174, 35);
            this.btnNovaOS.TabIndex = 307;
            this.btnNovaOS.Text = "Nova O.S.";
            this.btnNovaOS.UseVisualStyleBackColor = false;
            this.btnNovaOS.Click += new System.EventHandler(this.btnNovaOS_Click);
            // 
            // TerapiasListForm
            // 
            this.ClientSize = new System.Drawing.Size(856, 501);
            this.Controls.Add(this.btnNovaOS);
            this.Controls.Add(this.dataGridViewRegistros);
            this.Name = "TerapiasListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistros)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnNovaOS_Click(object sender, EventArgs e)
        {

        }
    }
}
