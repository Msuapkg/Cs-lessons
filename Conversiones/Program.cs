namespace Conversiones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Conversiones implícitas
            /* Son aquellas conversiones que pueden transformar el tipo de la variable que
            estamos manejando a otro tipo "compatible" sin modificar la información (sin perderla), sin embargo
            la conversión influye en la precisión de la variable. */

            float altura = 12.55F;
            Console.WriteLine(altura); // Retorna 12.5

            double alturaTotal = altura;
            Console.WriteLine(alturaTotal); // Retorna 12.550000190734863


            // Conversiones explícitas
            /* Son aquellas conversiones que pueden transformar el tipo de la variable que
            estamos manejando a otro tipo "compatible" modificando la precisión de la información
            (pérdida de información). */

            float peso = 54.6F;
            Console.WriteLine(peso); // Retorna 54.6

            int pesoAprox;
            pesoAprox = (int)peso;
            Console.WriteLine(pesoAprox); // Retorna 54


            // Conversión de texto a número ( ".parse()")
            /* Problema:
            Pediremos al usuario que introduzca dos numeros desde la consola para después poder sumarlos */

            Console.WriteLine("Introduce el primer número entero");

            // Console.ReadLine();  Este método nos sirve para que el usuario pueda introducir en consola una respuesta para despúes poder almacenarla como un String.

            // Para pasar de texto a número debemos declarar lo siguiente:
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número entero");

            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado es: {num1 + num2}"); // Retorna la suma de los dos números ingresados por el usuario.

        }
    }
}