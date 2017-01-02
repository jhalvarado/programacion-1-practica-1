using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_V1_4.Time
{

    /* Llamada
    * 
    * En nuestra clase llamada, invocamos a la clase "Relojk", para calcular la tarifa de acuerdo a la hora.
    */
    class Llamada : ITelefono
    {

        private string llamada;
        protected double tarifa_1 = 0.03;
        protected double tarifa_2 = 0.01;
        protected int segundos = 0;
        protected int minutos = 5; // AQUI SE PONE LOS MINUTOS DE LA LLAMADA

        public Llamada()
        {
            
        }


        public void Numero(string numero)
        {
            System.Console.WriteLine(numero);

            throw new NotImplementedException();
        }

        public double Tarifa(int horas)
        {

            int tarifa = 0;
            Practica_1_V1_4.Time.Reloj reloj = new Practica_1_V1_4.Time.Reloj();

            //INICIO LLAMADA
            String time = reloj.GetTime(horas, 0, segundos);
            Console.WriteLine("* La llamada se inicio a las : " + time);

            //FIN LLAMADA
            String time2 = reloj.GetTime(horas, minutos, segundos);
            Console.WriteLine("* La llamada se finalizo a las : " + time2);

            //MENSAJES DE LA LLAMADA
            Console.WriteLine("* La llamada duro : " + minutos + " minutos.");

            if (horas >= 8 && horas <= 20)
            {
                Console.WriteLine("* La Tarifa base es de : " + tarifa_1);
                Console.WriteLine("* La Tarifa es de : " + (minutos * 60 * tarifa_1));
            }
            else
            {
                Console.WriteLine("* La Tarifa base es de : " + tarifa_2);
                Console.WriteLine("* La Tarifa es de : " + (minutos * 60 * tarifa_2));
            }

            return tarifa;

            throw new NotImplementedException();
        }
    }
}



