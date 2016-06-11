using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio41_guia8
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 nombres
            //1 notas
            String[][] vector = new string[5][];
            String dato = "", a = "A -->  ", b = "B -->  ", c = "C -->  ", d = "D -->  ", e = "E -->  ", SinAsginar = "Sin Asignar -->  ";
            
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = new string[2] { "", String.Empty };
                aux.LeerCadena("Ingrese un Nombre\t", false, out dato);
                aux.IP("", true);
                vector[i][0] = dato;
                aux.LeerCadena("Ingrese la Nota\t", false, out dato);
                aux.IP("", true);
                if (dato.ToUpper().Equals("A") | dato.ToUpper().Equals("B") | dato.ToUpper().Equals("C") | dato.ToUpper().Equals("D") | dato.ToUpper().Equals("E"))
                    vector[i][1] = dato.ToUpper();
                
                else
                {
                    aux.IP("No ingreso un dato correcto, el valor por defecto es - ", true);
                    vector[i][1] = "-";
                }
            }

            for (int i = 0; i < vector.Length; i++)
            {
                aux.IP(vector[i][0], false);
                aux.IP(vector[i][1], true);
            }


            //IP("Notas Agrupadas desde la A hasta la E", true);

            //for (int i = 0; i < vector.Length; i++)
            //{
            //    if (vector[i][1].Equals("A"))
            //        a += vector[i][0].ToUpper() + ", ";
            //    else if (vector[i][1].Equals("B"))
            //        b += vector[i][0].ToUpper() + ", ";
            //    else if (vector[i][1].Equals("C"))
            //        c += vector[i][0].ToUpper() + ", ";
            //    else if (vector[i][1].Equals("D"))
            //        d += vector[i][0].ToUpper() + ", ";
            //    else if (vector[i][1].Equals("E"))
            //        e += vector[i][0].ToUpper() + ", ";
            //    else
            //        SinAsginar += vector[i][0].ToUpper() + ", ";
            //}

            //IP(a, true);
            //IP(b, true);
            //IP(c, true);
            //IP(d, true);
            //IP(e, true);
            //IP(SinAsginar, true);

            Console.ReadKey();
        }
        //static void LeerCadena(object mensaje, bool linea, out string cadena)
        //{
        //    if (linea)
        //    {
        //        Console.WriteLine(mensaje);
        //        cadena = Console.ReadLine();
        //    }
        //    else
        //    {
        //        Console.Write(mensaje + "\t");
        //        cadena = Console.ReadLine();
        //    }
        //}

        //static void IP(object mensaje, bool linea)
        //{
        //    if (linea)
        //        Console.WriteLine(mensaje);
        //    else
        //        Console.Write(mensaje + "\t");
        //}
    }

    class aux
    {
       public static void LeerCadena(object mensaje, bool linea, out string cadena)
        {
            if (linea)
            {
                Console.WriteLine(mensaje);
                cadena = Console.ReadLine();
            }
            else
            {
                Console.Write(mensaje + "\t");
                cadena = Console.ReadLine();
            }
        }

       public static void IP(object mensaje, bool linea)
        {
            if (linea)
                Console.WriteLine(mensaje);
            else
                Console.Write(mensaje + "\t");
        }
    }
}

