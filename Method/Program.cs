using System;

namespace Method
{
  public class Run
  {
    public Run()
    {
      // Virtual Overide Sealed
      double a = 2, t = 3;
      Area b1 = new Triangle(a, t);
      Console.WriteLine(b1.AreaX());

      // partial test
      Console.WriteLine(Partial.color);
      Partial.Monitor._changeColor();
      Console.WriteLine(Partial.color);
      Console.WriteLine(Partial.numberOfMonitor);
      Partial.Monitor._addMonitor();
      Console.WriteLine(Partial.numberOfMonitor);
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      /*Console.WriteLine("Hello World!");*/
      Run R = new Run();
    }
  }
}
