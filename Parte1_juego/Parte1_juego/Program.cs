internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("******************JUEGO ADIVINA EL NUMERO***********************");
        Console.Write("****************************************************************");

        //variables
        double Njugadores,jugador,numSecreto=0;
        bool volver = true;

        while (volver) 
        { 

        Console.Write("Ingrese la cantidad de Jugadores: ");
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


            for (int i = 1; i <= Njugadores; ++i)
            {
                Console.WriteLine($"Jugador {i} ingresa tu numeror para adivinar: ");
                jugador = double.Parse(Console.ReadLine());
                if (jugador > numSecreto)
                {
                    Console.WriteLine("MENOR");
                }
                else if (jugador < numSecreto)
                {
                    Console.WriteLine("MAYOR");
                }
                else if (jugador == numSecreto)
                {
                    Console.WriteLine("!HAS GANADO¡");
                }

                Console.Write("¿Desean un nuevo tirito?");
                string retornar = Console.ReadLine().ToLower();
                if (retornar == "no") { volver = false; }
            }
                      
        }

    }
}