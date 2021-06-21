using System;

namespace InstanceConstructor
{
  class Run
  {
    internal Run(){
      // Overloading constructor 
      Inventory I1 = new Inventory();
      Inventory I2 = new Inventory(
        n: "Bag",
        col: "black",
        num: 1,
        y: 2019
        );

      Console.WriteLine($"Just saved { I2.Name } { I2.Color } { I2.Number } { I2.Year }");

      // Non public constructor
      float a = 3.1F;
      float b = 4.7F;
      Pythagoras objRes = Pythagoras.Sum(a, b);
      Console.WriteLine($"Pythagoras sum result from  {a} and {b} is: { objRes.C }");
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Run R = new Run();
    }
  }
}