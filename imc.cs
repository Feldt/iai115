/*Sacar el imc utiliando arrays y Random 
10 personas con altura y peso decididas por el programador
Forma larga
*/

﻿ static void Main(string[] args)
        {
            
            int [] altura =null, peso=null, imc=null;

            Random alAzar = new Random(); 
            //llenar el array con datos

                for(int i = 0; i < 11; i++)

                {
                    Console.WriteLine("llenando array con la altura de la persona " + i);
                    altura[i]= alAzar.Next(140,195); // altura en la posicion i(el valor que tenga el array) tomará un valor al azar entre 140 y 195 (centimetros)
                    Console.WriteLine("llenando array con la altura de la persona " + i);
                    peso[i]=alAzar.Next(50,80); // peso en la posicion i(el valor que tenga el array) tomará un valor al azar entre 50 y 80 asumiendo que son Kilogramos
                }


            //calcular el imc y almacenarlo en el array

            for (int i = 0; i < 11; i++)

            {
                imc[i]=peso[i]/ (altura[i]*altura[i]);  // imc igual peso por altura al cuadrado

                Console.WriteLine("IMC para la persona : " + i+ " es de : "+imc[i]);

            }
        }
