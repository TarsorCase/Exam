// See https://aka.ms/new-console-template for more information
using TestDemo;

  Console.WriteLine("\n***** CALCULADORA *****");
    double masa;
    double aceleracion;
    double fuerza;
    double distancia;
    double velocidad;

    Console.WriteLine("Calcular la Fuerza\n");
    Console.WriteLine("Ingrese la masa: ");
    masa = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese la acceleracion: ");
    aceleracion = Convert.ToDouble(Console.ReadLine());
    double ans1 = Mathematics.Force(masa, aceleracion);
    Console.WriteLine($"La fuerza es: {ans1}"); 

    Console.WriteLine("Calcular el Trabajo\n");
    Console.WriteLine("Ingrese la fuerza: ");
    fuerza = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese el distancia: ");
    distancia = Convert.ToDouble(Console.ReadLine());
    double ans2 = Mathematics.Work(fuerza, distancia);
    Console.WriteLine($"El trabajo es: {ans2}"); 

    Console.WriteLine("Calcular la energia kinetic\n");
    Console.WriteLine("Ingrese la masa: ");
    masa = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese la velocidad: ");
    velocidad = Convert.ToDouble(Console.ReadLine());
    double ans3 = Mathematics.Kinetic(masa, velocidad);
    Console.WriteLine($"La energia cinetica es: {ans3}"); 
