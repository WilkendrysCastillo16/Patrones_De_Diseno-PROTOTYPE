using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_II_Tarea_3
{
    class Alumno:IClonar_Alumno
    {
        public string Nombre_Alumno { get; set; }
        public string apellido_Alumno { get; set; }
        public int matricula_Alumno { get; set; }
        public string cedula_Alumno { get; set; }
        public double telefono_Alumno { get; set; }
        public string Direccion_Alumno { get; set; }

        public Padre Nombre_Padre { get; set; }
        public Padre Telefono_Padre { get; set; }

        public Padre Puente_padre;
        public Alumno()
        {
            Puente_padre = new Padre();
        }
        public Alumno clonar()
        {
            Alumno clon = new Alumno();
            clon.Nombre_Alumno = Nombre_Alumno;
            clon.apellido_Alumno = apellido_Alumno;
            clon.matricula_Alumno = matricula_Alumno;
            clon.cedula_Alumno = cedula_Alumno;
            clon.telefono_Alumno = telefono_Alumno;
            clon.Direccion_Alumno = Direccion_Alumno;

            clon.Puente_padre = new Padre();

            clon.Puente_padre.Nombre_Padre = Puente_padre.Nombre_Padre;
            clon.Puente_padre.Telefono_Padre = Puente_padre.Telefono_Padre;
            return clon;
        }

        public override string ToString()
        {

            return "nombre:" + Nombre_Alumno + "\napellido:" + apellido_Alumno + "\nmatricula:" + matricula_Alumno + "\nCedula:" + cedula_Alumno +
                             "\nTelefono:" + telefono_Alumno + "\nDireccion:" + Direccion_Alumno + "\nNombre del padre:" + Puente_padre.Nombre_Padre
                            + "\nTelefono del padre:" + Puente_padre.Telefono_Padre + "\n........................";
        }

        public void Conctacto_Alumno()
        {
            Console.WriteLine("\nMis via de contacto son:" + telefono_Alumno);
        }

        public void Informacion_Cedula_Alumno()
        {
            Console.WriteLine("\nUnos de los requisitos para transcurrir en el ITLA es la cedula de identidad |" + cedula_Alumno);
        }

        public void relacion_Alumno()
        {
            Console.WriteLine("\nEl alumno " + Nombre_Alumno + " es el hijo del padre " + Puente_padre.Nombre_Padre);
        }
    }
}
