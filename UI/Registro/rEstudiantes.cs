using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroEstudiantes.BLL;
using RegistroEstudiantes.Entidades;


namespace RegistroEstudiantes.UI
{
    
    public partial class rEstudiantes : Form
    {      //Intancia para numeros en textbox
       // Validacion val = new Validacion();
        public rEstudiantes()
        {
            
            InitializeComponent();
        }

        private void Limpiar()
        {
            numericUpDown1_id.Value = 0;
            maskedTextBox1_Matricula.Text = string.Empty;
            textBox1_Nombre.Text = string.Empty;
            textBox2_Apellidos.Text = string.Empty;
            maskedTextBox2_Telefono.Text = string.Empty;
            maskedTextBox3_Cedula.Text = "";
            textBox3_Direccion.Text = string.Empty;
            textBox4_Email.Text = string.Empty;
            textBox5_Balance.Text = textBox5_Balance.Text;
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = 0;
            errorProvider1.Clear();
        }


        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteId = Convert.ToInt32(numericUpDown1_id.Value);
            estudiante.Matricula = maskedTextBox1_Matricula.Text;
            estudiante.Nombre = textBox1_Nombre.Text;
            estudiante.Apellidos = textBox2_Apellidos.Text;
            estudiante.Telefono = maskedTextBox2_Telefono.Text;
            estudiante.Cedula = maskedTextBox3_Cedula.Text;
            estudiante.Direccion = textBox3_Direccion.Text;
            estudiante.Email = textBox4_Email.Text;
            estudiante.Balance = Convert.ToDecimal(textBox5_Balance.Text);
            estudiante.Sexo = comboBox1.Text;
            return estudiante;
        }

