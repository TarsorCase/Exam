// See https://aka.ms/new-console-template for more information
using TestDemo;

Console.WriteLine("Calculadora");
Console.Write("Ingrese un valor para chekar si es par: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Mathematics.IsEvenNumber(a));
