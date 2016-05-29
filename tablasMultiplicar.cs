/*tablas de multiplicar decomentar lo qe se vaya a utilizar*/

static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la tabla que desea imprimir");
            Console.WriteLine("Ejercicio1");
            //una tabla
            //TablasMultiplicar(int.Parse(Console.ReadLine()));

            Console.WriteLine("\n\nPresione una tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("\n\n\n\n\n\n\n\\n\n\n\n\n\n\n");
            Console.WriteLine("Ingrese el desde donde quiere empezar");
            int desde = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el hasta donde quiere empezar");
            int hasta = int.Parse(Console.ReadLine());
            //multitablas
            //TablasMultiplicarLimites(desde, hasta);
            Console.ReadKey();

        }

        public static void TablasMultiplicar(int tabla)
        {
            for (int num = 1; num < 11; num++)
            {
                Console.WriteLine(tabla + " X " + num + " = " + tabla * num);
            }
        }


        public static void TablasMultiplicarLimites(int desde, int hasta)
        {
            while (desde <= hasta)
            {


                for (int num = 1; num < 11; num++)
                {
                    Console.WriteLine(desde + " X " + num + " = " + desde * num);
                }

                desde++;
            }
        }
