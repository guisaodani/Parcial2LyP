internal class Program
{
    private static void Main(string[] args)

    {
        Console.Write("************************NATILLERA**************************************************\n");
        bool volver = true;
        const double BONO = 0.4; //snake case ej.(HOLA_MUNDO)

        while (volver)
        {
            decimal aporteMensual = 0, rendimientoMensual = 0, aporteTotal = 0, rendimientoTotal = 0, bonoMensual = 0, bonoTotal = 0, aporteTotalNeto, tasaMensual;
            

            //class Random
            
            Random random = new Random();// esta es la forma de instanciar una clase en objeto

            int TotalSocio=0;
            
            for (int socio = 1; socio <= 2; socio++)
            {
                Console.WriteLine($"Socio {socio} ingrese los siguientes datos: ");
                Console.WriteLine( "___________________________________________" );
                for (int mes = 1; mes <= 12; mes++)
                {
                    Console.Write($"ingrese cantidad que desea ahorrar en el mes {mes}: ");
                    aporteMensual = Convert.ToDecimal(Console.ReadLine());

                    tasaMensual = (decimal)random.Next(1, 51) / 10;
                    rendimientoMensual = aporteMensual * (tasaMensual / 100);

                    if (tasaMensual < 1.5M)
                    {
                        bonoMensual = aporteMensual * (decimal)BONO;
                        bonoTotal += bonoMensual;
                    }

                    aporteTotal += aporteMensual;
                    rendimientoTotal += rendimientoMensual;

                    Console.Write($"Mes {mes}\n" +
                                  $"Aportes: {aporteMensual:C}\n" +
                                  $"Tasa: {tasaMensual}% \n" +
                                  $"Rendiemiento: {rendimientoMensual:C}\n" +
                                  $"Bono: {bonoMensual:C}\n");
                    Console.Write("\n");


                }
                TotalSocio = socio + 1;

                
            }
            Console.Write("-------------------------------------------\n");
            Console.Write("-------------------------------------------\n");
            aporteTotalNeto = rendimientoTotal + aporteTotal + bonoTotal;
            Console.Write($"Aportes totales: {aporteTotal:C}\n");
            Console.Write($"Redimiento Total: {rendimientoTotal:C}\n");
            Console.Write($"Bonos totales: {bonoTotal:C} \n");
            Console.Write("-------------------------------------------\n");
            Console.Write("-------------------------------------------\n");
            Console.Write($"Total neto: {aporteTotalNeto:C}\n");

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Desea continuar en la natillera? (s/n)");
            string continuar = Console.ReadLine().ToLower();

            if (continuar == "n") volver = false;

        }
    }
}