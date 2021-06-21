using System;
using System.Collections.Generic;
using System.Text;


namespace Method
{
  abstract class AbstractClassArea
  {
    internal abstract int AbstractArea(); 
    // create abstract and empty method
  }

  class Rectangle : AbstractClassArea
  {
    int side;
    internal Rectangle(int s)
    {
      side = s;
    }

    internal override int AbstractArea() 
      // overide abstract method
    {
      return (side * side);
    }
  }

  class BaseClassArea
  {
    protected double x, y;
    internal BaseClassArea()
    {

    }
    internal BaseClassArea(double a, double  b)
    {
      this.x = a;
      this.y = b;
    }

    
    internal virtual double AreaX() 
      // create virtual method
    {
      return x * y;
    }

    // virtual/abstract can not private
    internal virtual int VirtualArea() 
    {
      return 1;
    }
  }

  class Triangle : BaseClassArea
  {
    internal Triangle()
    {

    }
    internal Triangle(double a, double t) : base(a, t)
    {
    }

    internal sealed override double AreaX() 
      // overide the virtual method, and sealed, not to overide again on other child
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
