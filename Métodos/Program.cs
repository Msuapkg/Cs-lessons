namespace Métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            // Los métodos se conforman de:
            //      - El tipo del método, el cuál deberá ser el tipo de dato que se espera que retorne la función.
            //      - El nombre del método, con el cuál se llamará el método más adelante.
            //      - Los parámetros que usará el método para su ejecución (estos son opcionales).
            int sumaNumeros ()
            {
                int num1 = 5;
                int num2 = 8;

                int resultado = num1 + num2; 

                // Se debe hacer un return para poder recuperar el resultado fuera del método.
                return resultado;
            }

            // Llamada de método sin parámetros
            Console.WriteLine(sumaNumeros());

            int multiplicacionNumeros(int num1, int num2)
            {
                int resultado = num1 + num2;

                return resultado;
            }

            // Llamada de método con parámetros
            Console.WriteLine(multiplicacionNumeros(2,5));

            // Cuando no se quiere que un método haga un "return" se le asignará el tipo "void".
            void llamada ()
            {
                Console.WriteLine("Llamada sin return");
            }

            llamada();

        }
    }
}