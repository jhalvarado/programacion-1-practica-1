using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_V1_4.Central
{
    public class Celular : Telefono
    {

        private List<Telefono> elements = new List<Telefono>();

        public Celular(string numero, int tarifa)
            : base(numero, tarifa)
        {
        }

        public override void Add(Telefono assembly)
        {

            elements.Add(assembly);
            throw new Exception("Single Part objects have no children.");
        }

        public override void Remove(Telefono assembly)
        {
            elements.Remove(assembly);
            throw new Exception("Single Part objects have no children.");
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
