using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  class Program
  {
    static void Main(string[] args)
    {
      int operando1;
      int operando2;
      string resp;
      bool continuar = true;
      while(continuar)
      {
        Console.Write("Ingrese el primer operando: ");
        operando1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el primer operando: ");
        operando2 = int.Parse(Console.ReadLine());
        Console.WriteLine(operando1 + operando2);
        Console.Write("Continuar? S_N: ");
        resp = Console.ReadLine();
        continuar = ValidarRespuesta.ValidarS_N(resp[0]);
      }
    }
  }
}
