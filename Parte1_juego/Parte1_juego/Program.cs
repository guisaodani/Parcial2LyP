internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("******************JUEGO ADIVINA EL NUMERO***********************");
        Console.Write("****************************************************************");

        //variables
        double Njugadores,jugador1,jugador2,jugador3,jugador4,numSecreto;

        Console.Write("Ingrese la cantidad de Jugadores");
        Njugadores = double.Parse(Console.ReadLine());

        Random numAleatorio = new Random();
        if (Njugadores == 2)
        {
            numSecreto = numAleatorio.Next(0, 51);
        }
        else if (Njugadores == 3)
        {
            numSecreto = numAleatorio.Next(0, 100);
        }
        else if (Njugadores == 4)
        {
            numSecreto = numAleatorio.Next(0, 200);
        }
        

        for (int i = 0; i <= Njugadores; ++i)
        {
            Console.WriteLine($"Jugador {i} ingresa tu numeror a adivinar: ");
            jugador1 = double.Parse(Console.ReadLine());
            if(jugador1)
        }




    }
}