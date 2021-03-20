using System;
using System.Threading;

namespace programaNumeroTresTAREA
{
    class Program
    {
        public static void dibuja(int cantidad)
        {
            int cantFilas = 22, cantColumnas = 77, fila = 1, columna = 0, F, C, A;

            /* cantFilas - representa la cantidad de filas que llevara el programa
             cantColumnas - "" cantidad de columnas
            FILA - posicion en la fila que comenzara la funcion dibujar()
            COLUMNA - posicion en la columna ""

            */

            for (A = 1; A <= cantidad; A++)
            {
                for (F = columna; F <= cantColumnas; F++)
                {
                    Console.SetCursorPosition(F, cantFilas); Console.Write("?"); //LADO INFERIOR
                    Console.SetCursorPosition(F, fila); Console.Write("-"); //LADO POSTERIOR
                }
                for (C = fila; C <= cantFilas; C++)
                {
                    Console.SetCursorPosition(columna, C); Console.Write(".");//LADO IZQUIERDO
                    Console.SetCursorPosition(cantColumnas, C); Console.Write("X");//LADO DERECHO
                }
                fila++; 
                cantFilas--;//SE VA DISMINUYENDO PARA DEJAR UN ESPACIO LIBRE ENTRE CARACTERES
                columna++; 
                cantColumnas--;
            }
        }
        static void Main(string[] args)
        {
            for (int tam = 1; tam < 10; tam++)
            {
                dibuja(tam);
                Thread.Sleep(1000);
            }
        }
    }
}
