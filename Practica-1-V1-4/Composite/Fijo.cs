using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_V1_4.Central
{
    public class Fijo : Telefono
    {
        private List<Telefono> elements = new List<Telefono>();

        public Fijo(string numero, int tarifa)
            : base(numero, tarifa)
        {
        }

        public override void Add(Telefono assembly)
        {
            elements.Add(assembly);
        }

        public override void Remove(Telefono assembly)
        {
            elements.Remove(assembly);
        }

        public override void WritePartsList(List<string> list)
        {
            list.Add(Tarifa.ToString() + " - " + Numero);

            foreach (Telefono assembly in elements)
            {
                assembly.WritePartsList(list);
            }
        }



    }
}
