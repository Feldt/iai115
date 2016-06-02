static void Main(string[] args)
        {
            //recibe un nombre completo
            Console.WriteLine("Ingrese un nombre COMPLETO");
            String cadena = Console.ReadLine();
            //remplaza los espacios por guiones y luego convierte todo a mayusculas
            cadena.Replace(" ", "-").ToUpper();
            //imprime el vnombre tal y como lo queremos.
            Console.WriteLine(cadena);
        }
