using System;
using System.Threading;

namespace ejerciciosHoy
{
    class Program
    {

        public static string Mid(string parametro, int startindex, int length)
        {
            string result = parametro.Substring(startindex, length); //SEPARA CARACTERES DE LA CADENA.
            return result;

        }

        static void Main(string[] args)
        {

            //Variables
            string nombreCadena; //ACA SE GUARDA LA CADENA DE TEXTO NOMBRE.
            string caracterCadena;
            int k = 0; //K, CENTINELA-SIRVE PARA RECORRER COLUMNAS.
            int P = 0; //P, CENTINELA-SIRVE PARA IR RECORRIENDO CARACTERES DE LA CADENA. 
            int longitudCadena = 0;
            int cantRecorrido = 0;

            Console.WriteLine("Ingrese su nombre: ");
            nombreCadena = Console.ReadLine();

            Console.SetCursorPosition(1, 12);
            Console.Write(nombreCadena); //imprime nombre en pantalla, cursor en columna 1, fila 12.

            longitudCadena = nombreCadena.Length; //DETERMINA LA CANTIDAD DE CARACTERES QUE TIENE LA CADENA DE TEXTO.
            cantRecorrido = 25; //DETERMINA CUANTOS ESPACIOS RECORRE LA LETRA POR LA CONSOLA.
            

            nombreCadena = nombreCadena.ToUpper(); //CONVIERTE A MAYUSCULAS


            for (P = nombreCadena.Length; P >= 1; P--) 
            {
                caracterCadena = Mid(nombreCadena, P - 1, 1); // FUNCION QUE ALMACENA CARACTER POR CARACTER. HASTA P-1
                for (k = longitudCadena; k <= cantRecorrido; k++) //K IRA RECORRIENDO COLUMNA POR COLUMNA. SIEMPRE EN LA FILA 12. HASTA QUE K = 25.
                {
                    Console.SetCursorPosition(k, 12);
                    Console.Write(" " + caracterCadena);
                    Thread.Sleep(25); // PARA QUE SE REPITA CICLO PASAN 25 MILISEGUNDOS.
                }
                cantRecorrido = cantRecorrido - 1; //SE VA RESTANDO UN ESPACIO POR CADA CARACTER, SINO TODOS TERMINAN EN EL MISMO LUGAR.
                longitudCadena = longitudCadena - 1;

            }

            Console.ReadKey();
        }
    }
}
