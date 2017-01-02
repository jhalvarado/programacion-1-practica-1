using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_V1_4.Time
{
    class Time
    {

        private string tiempo;

        public Time()
        {
            
        }

        public string GetTime(int horas, int minutos, int segundos)
        {

            TimeSpan timeSpan = new TimeSpan(horas, minutos, segundos);
            return timeSpan.ToString();

        }



    }
}



