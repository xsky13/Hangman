using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Modelos
{
    public class Personaje
    {
        public bool Cabeza { get; set; }
        public bool Cuerpo { get; set; }
        public bool BrazoIzquierda { get; set; }
        public bool BrazoDerecha { get; set; }
        public bool PiernaIzquierda { get; set; }
        public bool PiernaDerecha { get; set; }

        public Personaje()
        {
            Cabeza = true;
            Cuerpo = true;
            BrazoIzquierda = true;
            BrazoDerecha = true;
            PiernaIzquierda = true;
            PiernaDerecha = true;
        }
    }
}
