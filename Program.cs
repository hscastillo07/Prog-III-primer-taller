using System;

namespace promedio
{
    class Program
    {
        static void metodo()
        {
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la primera nota:");
            float nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota:");
            float nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota:");
            float nota3 = float.Parse(Console.ReadLine());
            float prom = (nota1 + nota2 + nota3)/3;
           
            Console.WriteLine("Su promedio es: "+ prom);
            
        }
    }
}