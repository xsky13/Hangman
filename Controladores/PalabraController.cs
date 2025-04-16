using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Linq;

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
            if (palabra == null || palabra == "")
            {
                Console.Clear();
                Console.WriteLine("No se ingreso nada");
                Console.WriteLine("Apriete cualquier tecla para continuar");
                Console.ReadKey(true);
                Agregar();
            }

            if (!Regex.IsMatch(palabra, @"^[a-zA-ZáéíóúüñÁÉÍÓÚÜÑ]+$"))
            {
                Console.Clear();
                Console.WriteLine("La palabra solo puede contener letras");
                Console.WriteLine("Apriete cualquier tecla para continuar");
                Console.ReadKey(true);
                Agregar();
            }

            Palabras = Palabras.Append(palabra).ToArray();
            Console.Clear();
            Program.ImprimirTextoCentrado("Se agrego " + palabra);

            string[][] filas = {
                new string[] {"Boton", "Accion" },
                new string[] {"1", "Volver al menu" },
                new string[] {"2", "Añadir otra palabra" },
            };

            Program.ImprimirTabla(filas);
            Console.WriteLine();
            Program.ImprimirTextoCentrado("Eliga una opcion: ");

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