        private void LlenaCampo(Estudiantes estudiante)
        {
            numericUpDown1_id.Value = estudiante.EstudianteId;
            maskedTextBox1_Matricula.Text = estudiante.Matricula;
            textBox1_Nombre.Text = estudiante.Nombre;
            textBox2_Apellidos.Text = estudiante.Apellidos;
            maskedTextBox3_Cedula.Text = estudiante.Cedula;
            textBox3_Direccion.Text = estudiante.Direccion;
            textBox4_Email.Text = estudiante.Email;
            textBox5_Balance.Text = estudiante.Balance.ToString();

            dateTimePicker1.Value = estudiante.FechaNacimiento;

            // CargarGrid();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rEstudiantes));
            this.label1_id = new System.Windows.Forms.Label();
            this.button1_buscar = new System.Windows.Forms.Button();
            this.label2_Matricula = new System.Windows.Forms.Label();
            this.maskedTextBox1_Matricula = new System.Windows.Forms.MaskedTextBox();
            this.label3_Nombre = new System.Windows.Forms.Label();
            this.textBox1_Nombre = new System.Windows.Forms.TextBox();
            this.label4_Apellidos = new System.Windows.Forms.Label();
            this.textBox2_Apellidos = new System.Windows.Forms.TextBox();
            this.label5_Telefono = new System.Windows.Forms.Label();
            this.maskedTextBox2_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.label6_Cedula = new System.Windows.Forms.Label();
            this.maskedTextBox3_Cedula = new System.Windows.Forms.MaskedTextBox();
            this.label8_Direccion = new System.Windows.Forms.Label();
            this.textBox3_Direccion = new System.Windows.Forms.TextBox();
            this.label9_Email = new System.Windows.Forms.Label();
            this.textBox4_Email = new System.Windows.Forms.TextBox();
            this.label10_Balance = new System.Windows.Forms.Label();
            this.textBox5_Balance = new System.Windows.Forms.TextBox();
            this.label11_Sexo = new System.Windows.Forms.Label();
            this.button2_Nuevo = new System.Windows.Forms.Button();
            this.button3_Guardar = new System.Windows.Forms.Button();
            this.button4_Eliminar = new System.Windows.Forms.Button();
            this.label7_FechaNac = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1_id = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_id
            // 
            this.label1_id.AutoSize = true;
            this.label1_id.Location = new System.Drawing.Point(24, 36);
            this.label1_id.Name = "label1_id";
            this.label1_id.Size = new System.Drawing.Size(18, 13);
            this.label1_id.TabIndex = 0;
            this.label1_id.Text = "ID";
            this.label1_id.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button1_buscar
            // 
            this.button1_buscar.Image = ((System.Drawing.Image)(resources.GetObject("button1_buscar.Image")));
            this.button1_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_buscar.Location = new System.Drawing.Point(272, 12);
            this.button1_buscar.Name = "button1_buscar";
            this.button1_buscar.Size = new System.Drawing.Size(82, 46);
            this.button1_buscar.TabIndex = 2;
            this.button1_buscar.Text = "Buscar";
            this.button1_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1_buscar.UseVisualStyleBackColor = true;
            this.button1_buscar.Click += new System.EventHandler(this.Button1_buscar_Click);
            // 
            // label2_Matricula
            // 
            this.label2_Matricula.AutoSize = true;
            this.label2_Matricula.Location = new System.Drawing.Point(24, 62);
            this.label2_Matricula.Name = "label2_Matricula";
            this.label2_Matricula.Size = new System.Drawing.Size(50, 13);
            this.label2_Matricula.TabIndex = 3;
            this.label2_Matricula.Text = "Matricula";
            this.label2_Matricula.Click += new System.EventHandler(this.Label2_Matricula_Click);
            // 
            // maskedTextBox1_Matricula
            // 
            this.maskedTextBox1_Matricula.Location = new System.Drawing.Point(122, 59);
            this.maskedTextBox1_Matricula.Mask = "0000-0000";
            this.maskedTextBox1_Matricula.Name = "maskedTextBox1_Matricula";
            this.maskedTextBox1_Matricula.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBox1_Matricula.TabIndex = 4;
            // 
            // label3_Nombre
            // 
            this.label3_Nombre.AutoSize = true;
            this.label3_Nombre.Location = new System.Drawing.Point(24, 92);
            this.label3_Nombre.Name = "label3_Nombre";
            this.label3_Nombre.Size = new System.Drawing.Size(44, 13);
            this.label3_Nombre.TabIndex = 5;
            this.label3_Nombre.Text = "Nombre";
            // 
            // textBox1_Nombre
            // 
            this.textBox1_Nombre.Location = new System.Drawing.Point(122, 92);
            this.textBox1_Nombre.Name = "textBox1_Nombre";
            this.textBox1_Nombre.Size = new System.Drawing.Size(134, 20);
            this.textBox1_Nombre.TabIndex = 6;
            this.textBox1_Nombre.TextChanged += new System.EventHandler(this.TextBox1_Nombre_TextChanged);
            // 
            // label4_Apellidos
            // 
            this.label4_Apellidos.AutoSize = true;
            this.label4_Apellidos.Location = new System.Drawing.Point(24, 128);
            this.label4_Apellidos.Name = "label4_Apellidos";
            this.label4_Apellidos.Size = new System.Drawing.Size(49, 13);
            this.label4_Apellidos.TabIndex = 7;
            this.label4_Apellidos.Text = "Apellidos";
            this.label4_Apellidos.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // textBox2_Apellidos
            // 
            this.textBox2_Apellidos.Location = new System.Drawing.Point(122, 125);
            this.textBox2_Apellidos.Name = "textBox2_Apellidos";
            this.textBox2_Apellidos.Size = new System.Drawing.Size(134, 20);
            this.textBox2_Apellidos.TabIndex = 8;
            // 
            // label5_Telefono
            // 
            this.label5_Telefono.AutoSize = true;
            this.label5_Telefono.Location = new System.Drawing.Point(24, 164);
            this.label5_Telefono.Name = "label5_Telefono";
            this.label5_Telefono.Size = new System.Drawing.Size(49, 13);
            this.label5_Telefono.TabIndex = 9;
            this.label5_Telefono.Text = "Telefono";
            // 
            // maskedTextBox2_Telefono
            // 
            this.maskedTextBox2_Telefono.Location = new System.Drawing.Point(122, 157);
            this.maskedTextBox2_Telefono.Mask = "000-000-0000";
            this.maskedTextBox2_Telefono.Name = "maskedTextBox2_Telefono";
            this.maskedTextBox2_Telefono.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBox2_Telefono.TabIndex = 10;
            // 
            // label6_Cedula
            // 
            this.label6_Cedula.AutoSize = true;
            this.label6_Cedula.Location = new System.Drawing.Point(28, 195);
            this.label6_Cedula.Name = "label6_Cedula";
            this.label6_Cedula.Size = new System.Drawing.Size(40, 13);
            this.label6_Cedula.TabIndex = 11;
            this.label6_Cedula.Text = "Cedula";
            // 
            // maskedTextBox3_Cedula
            // 
            this.maskedTextBox3_Cedula.Location = new System.Drawing.Point(122, 192);
            this.maskedTextBox3_Cedula.Mask = "000-0000000-0";
            this.maskedTextBox3_Cedula.Name = "maskedTextBox3_Cedula";
            this.maskedTextBox3_Cedula.Size = new System.Drawing.Size(134, 20);
            this.maskedTextBox3_Cedula.TabIndex = 12;
            // 
            // label8_Direccion
            // 
            this.label8_Direccion.AutoSize = true;
            this.label8_Direccion.Location = new System.Drawing.Point(24, 270);
            this.label8_Direccion.Name = "label8_Direccion";
            this.label8_Direccion.Size = new System.Drawing.Size(52, 13);
            this.label8_Direccion.TabIndex = 13;
            this.label8_Direccion.Text = "Direccion";
            // 
            // textBox3_Direccion
            // 
            this.textBox3_Direccion.Location = new System.Drawing.Point(122, 267);
            this.textBox3_Direccion.Name = "textBox3_Direccion";
            this.textBox3_Direccion.Size = new System.Drawing.Size(134, 20);
            this.textBox3_Direccion.TabIndex = 14;
            // 
            // label9_Email
            // 
            this.label9_Email.AutoSize = true;
            this.label9_Email.Location = new System.Drawing.Point(24, 304);
            this.label9_Email.Name = "label9_Email";
            this.label9_Email.Size = new System.Drawing.Size(32, 13);
            this.label9_Email.TabIndex = 15;
            this.label9_Email.Text = "Email";
            // 
            // textBox4_Email
            // 
            this.textBox4_Email.Location = new System.Drawing.Point(122, 301);
            this.textBox4_Email.Name = "textBox4_Email";
            this.textBox4_Email.Size = new System.Drawing.Size(134, 20);
            this.textBox4_Email.TabIndex = 16;
            // 
            // label10_Balance
            // 
            this.label10_Balance.AutoSize = true;
            this.label10_Balance.Location = new System.Drawing.Point(24, 339);
            this.label10_Balance.Name = "label10_Balance";
            this.label10_Balance.Size = new System.Drawing.Size(46, 13);
            this.label10_Balance.TabIndex = 17;
            this.label10_Balance.Text = "Balance";
            // 
            // textBox5_Balance
            // 
            this.textBox5_Balance.Location = new System.Drawing.Point(122, 336);
            this.textBox5_Balance.Name = "textBox5_Balance";
            this.textBox5_Balance.Size = new System.Drawing.Size(134, 20);
            this.textBox5_Balance.TabIndex = 18;
            this.textBox5_Balance.TextChanged += new System.EventHandler(this.TextBox5_Balance_TextChanged);
            this.textBox5_Balance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox5_Balance_KeyPress);
            // 
            // label11_Sexo
            // 
            this.label11_Sexo.AutoSize = true;
            this.label11_Sexo.Location = new System.Drawing.Point(24, 375);
            this.label11_Sexo.Name = "label11_Sexo";
            this.label11_Sexo.Size = new System.Drawing.Size(31, 13);
            this.label11_Sexo.TabIndex = 19;
            this.label11_Sexo.Text = "Sexo";
            this.label11_Sexo.Click += new System.EventHandler(this.Label10_Sexo_Click);
            // 
            // button2_Nuevo
            // 
            this.button2_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("button2_Nuevo.Image")));
            this.button2_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2_Nuevo.Location = new System.Drawing.Point(73, 424);
            this.button2_Nuevo.Name = "button2_Nuevo";
            this.button2_Nuevo.Size = new System.Drawing.Size(78, 46);
            this.button2_Nuevo.TabIndex = 22;
            this.button2_Nuevo.Text = "Nuevo";
            this.button2_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2_Nuevo.UseVisualStyleBackColor = true;
            this.button2_Nuevo.Click += new System.EventHandler(this.Button2_Nuevo_Click);
            // 
            // button3_Guardar
            // 
            this.button3_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("button3_Guardar.Image")));
            this.button3_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3_Guardar.Location = new System.Drawing.Point(166, 424);
            this.button3_Guardar.Name = "button3_Guardar";
            this.button3_Guardar.Size = new System.Drawing.Size(91, 46);
            this.button3_Guardar.TabIndex = 23;
            this.button3_Guardar.Text = "Guardar";
            this.button3_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3_Guardar.UseVisualStyleBackColor = true;
            this.button3_Guardar.Click += new System.EventHandler(this.Button3_Guardar_Click);
            // 
            // button4_Eliminar
            // 
            this.button4_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("button4_Eliminar.Image")));
            this.button4_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4_Eliminar.Location = new System.Drawing.Point(272, 424);
            this.button4_Eliminar.Name = "button4_Eliminar";
            this.button4_Eliminar.Size = new System.Drawing.Size(82, 46);
            this.button4_Eliminar.TabIndex = 24;
            this.button4_Eliminar.Text = "Eliminar";
            this.button4_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4_Eliminar.UseVisualStyleBackColor = true;
            this.button4_Eliminar.Click += new System.EventHandler(this.Button4_Eliminar_Click);
            // 
            // label7_FechaNac
            // 
            this.label7_FechaNac.AutoSize = true;
            this.label7_FechaNac.Location = new System.Drawing.Point(24, 236);
            this.label7_FechaNac.Name = "label7_FechaNac";
            this.label7_FechaNac.Size = new System.Drawing.Size(93, 13);
            this.label7_FechaNac.TabIndex = 25;
            this.label7_FechaNac.Text = "Fecha Nacimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 230);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 20);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // numericUpDown1_id
            // 
            this.numericUpDown1_id.Location = new System.Drawing.Point(122, 29);
            this.numericUpDown1_id.Name = "numericUpDown1_id";
            this.numericUpDown1_id.Size = new System.Drawing.Size(134, 20);
            this.numericUpDown1_id.TabIndex = 27;
            this.numericUpDown1_id.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seleccione",
            "Masculino",
            "Femenino"});
            this.comboBox1.Location = new System.Drawing.Point(122, 372);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // rEstudiantes
            // 
            this.ClientSize = new System.Drawing.Size(379, 482);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1_id);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7_FechaNac);
            this.Controls.Add(this.button4_Eliminar);
            this.Controls.Add(this.button3_Guardar);
            this.Controls.Add(this.button2_Nuevo);
            this.Controls.Add(this.label11_Sexo);
            this.Controls.Add(this.textBox5_Balance);
            this.Controls.Add(this.label10_Balance);
            this.Controls.Add(this.textBox4_Email);
            this.Controls.Add(this.label9_Email);
            this.Controls.Add(this.textBox3_Direccion);
            this.Controls.Add(this.label8_Direccion);
            this.Controls.Add(this.maskedTextBox3_Cedula);
            this.Controls.Add(this.label6_Cedula);
            this.Controls.Add(this.maskedTextBox2_Telefono);
            this.Controls.Add(this.label5_Telefono);
            this.Controls.Add(this.textBox2_Apellidos);
            this.Controls.Add(this.label4_Apellidos);
            this.Controls.Add(this.textBox1_Nombre);
            this.Controls.Add(this.label3_Nombre);
            this.Controls.Add(this.maskedTextBox1_Matricula);
            this.Controls.Add(this.label2_Matricula);
            this.Controls.Add(this.button1_buscar);
            this.Controls.Add(this.label1_id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Estudiante";
            this.Load += new System.EventHandler(this.REstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void REstudiantes_Load(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label10_Sexo_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TextBox5_Balance_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox5_Balance_KeyPress(object sender, KeyPressEventArgs e)
        {
           // val.soloNumeros(e);
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Button3_Guardar_Click(object sender, EventArgs e)
        {

            Estudiantes estudiante;
              bool paso = false;

              if (!Validate())
                  return;

              estudiante = LlenaClase();
              Limpiar();

              //Determinar si es guardar o modificar
              if (numericUpDown1_id.Value == 0)
                  paso = EstudiantesBLL.Guardar(estudiante);
              else
              {
                  if (!ExisteEnLaBaseDeDatos())
                  {
                      MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      return;
                  }
                  paso = EstudiantesBLL.Modificar(estudiante);
              }

              //Informar el resultado
              if (paso)
                  MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
              else
                  MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }


          private bool ExisteEnLaBaseDeDatos()
       {
           Estudiantes estudiante = EstudiantesBLL.Buscar((int)numericUpDown1_id.Value);

           return (estudiante != null);
       }

        private void Button1_buscar_Click(object sender, EventArgs e)
        {
            int id;
            Estudiantes estudiante = new Estudiantes();
            int.TryParse(numericUpDown1_id.Text, out id);

            Limpiar();

           estudiante = EstudiantesBLL.Buscar(id);

            if (estudiante != null)
            {
                MessageBox.Show("Estudiante Encontrado");
                LlenaCampo(estudiante);
            }
            else
            {
                MessageBox.Show("Estudiante no Encontado");
            }
        }

        private void Button4_Eliminar_Click(object sender, EventArgs e)
        {

            int id;
            int.TryParse(numericUpDown1_id.Text, out id);


            if (numericUpDown1_id.Value == 0)
            {
                MessageBox.Show("Esta Vacio");

            }
            else if (EstudiantesBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado");
            }
            else
            {
                errorProvider1.SetError(numericUpDown1_id, "No se puede eliminar una persona que no existe");
                errorProvider1.Clear();
                Limpiar();
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Matricula_Click(object sender, EventArgs e)
        {

        }
    }
 }



 

