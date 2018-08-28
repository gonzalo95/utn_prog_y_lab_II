using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class Automovil
  {
    public Single velocidadActual;

    public static Byte cantidadRuedas;

    public static void MostrarCantidadRuedas()
    {
      Console.Write(Automovil.cantidadRuedas);
    }

    public void Acelerar(Single velocidad)
    {
      this.velocidadActual += velocidad;
    }
  }
}
