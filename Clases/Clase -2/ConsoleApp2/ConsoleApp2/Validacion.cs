using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  public class Validacion
  {
    public static bool validar(int valor, int min, int max)
    {
      return valor < max && valor > min;
    }
  }
}
