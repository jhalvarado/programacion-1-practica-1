using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_V1_4.Central
{

    /* Composite
     * 
     * Utilizamos composite para los numeros de telefonos, fijo , celular, segun corresponda.
     * 
     * 
     * Segun el pdf : Se necesita definir una estructura y manejo de una relación de objetos de un mismo tipo dentro de una aplicación. Ejemplo: Lista de Piezas de Manufactura.
     */

    public abstract class Telefono
    {
        public string Numero;
        protected int Tarifa;

        public Telefono(string numero, int tarifa)
        {
            Numero = numero;
            Tarifa = tarifa;
        }

        public abstract void Add(Telefono assembly);
        public abstract void Remove(Telefono assembly);
        public abstract void WritePartsList(List<string> list);
    }
}
