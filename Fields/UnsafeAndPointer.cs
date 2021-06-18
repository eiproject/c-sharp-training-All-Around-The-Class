using System;
using System.Collections.Generic;
using System.Text;

namespace Fields
{
  class UnsafeAndPointer
  {
    internal unsafe void UnsafeTest()
    {
      int val = 50;
      int* x = &val;

      Console.WriteLine("Data: {0} ", val);
      Console.WriteLine("Address: {0}", (int)x);
      Console.ReadKey();
    }
  }
}
