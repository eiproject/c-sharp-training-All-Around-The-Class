using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
  class ExpressionBodied
  {
    internal float circleArea(float r) { return (r * r); }
    internal float circleArea2(float r) => r * r;
  }

  class OverloadingMethod
  {
    int numberOfThings = 0;
    internal void Rope(int x)
    {
      numberOfThings += x;
    }

    internal void Rope(float x)
    {
      numberOfThings += (int)x;
    }

    // error beacause the input is same as above
    /*internal float Rope(int x)
    {
      numberOfThings += x;
      return x;
    }*/

  }
}
