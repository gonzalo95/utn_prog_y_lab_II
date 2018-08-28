using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 11";

      int num, min = int.MaxValue, max = int.MinValue, acum = 0, cont = 0;

      for(int i = 0; i < 10; i++)
      {
        Console.Write("Ingrese un num: ");
        num = int.Parse(Console.ReadLine());
        if (Validacion.validar(num, -100, 100))
        {
          if (num < min)
            min = num;

          if (num > max)
            max = num;

          cont++;
          acum += num;
        }
        else
        {
          Console.WriteLine("Numero fuera de rango");
          i--;
        }
      }
      Console.WriteLine("Max: {0}", max);
      Console.WriteLine("Min: {0}", min);
      Console.WriteLine("Prom: {0}", acum / cont);

      Console.ReadKey();
    }
  }
}
