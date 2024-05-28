// See https://aka.ms/new-console-template for more information
using TestDemo;
int yes = 1; 
while(yes == 1){
  Console.WriteLine("\n***** CALCULADORA *****");
  Console.WriteLine("1 ---> Fuerza\n2 ---> Trabajo\n3 ---> Energia Cinetica\nSeleccione una opcion (1 - 2 - 3): ");
  int optionMr = Convert.ToInt32(Console.ReadLine());
  switch (optionMr)
  {
    double masa;
    double aceleracion;
    double fuerza;
    double distancia;
    double velocidad;
    case 1:
      Console.WriteLine("Ingrese la masa: ");
      masa = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Ingrese la acceleracion: ");
      aceleracion = Convert.ToInt32(Console.ReadLine());
      double ans = Mathematics.Force(masa, aceleracion);
      Console.WriteLine($"La distancia es: {ans}"); 
      break;
    case 2:
      Console.WriteLine("Ingrese la fuerza: ");
      fuerza = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Ingrese el distancia: ");
      distancia = Convert.ToInt32(Console.ReadLine());
      double ans = Mathematics.Work(fuerza, distancia);
      Console.WriteLine($"La velocidad es: {ans}"); 
      break;
    case 3:
      Console.WriteLine("Ingrese la masa: ");
      masa = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Ingrese la velocidad: ");
      velocidad = Convert.ToInt32(Console.ReadLine());
      double ans = Mathematics.Kinetic(masa, velocidad);
      Console.WriteLine($"La velocidad es: {ans}"); 
      break;
  }
  Console.WriteLine("Would you want to make further calculations? 1 --> yes | 2 --> no\n");
  yes = Convert.ToInt32(Console.ReadLine());
}
if (yes == 2)
{
  Console.WriteLine("\nThank you for using this calculator :)");
  Console.WriteLine(" /\\_/\\");
  Console.WriteLine("( o.o )");  
  Console.WriteLine(" > ^ <");
  Console.WriteLine("All so shall you concive this phrase \"Cato\" but how may u use it?");
}
