using System;
using System.IO;

namespace Tarea_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string nombre, apellido, fNacimiento, sexo, eCivil;
            int edad;
            double gMaxCena;
            Console.WriteLine("Bienvenido al creador de Base de Datos-2020!");
            Console.WriteLine("Introduzca la siguiente informacion: ");
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Edad: ");
            edad = Int32.Parse(Console.ReadLine());
            Console.Write("Fecha de Nacimiento: (dd/mm/aaaa) ");
            fNacimiento = Console.ReadLine();
            Console.Write("Cuanto es el maximo que ha gastado en una cena?: ");
            gMaxCena = Double.Parse(Console.ReadLine());
            Console.Write("Sexo: ");
            sexo = Console.ReadLine();
            Console.Write("Estado Civil: ");
            eCivil = Console.ReadLine();

            //Presentando Datos Ingresados
            Console.WriteLine($"\n\tHola {nombre} {apellido}, tu edad es {edad} anios y nacieste en {fNacimiento}.");
            Console.WriteLine($"\tTu sexo es {sexo} y tu estado civil es {eCivil}.");
            Console.WriteLine($"\tLo maximo que has gastado en una cena es: {gMaxCena}");*/

            GenerarTxt();
            AdicionarInfoAlTxt();
            LeerInfoTxt();

            
        }
        static void GenerarTxt()
        {
            //Creando el archivo
            string rutaCompleta = @"/Koro_Storage/INF_411/Tarea_2/archivo.txt";
            string texto = "Hola, mundo!\n";

            //Se crea el archivo
            using (StreamWriter mylogs = File.AppendText(rutaCompleta))
            {
                //Se adiciona informacion  y fecha
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                string strDate = Convert.ToDateTime(dateTime).ToString("dd/MM/yyyy HH:mm:ss ");
                mylogs.WriteLine(texto + strDate);
                mylogs.Close();
                
                
            }
        }

        //para escribir en el archivo
        static void AdicionarInfoAlTxt()
        {
            string rutaCompleta = @"/Koro_Storage/INF_411/Tarea_2/archivo.txt";
            string texto = "Hola de nuevo";
            using (StreamWriter file = new StreamWriter(rutaCompleta, true))
            {
                file.WriteLine(texto); // se agrega informacion al documento
                file.Close();
            }
        }

        //para leer la informacion al archivo
        static void LeerInfoTxt()
        {
            string rutaCompleta = @"/Koro_Storage/INF_411/Tarea_2/archivo.txt";
            string line = "";
            using(StreamReader file = new StreamReader(rutaCompleta))
            {
                while((line = file.ReadLine()) != null) //Leer linea por linea
                {
                    Console.WriteLine(line);
                }

                //Otra foram de leer todo el archivo
                line = file.ReadToEnd();
                Console.WriteLine(line);
                file.Close();
            }
        }
    }
}
