    /*  -Main //explicación simple de cadena y para el par, impar
        -IR(recibiendo un Object y un Boolean) //impresión rápida.
        -Ejercicio 38 //guía 8
        -Carnet // inventado
    */
 
      public static void IR(Object obj, Boolean Linea)
      {
          if (Linea)
              Console.WriteLine(obj);
          else
              Console.Write(obj);
      }
      
      
        //ejercicio 38
      //Lea 3 series de 3 números e imprima cantidad de pares y de impares en cada serie.
      public static void ejercicio38()
      {
          IR("ejercicio 38", true);
          int par = 0, impar = 0;
            for (int j = 1; j < 4; j++)
          {
            par = 0;
            impar = 0;
            for (int i = 1; i < 4; i++)
            {
              IR("ingrese un numero entero: ", false);
              int numero;
              int.TryParse(Console.ReadLine(), out numero);
              if ((numero % 2) == 0)
                par += 1;
              else
                impar += 1;
            }
              IR("\tcantida de numero impares de la serie: " + j + " es: " + impar, true);
            IR("\tcantidad de numeros pares de la serie: " + j + "es: " + par, true);
          }
            Console.ReadKey();
      }
      
      
        public static void Carnet()
      {
        String[] carnet = new String[10];
        String[] nombre = new String[10];
        String[] apellido = new String[10];
        String aux = null;
        Random nums = new Random();

          for (int i = 0; i < 2; i++)
          {
            IR("ingrese su nombre: ", false);
            nombre[i] = Console.ReadLine();
            aux = nombre[i].ToUpper();
            aux.ToArray();
            nombre[i] = nombre[i].Replace(nombre[i].ToString().Substring(0, 1), aux[0].ToString());
            IR(nombre[i] + ", Ingrese su apellido ", false);
            apellido[i] = Console.ReadLine();
            apellido[i] = apellido[i].Replace(apellido[i].ToString().Substring(0, 1), apellido[i].ToString().Substring(0, 1).ToUpper());
          }
          for (int i = 0; i < 2; i++)
          {
            carnet[i] = nombre[i].Substring(0, 1).ToUpper() + apellido[i].Substring(0, 1).ToUpper() + nums.Next(1000, 9000);
          }

          for (int i = 0; i < 2; i++)
          {
            IR("\tNombre: " + nombre[i] + "\tApellido: " + apellido[i] + "\tCarne: " + carnet[i], true);
          }
      }


      static void Main(string[] args)
      {
        IR("Refuero de String", true);
        String cadena = "123456789";
        cadena.ToArray();
        
        for (int i = 0; i < cadena.Length; i++)
        {
          if ((int.Parse(cadena[i].ToString()) % 2) == 0)
            IR(cadena[i] + " es par", true);
          else
            IR(cadena[i] + " es impar", true);
        }
        cadena = "HoLa ¿cóMo estÁn?";
        IR( "normal: "+cadena, true);
        IR("mayusculas: "+cadena.ToUpper(), true):
        IR("minustulcas: "+cadena.ToLower(), true);
        //Descomentar según método a útilizar
        //ejercicio38();
        //Carnet();
        Console.ReadKey();
      }
