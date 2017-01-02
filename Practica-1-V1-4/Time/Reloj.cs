using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_V1_4.Time
{

    /* Reloj
    * 
    * En nuestra clase Reloj, tiene el metodo "GetTime", que nos devuelve el Time en String
    */
    class Reloj
    {

        private string tiempo;

        public string GetTime(int horas, int minutos, int segundos)
        {
            Time tiempo = new Time();
            return tiempo.GetTime(horas, minutos, segundos);

        }


    }
}



