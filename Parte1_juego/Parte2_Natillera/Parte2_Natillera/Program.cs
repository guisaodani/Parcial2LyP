﻿internal class Program
{
    private static void Main(string[] args)

    {
        Console.Write("************************NATILLERA**************************************************\n");
        bool volver = true;
        const double BONO = 0.4; //snake case ej.(HOLA_MUNDO)
        const double TASA_PRESTAMO = 2.5; //snake case ej.(HOLA_MUNDO)

        while (volver)
        {
            decimal aporteMensual = 0, rendimientoMensual = 0, aporteTotal = 0, rendimientoTotal = 0, bonoMensual = 0, bonoTotal = 0, aporteTotalNeto, tasaMensual,MultaMensual=0,Multatotal=0,Ahorrado=0,Prestamo,TotalPrestamo=0,interesPrestamo=0,interesTotal=0;
            

            //class Random
            
            Random random = new Random();// esta es la forma de instanciar una clase en objeto

            int TotalSocio=0;
            
            for (int socio = 1; socio <= 2; socio++)
            {
                Console.Clear();
                Console.WriteLine($"Socio {socio} ingrese los siguientes datos: ");
                Console.WriteLine( "___________________________________________" );
                for (int mes = 1; mes <= 12; mes++)
                {
                    Console.Write($"ingrese cantidad que desea ahorrar en el mes {mes}: ");
                    aporteMensual = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("\n");

                    tasaMensual = (decimal)random.Next(1, 51) / 10;
                    rendimientoMensual = aporteMensual * (tasaMensual / 100);

                    if (tasaMensual < 1.5M)
                    {
                        bonoMensual = aporteMensual * (decimal)BONO;
                        bonoTotal += bonoMensual;
                    }

                    aporteTotal += aporteMensual;
                    rendimientoTotal += rendimientoMensual;

                    if (aporteMensual == 0) 
                    { MultaMensual = 20000;
                        Multatotal += MultaMensual;
                    }
                    Ahorrado = rendimientoTotal + aporteTotal + bonoTotal;

                    Console.Write("Desea hacer un prestamo?(si/no)");
                    string hacerPrestamo = Console.ReadLine().ToLower();
                    if (hacerPrestamo == "si")
                    {                                              
                            Console.Write("Ingrese el Valor del prestamo, menor o igual a lo que llevas ahorrado: ");
                            Prestamo = Convert.ToDecimal(Console.ReadLine());
                        if (Prestamo <= Ahorrado)
                        {
                            Console.WriteLine("Prestamos Aprobado");
                            interesPrestamo = Prestamo * ((decimal)2.5/ 100);
                            interesTotal+= interesPrestamo;
                            TotalPrestamo += Prestamo;
                        }
                        else { Console.WriteLine("No te podemos prestar"); }
                                                   
                    }
                                                                              
                    Console.Write($"Mes {mes}\n" +
                                  $"Aportes: {aporteMensual:C}\n" +
                                  $"Tasa: {tasaMensual}% \n" +
                                  $"Rendiemiento: {rendimientoMensual:C}\n" +
                                  $"Bono: {bonoMensual:C}\n");
                    Console.Write($"Multa: {MultaMensual:C}\n");
                    Console.Write($"Prestamos: {TotalPrestamo:C}\n");
                    Console.Write($"Tasa interes prestamos: 2.5%\n");
                    

                                  
                    Console.Write("\n");


                }
                TotalSocio = socio + 1;

                Console.Write("-------------------------------------------\n");
                Console.Write("-------------------------------------------\n");
                aporteTotalNeto = (rendimientoTotal + aporteTotal + bonoTotal) - TotalPrestamo-interesTotal;
                Console.Write($"Aportes totales: {aporteTotal:C}\n");
                Console.Write($"Redimiento Total: {rendimientoTotal:C}\n");
                Console.Write($"Bonos totales: {bonoTotal:C} \n");
                Console.Write("-------------------------------------------\n");
                Console.Write("-------------------------------------------\n");
                Console.Write($"Total neto: {aporteTotalNeto:C}\n");
                Console.Write($"Total Multas: {Multatotal:C}\n");
                Console.Write($"Total Prestamos: {TotalPrestamo:C}\n");
                Console.Write("_______________________________________________________________\n");
                Console.ReadKey();


            }
                               
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Desea continuar en la natillera? (s/n)");
            string continuar = Console.ReadLine().ToLower();

            if (continuar == "n") volver = false;

        }
    }
}