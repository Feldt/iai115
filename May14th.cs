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
            Textos.Menu1();
            Procesos.Opciones(Lecturas.leerInt("Elija una opcion del menu"));

        }
    }


#region class Textos : menu1 , IR (Impresion Rapida)
class Textos
{
    public static void Menu1()
    {
        
        Console.WriteLine("Menu Principal");
        Console.WriteLine("1.- Tablas de Multiplicar");
        Console.WriteLine("2.- Factorial");
        Console.WriteLine("3.- Promedios");
        Console.WriteLine("0.- para salir");
    }

    public static void IR(String mensaje)
    {
        Console.WriteLine(mensaje);
    }

}
#endregion

#region class Lecturas : int, double, string
class Lecturas
{
    public static double leerDoble(String mesnsaje)
    {
        Console.WriteLine(mesnsaje);
        double valor = double.Parse(Console.ReadLine());
        return valor;
    }

    public static Int32 leerInt(String mensaje)
    {
        Console.WriteLine(mensaje);
        Int32 valor = Int32.Parse(Console.ReadLine());
        return valor;
    }
}
#endregion


#region class Procesos : Tablas de multiplicar, Factorial, Promedio, Opciones
    class Procesos
    {

        public static void TablasMultiplicar(int tabla)
        {
            for (int num = 1; num < 11; num++)
            {
                Console.WriteLine(tabla + " X " + num + " = " + tabla * num);
            }
        }

        public static void Factorial(int num)
        {
            int factorial = 1;

            for (int i = num; i > 1; i--)
            {
                factorial *= i;
            }
            Console.Write("El Factorial es :" + factorial);
        }

        public static void Promedio()
        {
            double prom = 0, nota, aux;
            int cantidad;
            String mensaje = String.Empty;
            aux = cantidad = Lecturas.leerInt("Ingrese la cantidad de notas que necesita");
            while (aux > 0)
            {
                nota = Lecturas.leerDoble("ingrese una nota ");
                prom += nota;
                aux--;
            }
            prom /= cantidad;
            mensaje = prom > 6f ? "pasaste" : (prom < 6f & prom > 5.5f ? "sufi" : "reprovaste");
            Textos.IR(mensaje);
        }

        public static void Opciones(int valor)
        {
            while (valor != 1234587)
            {
                switch (valor)
                {
                    case 1: Procesos.TablasMultiplicar(Lecturas.leerInt("Ingrese el numero de la tabla que desea")); break;
                    case 2: Procesos.Factorial(Lecturas.leerInt("Ingrese el numero del factorial")); break;
                    case 3: Procesos.Promedio(); break;
                    case 0: valor = 1234587; break;
                    default: Textos.IR("Ingrese una opción valida"); break;
                }
                Textos.IR("\nPresione Enter para continuar");
                Console.ReadKey();
                Console.Clear();
                if (valor != 1234587)
                {
                    Textos.Menu1();
                    valor = Lecturas.leerInt("ingrese una opcion");
                }
                else
                    break;
            }
        }
    }

}
    #endregion
