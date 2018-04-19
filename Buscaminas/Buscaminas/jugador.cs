using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class jugador
    {
        string nombre;
        int puntaje;
        string dificultad;

        public jugador(string nombre, int puntaje, string dificultad)
        {
              this.nombre = nombre;
              this.puntaje = puntaje;
              this.dificultad = dificultad;
              
        }

        public string verJugador()
        {
            return this.nombre;
        }

        public string verPuntaje()
        {
            return this.puntaje+"";
        }
        public string verDificultad()
        {
            return this.dificultad;
        }
    }
}
