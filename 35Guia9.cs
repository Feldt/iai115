using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array Bidimencional en String con 10 filas
            String[][] datos = new String[10][];

            //control para menor y mayor
            double mayor = 0f, menor = 85465456465484654f;
            int aux = 0, aux2 = 0;

            //Posiciones de los datos en el vector

            /*0 id
            1 apellidos
            2 agua
            3 electricidad
            4 telecumunicacion
            5 consumo
            0 -6 mayor
            0 - 7menor
            */

            for (int j = 0; j < 9; j++)
            {
                //inicializar los datos de las columnas en cada fila
                datos[j] = new String[8] { String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty };
                //solo para que se vea un poco mas formal, se agrego un contador de registros

                datos[j][0] = 0 + j.ToString();
                Console.WriteLine("\n Ingrese apellidos");
                datos[j][1] = Console.ReadLine();
                Console.WriteLine("\n Ingrese total de agua");
                datos[j][2] = Console.ReadLine();
                Console.WriteLine("\n Ingrese total de electicidad");
                datos[j][3] = Console.ReadLine();
                Console.WriteLine("\n Ingrese total de telecomunicacion");
                datos[j][4] = Console.ReadLine();
                datos[j][5] = (double.Parse(datos[j][2]) + double.Parse(datos[j][3]) + double.Parse(datos[j][4])).ToString();

                //verificacion y asginacion si en caso es mayor
                if (double.Parse(datos[j][5]) > mayor)
                {
                    //registro en la posicion 6 de la primer fila siempre sera el mayor
                    mayor = double.Parse(datos[j][5]);
                    datos[0][6] = mayor.ToString();
                    aux2 = j;
                }
                //verificacion y asginacion si en caso es menor
                if (double.Parse(datos[j][5]) < menor)
                {
                    //registro en la posicion 7 de la primer fila siempre sera el menor
                    menor= double.Parse(datos[j][5]);
                    datos[0][7] = menor.ToString();
                    aux = j;
                }

            
            }

            //imprimir
            for (int j = 0; j < 9; j++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Numero de Registro " + datos[j][0]);
                Console.WriteLine("Numero de Registro " + datos[j][1]);
                Console.WriteLine("Agua " + datos[j][2]);
                Console.WriteLine("Energia " + datos[j][3]);
                Console.WriteLine("Telecomunicacion " + datos[j][4]);
                Console.WriteLine("Consumumo Total " + datos[j][5]);
            }

            Console.WriteLine("La familia " + datos[aux][1] + "Tiene un Consumumo Total Menor" + datos[0][7]);
            Console.WriteLine("La familia " + datos[aux][1] + " Tiene un Consumo Total Mayor" + datos[0][6]);

            Console.ReadKey();
        }
    }
}
