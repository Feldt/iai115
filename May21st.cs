using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refuerzo21_05_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se muestra el menu, de la clase Textos
            Textos.Menu1();
            //De la clase Procesos se llama al metodo Opciones que recibe como parametro la opcion del menu
            //que se captura con El metodo leerInt de la Clase Lecturas
            Procesos.Opciones(Lecturas.leerInt("Elija una opcion del menu"));
        }
    }


    #region class Textos : menu1 , IR (Impresion Rapida)
    class Textos
    {
        //Metodo para mostrar el menu
        public static void Menu1()
        {

            Console.WriteLine("Menu Principal");
            Console.WriteLine("1.- Promedio");
            Console.WriteLine("2.- Agenda");
            Console.WriteLine("3.- Ventas");
            Console.WriteLine("4.- Examenes");
            Console.WriteLine("0.- para salir");
        }
        //Metodo para imprimir mensajes 
        public static void IR(String mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
    #endregion

    #region class Lecturas : int, double
    class Lecturas
    {
        //Metodo que se usara para obtener las variables de entrada que sean de tipo double
        public static double leerDoble(String mensaje)
        {
            double valor;
            Textos.IR(mensaje);
            //Al usar  double.TryParse(cadena, out) devuelve un boolean(true o false) 
            Boolean aux = double.TryParse(Console.ReadLine(), out valor);
            //al poner !aux es lo mismo que aux==false
            if (!aux)
            {
                Textos.IR("\nSolo acepto numeros");
                valor = 1234545;
            }
            return valor;
        }

        //Metodo que se usara para obtener las variables de entrada que sean de tipo int
        public static Int32 leerInt(String mensaje)
        {
            int valor = 0;
            Textos.IR(mensaje);
            Boolean aux = int.TryParse(Console.ReadLine(), out valor);
            if (aux == false)
            { 
                Textos.IR("\nSolo acepto numeros enteros");
                valor = 1234545;
            }
            return valor;
        }
    }
    #endregion

    #region class Procesos : Agenda, Promedio, Opciones
    class Procesos
    {
        //Metodo opciones que recibe de parametro, la opcion que se elije del menu
        public static void Opciones(int valor)
        {
            //la variable valor se usa como bandera, centinela, flags, etc. 
            while (valor != 1234587)
            {
                switch (valor)
                {
                    //En el caso 1, de la clase Procesos se llama al metodo Promedio, que recibe la cantidad de grupo,
                    //y para pedir la cantidad de grupo se usa la clase Lecturas y su metodo leerInt
                    case 1: Procesos.Promedio(Lecturas.leerInt("Ingrese la cantidad de grupos")); break;

                    //En el caso 2, para este metodo no se necesita recibir parametros.
                    case 2: Procesos.Agenda(); break;

                    //En el caso 3, de la clase Procesos se llama al metodo VentasAnual, que recibe la cantidad de años,
                    //y para pedir la cantidad de años se usa la clase Lecturas y su metodo leerInt
                    case 3: Procesos.VentasAnual(Lecturas.leerInt("Ingrese la cantidad de años")); break;

                    //En el caso 4, de la clase Procesos se llama al metodo Examen, que recibe la cantidad de empleados,
                    //y para pedir la cantidad de empleados se usa la clase Lecturas y su metodo leerInt
                    case 4: Procesos.Examen(Lecturas.leerInt("Ingrese la cantidad de empleados")); break;

                    //En el caso 0, para salir se asigna el valor para que la condicion del while sea false, y termine el ciclo 
                    case 0: valor = 1234587; break;

                    //En el default, se imprime el mensaje para que ingrese una opcion valida
                    default: Textos.IR("Ingrese una opción valida"); break;
                }

                Textos.IR("\nPresione Enter para continuar");
                Console.ReadKey();
                //limpiar pantalla
                Console.Clear();

                //Se valida la variable valor, para asegurar que cambie de opcion y no se mantenga en un ciclo infinito
                if (valor != 1234587)
                {
                    //Se Muestra el menu de nuevo 
                    Textos.Menu1();
                    //se le asigna a valor la opcion que ingrese el usuario 
                    valor = Lecturas.leerInt("ingrese una opcion");
                }
                else
                    break;
            }
        }

        //ejercicio 66, con un leve cambio que pide la cantidad de empleados para evaluar
        //Recibe como parametro la cantidad de empleados, dentro del metodo pide el resultado 
        //de cada empleado y se valida
        private static void Examen( int cant)
        {
           //se usa el parametro que se recibe para realizar el numero de iteraciones igual a la cantidad de empleados
            for (int i = 0; i < cant; i++)
            {
                //se imprime el numero de empleado para llevar el control
                Textos.IR("\nEmpleado: "+ (i+1));
                //se pide el resultado del empleado, con el metodo leerDouble de la clase Lecturas
                //el resultado se guarda en la variable v de tipo double 
                double v = Lecturas.leerDoble("\nIngrese resultado del examen");
                //se realiza las validaciones 
                if (v < 40)
                    Textos.IR("\nEl empleado permanece");
                else if (v >= 40 & v <= 60)
                    Textos.IR("\nRevision medica");
                else
                    Textos.IR("\nRemover del puesto.");
            }
        }

        //Ejercicio 53, Se recibe como parametro la cantidad de años
        //En el metodo se ingresan las ventas anuales y se imprime el total de ventas anual
        private static void VentasAnual(int v)
        {
            double ventas = 0, suma = 0;
            //el primer ciclo se hace segun la cantida de años
            for (int i = 0; i < v; i++)
            {
                suma = 0;
                Textos.IR("\nVentas del año: " + (i + 1));
                //Al ser ventas trimestrales se deben pedir 4 veces 
                for (int j = 0; j < 4; j++)
                {
                    ventas = Lecturas.leerDoble("\nIngrese las ventas del trimestre " + (j + 1));
                    suma += ventas;
                }
                Textos.IR("Las ventas totales del año: " + (i + 1) + "son " + suma);
            }
        }

        public static void Agenda()
        {
            //se realiza las repeticiones de la semana 
            for (int i = 0; i < 7; i++)
            {
                //Para imprimir los dias, se uso los metodos que da visual para las fechas 
                //AddDays(i), segun va aumentando i asi agrega dias al dia actual
                Console.WriteLine("Dia  " + DateTime.Now.AddDays(i).DayOfWeek);
                //Repeticiones que hace para mostrar las horas de las 8:00 a las 17:00
                for (int j = 8; j < 18; j++)
                {
                    Console.WriteLine("{0:00}_____________________________________\n_______________________________________\n", j);
                }
                Console.WriteLine("\n");
            }
        }

        //Recibe como parametro la cantidad de grupos, en el metodo pide la cantidad de alumnos
        //y pide las notas de cada alumno e imprime el promedio de cada grupo.  
        public static void Promedio(int grupo)
        {
            //Se declara las variables que se usan en este metodo
            double prom = 0, nota;
            //se declara una variable string vacia
            String mensaje = String.Empty;
            //el parametro que se recibe se utiliza para realizar el primer ciclo que son la cantidad de grupos 
            for (int i = 1; i < grupo + 1; i++)
            {
                prom = 0;
                Console.Clear();
                //Se usa la clase Textos y se llama al metodo IR que nos sirve para imprimir mensajes 
                Textos.IR("\nNotas del grupo: " + i);
                //Se usa la clase lecturas y se llama al metodo leerInt, donde se le manda el mensaje para pedir la cantidad
                int cant = Lecturas.leerInt("\nIngrese la cantidad de alumnos");
                //al tener la cantidad de alumnos, se usa la variable cant para realizar el segundo ciclo que son los alumnos
                for (int j = 1; j < cant + 1; j++)
                {
                    //Se usa la clase lecturas y se llama al metodo leerDouble, donde se le manda el mensaje para pedir la nota
                    nota = Lecturas.leerDoble("\nIngrese una nota del estudiante Nº  " + j);
                    //se realiza la suma de cada nota que se obtenga y se guarda en prom.
                    prom += nota;
                }
                //al terminar un ciclo se calcula el promedio
                prom /= cant;
                //Se usa la variable string que se declaro arriba para guardar el mensaje
                mensaje = "\nLa nota promedio del grupo: " + i + "es " + prom;
                //Se usa la clase Textos y se llama al metodo IR, solo que esta vez le mandamos una variable tipo string
                Textos.IR(mensaje);
                Console.ReadKey();
            }

        }
    }
}
#endregion
