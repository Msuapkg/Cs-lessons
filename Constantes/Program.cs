namespace Constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Las constantes, a diferencia de las variables, no cambian su valor durante la ejecución del código */

            // Ejercicio: Calcular el área de un círculo según el radio que ingrese el usuario

            const double PI = 3.1416; // Declaramos PI como constante porque es un valor que no queremos que cambie bajo ninguna circunstancia durante la ejecución del programa.

            Console.WriteLine("Introduce la medida del radio");

            double radio = double.Parse(Console.ReadLine());

            // Forma 1
            double area1 = radio * radio * PI;
            Console.WriteLine($"El área1 del círcilo es: {area1}");

            // Forma 2
            double area2 = Math.Pow(radio, 2) * PI;
            Console.WriteLine($"El área2 del círcilo es: {area2}");

        }
    }
}