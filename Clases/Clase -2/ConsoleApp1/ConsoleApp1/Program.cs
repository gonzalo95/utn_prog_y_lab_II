using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      MiClase obj1 = new MiClase();
      MiClase obj2 = new MiClase();

      obj1.id = 1;
      obj1.id = 2;

      MiClase.valorEstatico = 2;

      //Automovil.MostrarCantidadRuedas();
      //Automovil.cantidadRuedas = 4;
      //Automovil.MostrarCantidadRuedas();

      Automovil obj3 = new Automovil();

      Console.WriteLine(obj3.velocidadActual);
      obj3.Acelerar(150);
      Console.WriteLine(obj3.velocidadActual);

      Console.ReadKey();
    }
  }
}
