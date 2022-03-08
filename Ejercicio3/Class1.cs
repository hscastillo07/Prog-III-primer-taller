using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Cliente
    {
        
        string nom;
        int numacc;
        float saldo = 0;

        public void nombrar()
        {
            Console.WriteLine("Ingrese el nombre: ");
            nom = Console.ReadLine();
        }
        public void enumerarCuenta()
        {
            Console.WriteLine("Ingrese el numero a asignar a la cuenta: ");
            numacc = int.Parse(Console.ReadLine());
        }

        public void consignar()
        {
            Console.WriteLine("Ingrese el valor a consignar: ");
            saldo = float.Parse(Console.ReadLine());
        }
        public void retirar()
        {
           float temp = 0;
            temp = float.Parse(Console.ReadLine());
            saldo = saldo - temp;
            if (saldo < 0)
            {
                Console.WriteLine("El valor es invalido.");
            }
            else { Console.WriteLine("Nuevo saldo: " + saldo); }
        }
        public void Mostrar()
        {
            Console.WriteLine("Nombre: "+nom);
            Console.WriteLine("Numero de la cuenta: "+numacc);
            Console.WriteLine("Saldo actual: "+saldo);
        }
    }
}
