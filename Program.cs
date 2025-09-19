using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void objetos()
            {
                List<items> lista = new List<items>();

                lista.Add(new items("reloj cucú", 23));
                lista.Add(new items("ouija", 40));
                foreach (var items in lista) 
                {
                    Console.WriteLine(items);
                }
            }

            Console.WriteLine("cuanto posees?");
            float dinero = float.Parse(Console.ReadLine());
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("1.comprar algo?");
                Console.WriteLine("2.finalizar compra");
                float respuesta = float.Parse(Console.ReadLine());
                switch (respuesta)
                {
                    case 1:
                       objetos();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
