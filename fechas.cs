        /*
        explicación rápida para fechas en C#
        programa; 
        recibe una fecha en un formato ya definido,imina los guiones
        y guarta el resultado en un array llamado fecha
        con una variable tipo DateTime llamada thisDate inicializada en (años, meses, días)
        se imprime la fecha en el formato qe queremos.
        */

static void Main(string[] args)
        {
          //ejercio --; 
          //recibir una fecha y cambiar los formatos
            Console.WriteLine("ingrese una fecha con el siguiente formato; \t dd-mm-yyyy");
            String[] fecha = Console.ReadLine().Split('-');
            DateTime thisDate1 = new DateTime(int.Parse(fecha[2]), int.Parse(fecha[1]), int.Parse(fecha[0]));
            Console.WriteLine("fecha deseada 1 : " + thisDate1.ToString("dd/MM/yyyy") );
            Console.WriteLine("fecha deseada 2 : " + thisDate1.ToString("dd/MMM/yyyy"));
            
            //ejemplos
            Console.WriteLine("aqui un par de fechas extas, como ejemplo\n" );
            Console.WriteLine("fecha extra 1 : " + thisDate1.ToString("dd/MMMM/yyyy"));
            Console.WriteLine("fecha extra 2 : " + thisDate1.ToString("d/MM/yyyy"));
            Console.WriteLine("fecha extra 3 : " + thisDate1.ToString("dd/MM/yyyy"));
            Console.WriteLine("fecha extra 4 : " + thisDate1.ToString("ddd/MM/yyyy"));
            Console.WriteLine("fecha extra 5 : " + thisDate1.ToString("dddd/MMM/yyyy"));
            Console.WriteLine("fecha extra 6 : " + thisDate1.ToString("dddd/MMMM/y"));
            Console.WriteLine("fecha extra 7 : " + thisDate1.ToString("dddd/MMMM/yy"));
            Console.WriteLine("fecha extra 8 : " + thisDate1.ToString("dddd/MMMM/yyy"));
            Console.WriteLine("fecha extra 9 : " + thisDate1.ToString("dddd/MMMM/yyyy"));
            Console.ReadKey();
        }
        
