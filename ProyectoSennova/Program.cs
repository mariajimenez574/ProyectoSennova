using System;

namespace ProyectoSennova
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int puntaje=0;
            Proyecto miProyecto = new Proyecto();
            Proyecto miProyecto2 = new Proyecto();
            Proyecto miProyecto3 = new Proyecto();
            Proyecto miProyecto4 = new Proyecto("Realidad Aumentada", 14798, "Sistemas", 17);
            Proyecto miProyecto5 = new Proyecto("Talento Humano",5);
            //miProyecto3.IngresarProyecto();
            //miProyecto3.ImprimirProyecto();
            //miProyecto4.ImprimirProyecto();
            miProyecto5.ImprimirProyecto();

            //miProyecto.Area = "Sistemas";
            //miProyecto.Codigo = 12000;
            //miProyecto.Duracion = 13;
            //miProyecto.Nombre = "Desarrollo internet de las cosas IOT";
            //miProyecto2.Area = "Redes";
            //miProyecto2.Codigo = 16000;
            //miProyecto2.Duracion = 20;
            //miProyecto2.Nombre = "Conexion de Redes";
            //Console.WriteLine($"Area:{miProyecto.Area}");
            //Console.WriteLine($"Codigo:{miProyecto.Codigo}");
            //Console.WriteLine($"Duracion: {miProyecto.Duracion}");
            //Console.WriteLine($"Nombre:{miProyecto.Nombre}");
            //Console.ReadLine();
            //Console.WriteLine($"Area:{miProyect2.Area}");
            //Console.WriteLine($"Codigo:{miProyecto2.Codigo}");
            //Console.WriteLine($"Duracion: {miProyecto2.Duracion}");
            //Console.WriteLine($"Nombre:{miProyecto2.Nombre}");
            Console.ReadLine();

        }
    }
}
