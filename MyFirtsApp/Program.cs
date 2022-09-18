using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Explicación de variables
            // Tipos de variables:

            // String - Cadenas de texto de longitud variable
            string postre = "Gelatina de Fresa";
            Console.WriteLine(postre); // Retorna "Gelatina de Fresa"

            // Integer - Número enteros
            int stock = 46; // Integer 
            Console.WriteLine(stock); // Retorna 46

            // Char - String de un sólo caracter
            char calificación = 'C'; // Char 
            Console.WriteLine(calificación); // Retorna "C"

            // Booleano - Se reduce a "Verdadero" o "Falso"
            bool existe = true; // Booleano 
            Console.WriteLine(existe); // Retorna true

            // Float - Almacena números con decimales entre 6 y 7 elementos de longitud (Debe llevar una "F" después del valor que se le da).
            float precio = 3.55F; // Float 
            Console.WriteLine(precio); // Retorna 3.55

            // Double - Almacena números con decimales aproximadamente de 15 elementos de longitud (Debe llevar una "D" después del valor que se le da).
            double precioPrec = 29.59D; // Double 
            Console.WriteLine(precioPrec); // Retorna 29.59

            //Long - Almacena enteros muy largos (Debe llevar una "L" después del valor asignado).
            long numero = 73000000000L; // Long
            Console.WriteLine(numero); // Retorna 73000000000

        }
    }
}