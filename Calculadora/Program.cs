// See https://aka.ms/new-console-template for more information
using TestDemo;

  Console.WriteLine("\n***** CALCULADORA *****");
    double metros;
    double fuerza;
    double radio;
    double horizontal;
    double alpha;

    Console.WriteLine("Calcular el volumen de una esfera\n");
    Console.WriteLine("Ingrese radio: ");
    radio = Convert.ToDouble(Console.ReadLine());
    double ans1 = Mathematics.Force(radio);
    Console.WriteLine($"El volumen es: {ans1}"); 

    Console.WriteLine("Calcular el equivalente en metros\n");
    Console.WriteLine("Ingrese los kilometros: ");
    metros = Convert.ToDouble(Console.ReadLine());
    double ans2 = Mathematics.Work(metros);
    Console.WriteLine($"Son {ans2} kilometros"); 

    Console.WriteLine("Calcular la altura de un edificio\n");
    Console.WriteLine("Ingrese la distancia horizontal: ");
    horizontal = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese el grado: ");
    alpha = Convert.ToDouble(Console.ReadLine());
    double ans3 = Mathematics.Kinetic(horizontal, alpha);
    Console.WriteLine($"La energia cinetica es: {ans3}"); 
