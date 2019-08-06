﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoSennova
{
     public class Proyecto
    {
        #region Atributos

        #endregion
        #region Propiedades
        public string  Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }
        #endregion
        #region Constructores
        public Proyecto(string nombre, double codigo, string area, int duracion )
        {
            Nombre = nombre;
            Codigo = codigo;
            Area = area;
            Duracion = duracion;
        }
        public Proyecto()
        {

        }
        public Proyecto(string area , int duracion)
        {
            Area = area;
            Duracion = duracion;
        }

        #endregion
        #region Metodos
        public void IngresarProyecto()
        {
            Console.WriteLine("Ingrese el Nombre del Proyecto");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Codigo");
            Codigo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Area del Proyecto");
            Area = Console.ReadLine();
            Console.WriteLine("Ingrese la Duracion  del Proyecto");
            Duracion = int.Parse(Console.ReadLine());
          

        }
        public void ImprimirProyecto()
        {
            Console.WriteLine($"El nombre del Proyecto es:{Nombre}");
            Console.WriteLine($"El codigo del Proyecto es:{Codigo}");
            Console.WriteLine($"El area del Proyecto es:{Area}");
            Console.WriteLine($" La duracion del proyecto es: {Duracion}");
        }

        #endregion
    }

}
