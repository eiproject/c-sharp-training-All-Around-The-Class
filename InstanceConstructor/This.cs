using System;
using System.Collections.Generic;
using System.Text;

namespace InstanceConstructor
{
  class Hydrolic
  {
    private float f;
    private float a;

    internal Hydrolic(float x, float y)
    {
      this.f = x;
      this.a = y;
    }

    internal float Power
    {
      get { return f/a; }
    }
  }
}
