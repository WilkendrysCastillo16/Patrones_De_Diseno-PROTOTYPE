using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_II_Tarea_3
{
    class Padre:ICloneable
    {
        public int ID_Padre { get; set; }
        public string Nombre_Padre { get; set; }
        public string apellido_Padre { get; set; }
        public string cedula_Padre { get; set; }
        public double Telefono_Padre { get; set; }
        public string Email_Padre { get; set; }



        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {

            return "ID:" + ID_Padre + "\nNombre:" + Nombre_Padre + "\nApellido:" + apellido_Padre + "\nCedula:" + cedula_Padre +
                             "\nTelefono:" + Telefono_Padre + "\nEmail:" + Email_Padre + "\n........................";

        }

        public void Contacto_Padre()
        {
            Console.WriteLine("\nMis via de contacto son:" + Telefono_Padre + " | " + Email_Padre);
        }

        public void Informacion_Cedula_Padre()
        {
            Console.WriteLine("\nUnos de los requisitos para transcurrir en el ITLA es la cedula de identidad |" + cedula_Padre);
        }

        public void relacion_Padre()
        {
            Console.WriteLine("\nCada Alumno tiene un padre y/o tutor");
        }
        
    }
}
