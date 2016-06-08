using System;
public class Program
{
    public static void Main()
    {
        //invocacion de metodos mediante instancias
        Proceso p = new Proceso();
        //variable . metodo 
        //los metodos se cargan en orden logico.
        p.Longitud();
        p.LlenarArray();
        p.Promedio();
        p.sobrePromedio();
        p.imprimir();
        Console.ReadKey();
    }
}
public class Proceso
{
    //variables globales o variables de clase [ declaradas una vez y utilizables en toda la case]
    //array tipo string porque asi se almacenara todo en un solo array bidimencional y no habra qe crear dos array para un mismo fin
    String[][] datos = null;
    double edadPromedio = 0;
    int countFemenino = 0, num = 0;
    //instanciacion 
    Leer l = new Leer();
    Textos t = new Textos();

    public void Longitud()
    {
        String respuesta = String.Empty;
        l.Cadenas("Desea Cambiar la longitud del Array", false, out respuesta);

        //si la palabra ingresada inicia con si, SI, Si, s, S
        if (respuesta.StartsWith("si") | respuesta.StartsWith("Si") | respuesta.StartsWith("SI") | respuesta.StartsWith("S") | respuesta.StartsWith("s"))
        {
            l.Enteros("Ingrese la cantidad nueva", false, out num);
            //si el numero ingresado es mayor a cero (para qe no de error)
            if (num > 0)
                //el array tendra valores ingresados por el usuario
                datos = new String[num][];
            else
            {
                datos = new String[10][];
                t.Ip("El Array tiene 10 valores (ingreso un valor negativo)", true);
            }
        }
        else
        {
            t.Ip("El Array tiene 10 valores", true);
            datos = new String[10][];
        }
    }
    public void LlenarArray()
    {
        //datos.length porque no se cuantos datos quiere ingresar el usuario
        for (int j = 0; j < datos.Length; j++)
        {
            //inicializar los datos de las columnas en cada fila
            datos[j] = new String[2] { String.Empty, String.Empty };
            // variable . metodo 
            l.Cadenas("Ingrese un genero", false, out datos[j][0]);
            t.Ip(null, true);
            l.Enteros("Ingrese la edad", false, out num);
            datos[j][1] = num.ToString();
        }
    }

    public void Promedio()
    {
        for (int j = 0; j < datos.Length; j++)
        {
            edadPromedio += int.Parse(datos[j][1]);
        }
        edadPromedio /= datos.Length;
    }

    public void sobrePromedio()
    {
        for (int j = 0; j < datos.Length; j++)
        {
            //si el valor en el array inicia con Fe de Femenino o F
            if (datos[j][0].StartsWith("Fe") | datos[j][0].StartsWith("fe") | datos[j][0].StartsWith("f") | datos[j][0].StartsWith("F"))
            {
                //si sobre pasa el promedio total es porque tiene sobre edad
                if (edadPromedio < (int.Parse(datos[j][1])))
                    //un simple contador
                    countFemenino++;
            }
        }
    }
    public void imprimir()
    {
        t.Ip("El promedio total es: " + edadPromedio, true);
        t.Ip("Cantidad de personas del genero Femenino coon Sobre Edad es: " + countFemenino,true);
    }
}
    public class Leer
    {
        public void Enteros(Object mensaje, Boolean linea, out int numero)
        {
            Textos t = new Textos();
            if (linea)
            {
                Console.WriteLine(mensaje);
                int.TryParse(Console.ReadLine(), out numero);
            }
            else
            {
                Console.Write(mensaje + " :\t");
                int.TryParse(Console.ReadLine(), out numero);
            }
            if (numero == 0)
                t.Ip("numero no valido ; valor = 0 ", true);
        }
        public void Cadenas(Object mensaje, Boolean linea, out String cadena)
        {
            if (linea)
            {
                Console.WriteLine(mensaje);
                cadena = Console.ReadLine();
            }
            else
            {
                Console.Write(mensaje + " :\t");
                cadena = Console.ReadLine();
            }
        }
    }
    public class Textos
    {
        public void Ip(Object mensaje, Boolean linea)
        {
            if (linea)
                Console.WriteLine(mensaje);
            else
                Console.Write(mensaje);
        }
    }
