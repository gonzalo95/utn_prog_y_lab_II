using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  public class Conversor
  {
    public static string DecimalBinario(double num)
    {
      string bin = "";
      while(true)
      {
        if (num % 2 == 1)
          bin += "1";

        else
          bin += "0";

        num /= 2;
        if (num < 2) break;
      }
      return bin;
    }
    public static double BinarioDecimal(string bin)
    {
      double num = 0;
      for (int i = bin.Length - 1; i > 0; i++)
      {
        if((int)bin[i] - 49 == 1)
          num += Math.Pow(2, i);
      }
      return num;
    }
  }
}
