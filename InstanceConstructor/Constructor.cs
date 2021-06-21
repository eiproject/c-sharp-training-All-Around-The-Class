using System;
using System.Collections.Generic;
using System.Text;

namespace InstanceConstructor
{
  class Inventory
  {
    internal string Name;
    internal string Color;
    internal int Number;
    internal int Year;

    internal Inventory()
    {
      Console.WriteLine("You don't place any inventory");
    }

    internal Inventory(string n, string col, int num, int y)
    {
      Name = n.ToUpper();
      Color = col.ToUpper();
      Number = num;
      Year = y;

      Console.WriteLine("Adding inventory OK");
    }
  }

  class Pythagoras
  {
    internal float C;
    Pythagoras() { }
    internal static Pythagoras Sum(float a, float b)
    {
      Pythagoras objResult = new Pythagoras();
      float c;
      c = (float)Math.Sqrt(a * a + b * b);
      objResult.C = c;
      return objResult;
      
    }
  }
}
