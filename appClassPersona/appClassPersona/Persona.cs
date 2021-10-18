using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassPersona
{
    class Persona
    {
        protected string nombre;
        protected string fechadenacimiento;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public Persona()
        {
           nombre = "";
        }

        public string Fechadenacimiento
       
        {
           get
           {
        return fechadenacimiento;
           }
           set
            {
        fechadenacimiento = value;
            }
        }
        public Persona(string nombre,string fechadenacimiento)
        {
            this.nombre = nombre;
            this.fechadenacimiento = fechadenacimiento;
        }
    }
    public override string ToString()
    {
        return   "Nombre" + nombre + "Fechadenacimiento" + fechadenacimiento;
    }
}

