using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practica_1_V1_4
{

    /* Program
    * 
    * En nuestra clase Inicial, para ejecutar el proyecto
    */
    class Program
    {
        static void Main(string[] args)
        {

            Practica_1_V1_4.Central.Central test = new Practica_1_V1_4.Central.Central("test");

            Console.WriteLine("========== AGREGAR NUMEROS ==============");
            test.Agregar("966342752", "celular");
            test.Agregar("987984453", "celular");
            test.Agregar("5432121", "fijo");

            Console.WriteLine("========== LISTAR NUMEROS ==============");
            Console.WriteLine(test.WritePartsList2());

            Console.WriteLine("========== INICIAR LLAMADA A NUMERO:: 966342752 ==============");
            test.IniciarLlamada("666");

            Console.ReadKey();
        }
    }
}
