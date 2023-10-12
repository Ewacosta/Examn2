using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam2DAE
{
    public class Persona
    {
        private int edad;
        private string nombres;
        private string apellidos;
        private DateTime fechaNacimiento;

        public Persona()
        {
        }

        public int Edad { get => edad; set => edad = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public string nombreCompleto()
        {
            return Nombres + " " + Apellidos;
        }


    }
} 