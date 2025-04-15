using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Controladores
{
    internal class AhorcadoController
    {
        
        public static void Dibujar()
        {
            // bruno
        }

        public static void Ingresar()
        {
            // abiel
            Console.Write("Ingresa letra: ");
            string nuevaLetra = Console.ReadLine();
            PalabraController.Verificar(nuevaLetra);
        }
    }
}
