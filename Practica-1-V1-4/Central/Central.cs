using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_V1_4.Central
{
    public class Central
    {
        protected string TextoPlano;
        protected string Out;
        private List<Telefono> elements = new List<Telefono>();
        protected int hora = 23; // AQUI SE PONE LA HORA DE INICIO

        public Central(string texto)
        {
            TextoPlano = texto;
        }

        public void Agregar(string numero, String tipo){

            Fijo telefono = new Fijo(numero, 88);
            elements.Add(telefono);
        }

        public void Eliminar(string numero)
        {

        }

        public void IniciarLlamada(string numero)
        {
            Practica_1_V1_4.Time.Llamada llamada = new Practica_1_V1_4.Time.Llamada();
            Console.WriteLine(llamada.Tarifa(hora));
            
        }

        public double FinalizarLlamada(string numero)
        {

            return 1;
        }

        public string WritePartsList2()
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (var Telefono in elements)
            {
                sb.AppendLine("- " + Telefono.Numero);
            }

            return sb.ToString();
        }

        

    }

}
