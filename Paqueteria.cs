using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        //Dado nombre del medicamento, fecha de empacado, fecha de vencimiento, número inicial de lote
        //y cantidad de lotes a empacar Imprima la viñeta para cada caja con el nombre del medicamento,
        //fecha de empacado y vencimiento, número de lote y número de caja. (son 5 cajas por lote)
        static void Main(string[] args)
        {
            Textos.IP("Control de Medicinas");
            Procesos.Programa();
        }
    }

    class Procesos
    {
        public static void Programa()
        {
            Textos.IP("Ingrese los siguientes valores");
            String nombre = Leer.Texto("nombre del medicamento");
            String empacado = Leer.Texto("fecha de empacado");
            String vencimiento = Leer.Texto("fecha de vencimiento");
            String inicialLote = Leer.Texto("Numero Inicial de Lote");
            int cantidadLote = Leer.Enteros("Cantidad de Lotes a Empacar");
            Textos.IP("\n");
            if (cantidadLote != 0)
            {
                for (int i = cantidadLote; i > 1; i--)
                {

                    for (int j = 1; j < 6; j++)
                    {
                        Textos.IP("Nombre : " + nombre);
                        Textos.IP("Empacado : " + empacado);
                        Textos.IP("Vencimiento : " + vencimiento);
                        Textos.IP("Lote : " + i);
                        Textos.IP("Nurto de Caja : " + inicialLote + "_" + i + ":" + j);
                        Textos.IP("\n");
                    }
                }
            }
            else
                Console.Clear();
            Textos.IP("precione una tecla para salir");
            Console.ReadKey();
        }
    }

    class Textos
    {
        public static void IP(String msj)
        {
            Console.WriteLine(msj);
        }
    }

    class Leer
    {
        public static Int32 Enteros(String msj)
        {
            Textos.IP(msj);
            int valor = 0;

            bool numero = int.TryParse(Console.ReadLine(), out valor);
            if (numero)
                return valor;
            else
                Textos.IP("sólo se aceptan numeros\nse cerrará el programa");
            return valor;
        }
        public static double Dobles(String msj)
        {
            Textos.IP(msj);
            double valor = 0;

            bool numero = double.TryParse(Console.ReadLine(), out valor);
            if (numero)
                return valor;
            else
                Textos.IP("sólo se aceptan numeros\nse cerrará el programa");

            return valor;
        }

        internal static string Texto(string msj)
        {
            Textos.IP(msj);
            return Console.ReadLine();
        }
    }
}
