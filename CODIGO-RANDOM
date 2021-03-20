using System;

namespace ejercicicioTresTAREA
{
    class Program
    {
        public static string generaletra()

        {
            Random ran = new Random(); //Instanciamos un objeto del tipo random.
            int rango = Convert.ToInt32(ran.Next(0, 10)); //Le otorgamos a una variable el dato que arroje el random
            string letrarespuesta = ""; //Variable que va concatenando los valores.
            letrarespuesta = Convert.ToString(rango); //Se concatena cada nuevo valor a la cadena de texto.
            return letrarespuesta; //retorna la variable con cada caracter concatenado a la misma.
        }

        public static void getToken(int longitud)
        {
            byte caracteres; 
            string letra = ""; // Va concatenando los valores que devuelve la funcion generarletra()

            for (caracteres = 1; caracteres <= longitud; caracteres++)
            {
                /*La variable caracteres sirve como centinela para nuestro ciclo
                 que se ira repetiendo hasta cantidad de numeros querramos, basicamente,
                 de tal manera que cada vez que caracter aumente, se va concatenando un nuevo valor a 
                 a nuestra variable letra.*/
                letra = letra + generaletra();
            }

            Console.WriteLine($"Tocken es : {letra}");
        }


        static void Main(string[] args)
        {
            byte  cantidadNumeros;
            Console.Write("Cuantos numeros?: "); //Determina la longitud del token.

            try
            {
                getToken(cantidadNumeros = byte.Parse(Console.ReadLine()));
            }

            catch(FormatException)
            {
                Console.WriteLine("Dato no valido.");
            }


            Console.ReadLine();

        }
    }
}
