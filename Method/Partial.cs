using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
  class Partial
  {
    internal static string color = "black";
    internal static int numberOfMonitor = 1;
    internal partial class Monitor
    {
      internal static void _changeColor()
      {
        color = "White";
      }
    }

    internal partial class Monitor
    {
      internal static void _addMonitor()
      {
        numberOfMonitor += 1;
      }
    }
  }
}
