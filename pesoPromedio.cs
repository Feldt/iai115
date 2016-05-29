/*Para 5 personas lea 3 medidas de peso tomadas al inicio, 
mitad y final del mes, imprima el peso promedio de cada persona 
másy el peso promedio de todo el grupo de trabajo. */

static void Main(string[] args)
        {
            double[][] personasPesos=null;
            double prom=0, promedio_global=0;
            //llenar el array con datos
            for (int i = 1; i < 6; i++)
            {
                for(int j = 1; j < 4; j++)
                {
                    Console.WriteLine("ingrese la medida de peso " + j + "para la persona " + i);
                    personasPesos[i][j]=double.Parse(Console.ReadLine());
                }
            }
            
            //calcular el promedio para el array
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                   prom+= personasPesos[i][j];
                }
                prom /= 3;
                Console.WriteLine("Promedio de peso para la persona: " + i+ " es de : "+prom);
                promedio_global += prom;
            }
            Console.WriteLine("El promedio del grupo es de: " + promedio_global);
        }
