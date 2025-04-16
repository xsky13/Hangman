using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Hangman.Controladores
{
    internal class PalabraController
    {
        
        public static string[] Palabras = { "manzana", "casa", "arbol", "colegio" };
        public static string palabra = "";

        public static void Agregar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la palabra que quiere agregar");
            string palabra = Console.ReadLine();
            Palabras = Palabras.Append(palabra).ToArray();
            Console.WriteLine("Se agrego " + palabra);
            Console.WriteLine("1 - Volver al menu");
            Console.WriteLine("2 - Añadir otra palabra");
            int nroOpcion = int.Parse(Console.ReadLine());
            switch (nroOpcion) 
            { 
                case 1: Program.Menu(); break;
                case 2: Agregar(); break;
            }
        }

        public static string Seleccionar()
        {
            string palabraSeleccionada = "";
            Random random = new Random();
            palabraSeleccionada = Palabras[random.Next(Palabras.Length)];
            //Console.WriteLine(palabraSeleccionada);
            return palabraSeleccionada;
        }

        public static int[] Verificar(string letraIngresada)
        {
            int[] values = {};
            for (int i = 0; i < palabra.Length; i++)
            {
                if (letraIngresada == palabra[i].ToString())
                {
                    values = values.Append(i).ToArray();
                }
            }

            if (values.Length == 0)
            {
                
                if (AhorcadoController.letrasEquivocadas.Where(l => l == letraIngresada).ToArray().Length == 0)
                {
                    AhorcadoController.letrasEquivocadas = AhorcadoController.letrasEquivocadas.Append(letraIngresada).ToArray();
                    AhorcadoController.cantidadErrores++;
                }
            }
            return values;
        }
    }
}
