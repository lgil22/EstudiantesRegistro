namespace RegistroEstudiantes.UI
{
    public partial class rEstudiantes
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

        private System.Windows.Forms.Label label1_id;
        private System.Windows.Forms.Button button1_buscar;
        private System.Windows.Forms.Label label2_Matricula;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1_Matricula;
        private System.Windows.Forms.Label label3_Nombre;
        private System.Windows.Forms.TextBox textBox1_Nombre;
        private System.Windows.Forms.Label label4_Apellidos;
        private System.Windows.Forms.TextBox textBox2_Apellidos;
        private System.Windows.Forms.Label label5_Telefono;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2_Telefono;
        private System.Windows.Forms.Label label6_Cedula;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3_Cedula;
        private System.Windows.Forms.Label label8_Direccion;
        private System.Windows.Forms.TextBox textBox3_Direccion;
        private System.Windows.Forms.Label label9_Email;
        private System.Windows.Forms.TextBox textBox4_Email;
        private System.Windows.Forms.Label label10_Balance;
        private System.Windows.Forms.TextBox textBox5_Balance;
        private System.Windows.Forms.Label label11_Sexo;
        private System.Windows.Forms.Button button2_Nuevo;
        private System.Windows.Forms.Button button3_Guardar;
        private System.Windows.Forms.Button button4_Eliminar;
        private System.Windows.Forms.Label label7_FechaNac;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1_id;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}