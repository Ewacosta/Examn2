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
    //los formularios solicitan la informacion requerida y tambien solicita ingresar la fecha de nacimiento .
    // al seleccionar la fecha de nacimiento el sistema imprime automaticamente la fecha actual del usuario
    public partial class FormProfesor : Form
    {
        Profesor objProfesor = new Profesor();
        public FormProfesor()
        {
            InitializeComponent();

            //aqui se inicializa la suscripcion para poder calcular la edad del usuario al seleccionar la fecha cuando nacio

            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
        }

        private void DateTimePicker1_ValueChanged(object? sender, EventArgs e)
        {
            DateTime fechaNacimiento = dateTimePicker1.Value;
            int edad = calcularEdad(fechaNacimiento);
            lblEdad.Text = edad.ToString();

        }

        // se hace una resta de años, año de nacimiento y el año actual 
        private int calcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // calcula si el usuario ya cumplio años o si aun le falta para cumplir

            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormProfesor_Load(object sender, EventArgs e)
        {

        }


        //metodo publico para la captura de los datos
        //se hace un formateo de fecha para evitar que nos imprima las horas y los minutos.
        public void mostrarDatos()
        {
            objProfesor.Nombres = textNombres.Text;
            objProfesor.Apellidos = textApellidos.Text;
            objProfesor.FechaNacimiento = dateTimePicker1.Value;
            string fechaNacimientoForma = objProfesor.FechaNacimiento.ToShortDateString();
            objProfesor.Edad = int.Parse(lblEdad.Text);
            objProfesor.Titulo = textTitulo.Text;
            objProfesor.CarreraAsignada = textCarrera.Text;
            objProfesor.Salario = double.Parse(textSalario.Text);

            //llamamos al metodo mostrarInformacion de la clase Profesor
            //se le asigna a la variable informacionProfesor y se heredan los datos tanto de la clase perosna como la de profesor.
            //se muestra un mensaje al darle clic al boton de confirmacion con los datos.
            string informacionProfesero = objProfesor.mostrarInformacion();

            MessageBox.Show("Datos del profesor: \n" +
                            "Nombre: " + objProfesor.nombreCompleto() +
                            "\n Fecha de Nacimiento:" + fechaNacimientoForma +
                            informacionProfesero);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //se llama al metodo creado para ejecutarlo en el boton Guardar.
            mostrarDatos();


        }
    }
}
