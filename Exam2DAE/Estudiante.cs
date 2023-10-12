using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam2DAE
{
    public class Estudiante : Persona
    {
        private int ciclo;
        private double cum;
        private string carrera;

        public Estudiante()
        {
        }

        public int Ciclo { get => ciclo; set => ciclo = value; }
        public double Cum { get => cum; set => cum = value; }
        public string Carrera { get => carrera; set => carrera = value; }

                
            public string mostrarInformacion()
            {
                string informacion =

                                   "\n Edad: " + Edad +
                                   "\n Ciclo: " + Ciclo +
                                   "\n CUM: " + Cum +
                                   "\n Carrera: " + Carrera;
            return informacion;
            }

            
        

    }
}