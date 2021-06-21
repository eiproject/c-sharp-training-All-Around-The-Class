using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
  class AssignNumber
  {
    internal void PBValueWithValue(int x)
    {
      x = x + 1;
      Console.WriteLine($"x : { x }");
    }

    internal void PBRefWithValue(ref int x)
    {
      x = x + 1;
      Console.WriteLine($"x : { x }");
    }
  }

  class AssignName
  {
    internal string Name;

    internal static void ChangeName(AssignName user)
    {
      user.Name = "Muhammad";
    }

    internal static void ChangeName2(AssignName user)
    {
      user = null;
    }

    internal static void ChangeName3(ref AssignName user)
    {
      user = null;
    }

    internal static void ChangeName4(ref AssignName user)
    {
      user.Name = "Muhammad";
    }

  }
}
