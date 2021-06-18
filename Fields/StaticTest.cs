using System;
using System.Collections.Generic;
using System.Text;

namespace Fields
{
  static class Mouse
  {
    internal static string color = "black";
    internal static int numberOfMouse;
    internal static void AddMouse()
    {
      numberOfMouse += 1;
    }
    internal static int NumberOfMouse()
    {
      return numberOfMouse;
    }
  }
}
