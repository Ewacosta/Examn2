using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2DAE
{
    // la misma explicacin del FormProfesor aplica al Estudiante con la diferencia de unos atributos.
    public partial class FormEstudiante : Form
    {
        Estudiante objEstudiante = new Estudiante();
        public FormEstudiante()
        {
            InitializeComponent();
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void mostrarDatos()
        {
            objEstudiante.Nombres = textNombres.Text;
            objEstudiante.Apellidos = textApellidos.Text;
            objEstudiante.FechaNacimiento = dateTimePicker2.Value;
            string fechaNacimientoForma = objEstudiante.FechaNacimiento.ToShortDateString();
            objEstudiante.Edad = int.Parse(lblEdad.Text);
            objEstudiante.Ciclo = int.Parse(textCiclo.Text);
            objEstudiante.Cum = double.Parse(textCum.Text);
            objEstudiante.Carrera = textCarrera.Text;

            string informacionEstudiante = objEstudiante.mostrarInformacion();

            MessageBox.Show("Datos del profesor: \n" +
                            "Nombre: " + objEstudiante.nombreCompleto() +
                            "\n Fecha de Nacimiento:" + fechaNacimientoForma +
                            informacionEstudiante);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarDatos();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dateTimePicker2.Value;
            int edad = calcularEdad(fechaNacimiento);
            lblEdad.Text = edad.ToString();

        }
        private int calcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }
    }
}
