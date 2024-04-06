internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("******************JUEGO ADIVINA EL NUMERO***********************");
        Console.Write("****************************************************************");

        //variables
        double Njugadores,jugador1,jugador2,jugador3,jugador4;

        Console.Write("Ingrese la cantidad de Jugadores");
        Njugadores = double.Parse(Console.ReadLine());

        Random numaleatorio = new Random();

        for (int i = 0; i <= Njugadores; ++i)
        {
            Console.WriteLine($"Jugador {i} ingresa tu numeror a adivinar: ");
            jugador1 = double.Parse(Console.ReadLine());
            if(jugador1)
        }




    }
}