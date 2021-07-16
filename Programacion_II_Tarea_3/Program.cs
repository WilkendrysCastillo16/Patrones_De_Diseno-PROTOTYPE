using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Programacion_II_Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumno alumno0 = new Alumno();
            Padre padre0 = new Padre();

            //Datos Originales 
            alumno0.Nombre_Alumno = "Wilkendrys";
            alumno0.apellido_Alumno = "Castillo";
            alumno0.matricula_Alumno = 20208571;
            alumno0.cedula_Alumno = "402-3358919-7";
            alumno0.telefono_Alumno = 8498789733;
            alumno0.Direccion_Alumno = "Santo Domingo,distrino nacional, LB. 2E";
            alumno0.Puente_padre.Nombre_Padre = "Wilkin";
            alumno0.Puente_padre.Telefono_Padre = 80971493771;
            Console.WriteLine("---------------------------------------");

            padre0.ID_Padre = 01;
            padre0.Nombre_Padre = alumno0.Puente_padre.Nombre_Padre;
            padre0.apellido_Padre = alumno0.apellido_Alumno;
            padre0.cedula_Padre = "001-18967234-9";
            padre0.Telefono_Padre = alumno0.Puente_padre.Telefono_Padre;
            padre0.Email_Padre = "wc@gmail.com";




            //ClON 1 de alumnos y padre 
            Alumno alumno1 = (Alumno)alumno0.clonar();
            Padre padre1 = (Padre)padre0.Clone();

            alumno1.Nombre_Alumno = "Saviel";
            alumno1.apellido_Alumno = "Tejeda";
            alumno1.matricula_Alumno = 20198976;
            alumno1.cedula_Alumno = "402-3358919-7";
            alumno1.telefono_Alumno = 8092289732;
            alumno1.Direccion_Alumno = "Santo Domingo oeste,herrera, km.31";
            alumno1.Puente_padre.Nombre_Padre = "Orlando";
            alumno1.Puente_padre.Telefono_Padre = 8496445434;


            padre1.ID_Padre = 02;
            padre1.Nombre_Padre = alumno1.Puente_padre.Nombre_Padre;
            padre1.apellido_Padre = alumno1.apellido_Alumno;
            padre1.cedula_Padre = "402-93848571-7";
            padre1.Telefono_Padre = alumno1.Puente_padre.Telefono_Padre;
            padre1.Email_Padre = "SCCT@gmail.com";

            //CLON 2 de Alumnos y padre
            Alumno alumno2 = (Alumno)alumno0.clonar();
            Padre padre2 = (Padre)padre0.Clone();

            alumno2.Nombre_Alumno = "David";
            alumno2.apellido_Alumno = "Caceres";
            alumno2.matricula_Alumno = 20181243;
            alumno2.cedula_Alumno = "402-34512398-9";
            alumno2.telefono_Alumno = 8492348765;
            alumno2.Direccion_Alumno = "Santo Domingo oeste,herrera, km.31";
            alumno2.Puente_padre.Nombre_Padre = "Carlos";
            alumno2.Puente_padre.Telefono_Padre = 80971497274;


            padre2.ID_Padre = 03;
            padre2.Nombre_Padre = alumno2.Puente_padre.Nombre_Padre;
            padre2.apellido_Padre = alumno2.apellido_Alumno;
            padre2.cedula_Padre = "402-24637867-9";
            padre2.Telefono_Padre = alumno2.Puente_padre.Telefono_Padre;
            padre2.Email_Padre = "DCD@gmail.com";

            //CLON 3 de Alumnos y padre
            Alumno alumno3 = (Alumno)alumno0.clonar();
            Padre padre3 = (Padre)padre0.Clone();

            alumno3.Nombre_Alumno = "Wilmelia";
            alumno3.apellido_Alumno = "Morillo";
            alumno3.matricula_Alumno = 20192345;
            alumno3.cedula_Alumno = "402-12093486-7";
            alumno3.telefono_Alumno = 8492348765;
            alumno0.Direccion_Alumno = "San jose de Ocoa, Barrio San antonio, calle L.26";
            alumno3.Puente_padre.Nombre_Padre = "ALMONTE";
            alumno3.Puente_padre.Telefono_Padre = 8097149774;

            padre3.ID_Padre = 04;
            padre3.Nombre_Padre = alumno2.Puente_padre.Nombre_Padre;
            padre3.apellido_Padre = alumno2.apellido_Alumno;
            padre3.cedula_Padre = "001-345698765-0";
            padre3.Telefono_Padre = alumno2.Puente_padre.Telefono_Padre;
            padre3.Email_Padre = "WMA@gmail.com";


            //Mostrando por consola Los datos de alumno
            //alumno0.Original_Alumno();
            Console.WriteLine("..........CLASE ALUMNO..............");
            Console.WriteLine(alumno0.ToString());
            alumno0.Conctacto_Alumno();
            alumno0.Informacion_Cedula_Alumno();
            alumno0.relacion_Alumno();
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("..........CLASE ALUMNO..............");
            Console.WriteLine(alumno0.ToString());
            Console.WriteLine(alumno1.ToString());
            Console.ReadKey();
            Console.Clear();

         
            Console.WriteLine("..........CLASE ALUMNO..............");
            Console.WriteLine(alumno0.ToString());
            Console.WriteLine(alumno2.ToString());
            Console.ReadKey();
            Console.Clear();
 
            Console.WriteLine("..........CLASE ALUMNO..............");
            Console.WriteLine(alumno0.ToString());
            Console.WriteLine(alumno3.ToString());
            Console.ReadKey();
            Console.Clear();

            //Mostrando por consola Los datos de padre
            
            Console.WriteLine("..........CLASE PADRE..............");
            Console.WriteLine(padre0.ToString());
            padre0.Contacto_Padre();
            padre0.Informacion_Cedula_Padre();
            padre0.relacion_Padre();
            Console.ReadKey();
            Console.Clear();
           
            Console.WriteLine("..........CLASE PADRE..............");
            Console.WriteLine(padre0.ToString());
            Console.WriteLine(padre1.ToString());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("..........CLASE PADRE..............");
            Console.WriteLine(padre0.ToString());
            Console.WriteLine(padre2.ToString());
          
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("..........CLASE PADRE..............");
            Console.WriteLine(padre0.ToString());
            Console.WriteLine(padre3.ToString());
      

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Guardando Datos en archivo TXT");
            Console.ReadKey();

            //Guardando en archivo txt, estara almacenado en la carpeta Bin\\Debug

            StreamWriter archivoalumno = File.AppendText("CLASE_ALUMNO.txt");
            string guard0 = "..........CLASE ALUMNO..............";
            string guardalumno0 = alumno0.ToString();
            string guardalumno1 = alumno1.ToString();
            string guardalumno2 = alumno2.ToString();
            string guardalumno3 = alumno3.ToString();

            archivoalumno.WriteLine(guard0);
            archivoalumno.WriteLine(guardalumno0);
            archivoalumno.WriteLine(guardalumno1);
            archivoalumno.WriteLine(guardalumno2);
            archivoalumno.WriteLine(guardalumno3);
            archivoalumno.Close();

            StreamWriter archivopadre = File.AppendText("CLASE_PADRE.txt");

            string Guard1 = "..........CLASE PADRE..............";
            string Guardpadre = padre0.ToString();
            string Guardpadre1 = padre1.ToString();
            string Guardpadre2 = padre2.ToString();
            string Guardpadre3 = padre3.ToString();

            archivopadre.WriteLine(Guard1);
            archivopadre.WriteLine(Guardpadre);
            archivopadre.WriteLine(Guardpadre1);
            archivopadre.WriteLine(Guardpadre2);
            archivopadre.WriteLine(Guardpadre3);
            archivopadre.Close();
        }
    }
}
