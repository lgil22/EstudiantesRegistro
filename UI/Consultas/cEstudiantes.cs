using RegistroEstudiantes.BLL;
using RegistroEstudiantes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEstudiantes.UI
{
    public partial class cEstudiantes : Form
    {
        public cEstudiantes()
        {
           InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cEstudiantes));
            this.dataGridViewConsulta = new System.Windows.Forms.DataGridView();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.textBoxCriterio = new System.Windows.Forms.TextBox();
            this.label1Desde = new System.Windows.Forms.Label();
            this.label2Hasta = new System.Windows.Forms.Label();
            this.label3Filtro = new System.Windows.Forms.Label();
            this.label4Criterio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewConsulta
            // 
            this.dataGridViewConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsulta.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewConsulta.Name = "dataGridViewConsulta";
            this.dataGridViewConsulta.Size = new System.Drawing.Size(782, 340);
            this.dataGridViewConsulta.TabIndex = 0;
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDesde.Location = new System.Drawing.Point(15, 25);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(100, 20);
            this.dateTimeDesde.TabIndex = 1;
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeHasta.Location = new System.Drawing.Point(125, 25);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(99, 20);
            this.dateTimeHasta.TabIndex = 2;
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Todo",
            "Id"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(231, 25);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltro.TabIndex = 3;
            this.comboBoxFiltro.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFiltro_SelectedIndexChanged);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Image = ((System.Drawing.Image)(resources.GetObject("buttonConsultar.Image")));
            this.buttonConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsultar.Location = new System.Drawing.Point(705, 17);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(89, 34);
            this.buttonConsultar.TabIndex = 5;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.ButtonConsultar_Click);
            // 
            // textBoxCriterio
            // 
            this.textBoxCriterio.Location = new System.Drawing.Point(358, 25);
            this.textBoxCriterio.Name = "textBoxCriterio";
            this.textBoxCriterio.Size = new System.Drawing.Size(341, 20);
            this.textBoxCriterio.TabIndex = 6;
            // 
            // label1Desde
            // 
            this.label1Desde.AutoSize = true;
            this.label1Desde.Location = new System.Drawing.Point(12, 9);
            this.label1Desde.Name = "label1Desde";
            this.label1Desde.Size = new System.Drawing.Size(38, 13);
            this.label1Desde.TabIndex = 7;
            this.label1Desde.Text = "Desde";
            // 
            // label2Hasta
            // 
            this.label2Hasta.AutoSize = true;
            this.label2Hasta.Location = new System.Drawing.Point(122, 9);
            this.label2Hasta.Name = "label2Hasta";
            this.label2Hasta.Size = new System.Drawing.Size(35, 13);
            this.label2Hasta.TabIndex = 8;
            this.label2Hasta.Text = "Hasta";
            // 
            // label3Filtro
            // 
            this.label3Filtro.AutoSize = true;
            this.label3Filtro.Location = new System.Drawing.Point(228, 9);
            this.label3Filtro.Name = "label3Filtro";
            this.label3Filtro.Size = new System.Drawing.Size(29, 13);
            this.label3Filtro.TabIndex = 9;
            this.label3Filtro.Text = "Filtro";
            // 
            // label4Criterio
            // 
            this.label4Criterio.AutoSize = true;
            this.label4Criterio.Location = new System.Drawing.Point(355, 9);
            this.label4Criterio.Name = "label4Criterio";
            this.label4Criterio.Size = new System.Drawing.Size(39, 13);
            this.label4Criterio.TabIndex = 10;
            this.label4Criterio.Text = "Criterio";
            // 
            // cEstudiantes
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(806, 402);
            this.Controls.Add(this.label4Criterio);
            this.Controls.Add(this.label3Filtro);
            this.Controls.Add(this.label2Hasta);
            this.Controls.Add(this.label1Desde);
            this.Controls.Add(this.textBoxCriterio);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.dateTimeHasta);
            this.Controls.Add(this.dateTimeDesde);
            this.Controls.Add(this.dataGridViewConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ButtonConsultar_Click(object sender, EventArgs e)
        {
            {
                var listado = new List<Estudiantes>();

                if (textBoxCriterio.Text.Trim().Length > 0)
                {
                    switch (comboBoxFiltro.SelectedIndex)
                    {
                        case 0://Todo
                            listado = EstudiantesBLL.GetList(est => true);
                            break;

                        case 1://ID
                            int id = Convert.ToInt32(textBoxCriterio.Text);
                            listado = EstudiantesBLL.GetList(est => est.EstudianteId == id);
                            break;

                        case 2://Matricula
                            listado = EstudiantesBLL.GetList(est => est.Matricula.Contains(textBoxCriterio.Text));
                            break;

                        case 3://Nombre
                            listado = EstudiantesBLL.GetList(est => est.Nombre.Contains(textBoxCriterio.Text));
                            break;

                        case 4://Cedula
                            listado = EstudiantesBLL.GetList(est => est.Cedula.Contains(textBoxCriterio.Text));
                            break;

                        case 5://Direccion
                            listado = EstudiantesBLL.GetList(est => est.Direccion.Contains(textBoxCriterio.Text));
                            break;
                    }

                    listado = listado.Where(c => c.FechaNacimiento.Date >= dateTimeDesde.Value.Date && c.FechaNacimiento.Date <= dateTimeHasta.Value.Date).ToList();
                }
                else
                {
                    listado = EstudiantesBLL.GetList(est => true);
                }

                dataGridViewConsulta.DataSource = null;
                dataGridViewConsulta.DataSource = listado;
            }

        }

        private void cEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void dateTimeDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeHasta_ValueChanged(object sender, EventArgs e)
        {

        }


        private void ComboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
