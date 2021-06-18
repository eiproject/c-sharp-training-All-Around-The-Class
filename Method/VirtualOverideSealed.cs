using System;
using System.Collections.Generic;
using System.Text;

/*namespace Method
{
  class Bottle
  {
    public virtual string Color { get; set; }
    private int num;
    public virtual int Number
    {
      get { return num; }
      set { num = value; }
    }
  }

  class BottleCap : Bottle
  {
    private string capColor;

    public override string Color
    {
      get
      {
        return capColor;
      }
      set
      {
        if (!string.IsNullOrEmpty(value))
        {
          capColor = value;
        }
        else
        {
          capColor = "Unknown";
        }
      }
    }
  }
}
*/

namespace Method
{
  class Area
  {
    protected double x, y;
    internal Area()
    {

    }
    internal Area(double a, double  b)
    {
      this.x = a;
      this.y = b;
    }
    
    internal virtual double AreaX()
    {
      return x * y;
    }
  }

  class Triangle : Area
  {
    internal Triangle()
    {

    }
    internal Triangle(double a, double t) : base(a, t)
    {
    }

    sealed internal override double AreaX()
    {
      return x * y / 2;
    }
  }

  class Pythagoras : Triangle
  {
    internal Pythagoras(double a, double t)
    {

    }
    // Sealed error, can not derived AreaX from Triangle
    /*internal override double AreaX()
    {
      return Math.Sqrt(x * x + y * y);
    }*/
  }
}
