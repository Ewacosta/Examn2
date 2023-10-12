using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam2DAE
{
    public class Profesor : Persona
    {
        private string titulo;
        private string carreraAsignada;
        private double salario;

        public Profesor()
        {
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string CarreraAsignada { get => carreraAsignada; set => carreraAsignada = value; }
        public double Salario { get => salario; set => salario = value; }

        public string mostrarInformacion()
        {
           string informacion =
                              
                              "\n Edad: " + Edad +
                              "\n Titulo: " + Titulo +
                              "\n Carrera asignada: " + CarreraAsignada +
                              "\n Salario: S" + Salario;
            return informacion;
        }
        

        
    }
}