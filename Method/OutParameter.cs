using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
  class KeyboardData
  {
    internal void GetData(out string Color, out string Brand, out int Count)
    {
      Color = "black";
      Brand = "Logitech";
      Count = 1;
    }

    internal void StringToInteger(string strInput, out int intOutput)
    {
      intOutput = int.Parse(strInput);
    }
  }
}
