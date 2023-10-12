using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Erick Willson Acosta Sandoval 031823
namespace Exam2DAE
    
{
    public partial class FormInicio : Form
    {
        //este es el formulario de inicio, el cual le solicita ingresas la ocupacion si es profesor o estudiante
        //al seleccionar la opcion correspondiente lo lleva al formulario respectivo

        public FormInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string seleccion = comboBox1.SelectedItem as string;

            if (seleccion == "Profesor")
            {
                FormProfesor formProfesor = new FormProfesor();
                formProfesor.Show();
            }
            else if (seleccion == "Estudiante")
            {
                FormEstudiante formEstudiante = new FormEstudiante();
                formEstudiante.Show();
            }
        }
    }
}
