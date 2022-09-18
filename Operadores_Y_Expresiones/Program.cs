namespace Operadores_Y_Expresiones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int edad;

            edad = 29; // A las variables se les puede asignar un valor en el código despues de haberlas declarado.

            // Operadores

            // "+" Símbolo de suma - adición
            Console.WriteLine(5 + 10); // Retorna 15 (Ambos elementos en la suma son Int y el resultado será Int)
            Console.WriteLine(5.1 + 6.3); // Retorna 11.399999999999999 (Ambos elementos en la suma son float y el resultado será float)
            Console.WriteLine(7.8 + 5); // Retorna 12.8 (Sólo un elemento en la suma es float y el resultado será float)
            
                // Concatenado
                Console.WriteLine("Hola, tengo " + edad + " años"); // Retorna "Hola, tengo 29 años"

                // Adición consecutiva
                Console.WriteLine("Voy a cumplir " + ++edad + " años"); // Retorna "Voy a cumplor 30 años"
                edad++;
                Console.WriteLine("En abril cumplo " + edad + " años"); // Retorna "En abril cumplo 30 años"
                edad+=5;
                Console.WriteLine("En 6 años tendré " + edad + " años"); // Retorna "En 6 años tendré 36 años"

                // Texto Interpolado 
                Console.WriteLine($"En 6 años tendré {edad} años"); // Retorna "En 6 años tendré 36 años"

            // "-" Símbolo de resta - sustracción
            Console.WriteLine(50-25); // Retorna 25
            // Se pueden ejecutar las mismas sentencias que con el símbolo "+"

            // "*" Símbolo de multiplicación
            Console.WriteLine(3*5); // Retorna 15
            Console.WriteLine(3*5*4); // Retorna 60

            // "/" Símbolo de división
            Console.WriteLine(9/3); // Retorna 3
            Console.WriteLine(50/5); // Retorna 10

            // "%" Símbolo de restante (Retorna el residuo de una división)
            Console.WriteLine(20%3); // Retorna 2
            Console.WriteLine(29%5); // Retorna 4


        }
    }
}