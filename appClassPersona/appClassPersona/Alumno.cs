using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassPersona
{
    class Alumno : Persona
    {
        protected string matricula;
        public string carrera;

        public string Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula= value;
            }
        }

        public string Carrera
        {
            get
            {
                return carrera;
            }

            set
            {
                carrera = value;
            }
        }
        public Alumno()
        {
            matricula = "";
            carrera = "";
        }

        public Alumno (string matricula, string carrera, string nombre, string fechadenacimiento)
        {
            this.matricula = matricula;
            this.carrera = carrera;
            this.nombre = nombre;
            this.fechadenacimiento = fechadenacimiento;
        }
        public override string ToString()
        {
            return base.ToString() + "Nombre" + nombre + "Fechadenacimiento"+ fechadenacimiento + "Matricula" + matricula + "Carrera" + carrera;
        }
    }
}
