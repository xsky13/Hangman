using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Hangman.Controladores
{
    internal class Palabra
    {
        
        public static string[] Palabras = {};

        public static void Agregar()
        {
            Palabras = new string[] { "manzana", "casa", "arbol","colegio" };
            Console.Clear();
            Console.WriteLine("Ingrese la palabra que quiere agregar");
            string palabra=Console.ReadLine();
            Palabras = Palabras.Append(palabra).ToArray();
        }

        public static string Seleccionar()
        {
            string palabraSeleccionada = "";
            Random random = new Random();
            palabraSeleccionada = Palabras[random.Next(Palabras.Length)];
            return palabraSeleccionada;
        }




















    }
}
