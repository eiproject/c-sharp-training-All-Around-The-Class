using System;
using System.Threading.Tasks;

namespace Method
{
  public class Run
  {
    public Run()
    {
      // Virtual Overide Sealed
      double a = 2, t = 3;
      Triangle b1 = new Triangle(a, t);
      Console.WriteLine($"AreaX : { b1.AreaX() }");

      // Abstract 
      AbstractClassArea A = new Rectangle(5);
      Console.WriteLine($"AbstractArea : { A.AbstractArea() } ");

      // partial test
      Console.WriteLine(Partial.color);
      Partial.Monitor._changeColor();
      Console.WriteLine(Partial.color);
      Console.WriteLine(Partial.numberOfMonitor);
      Partial.Monitor._addMonitor();
      Console.WriteLine(Partial.numberOfMonitor);

      // async 
      Console.ReadKey();
      Console.WriteLine("");
      Console.WriteLine("Async testx");
      /*Task<int> task= CountingStar.Method1();*/
      Task<int> starsNumbers = CountingStar.startCounting();
      CountingStar.countAsteroid();
      int count = starsNumbers.Result;
      /*int count = task;*/
      CountingStar.stopCounting(count);

      // expression bodied
      ExpressionBodied E = new ExpressionBodied();
      Console.WriteLine(E.circleArea(1.2F));
      Console.WriteLine(E.circleArea2(1.2F));

      // Overloading Method
      OverloadingMethod O = new OverloadingMethod();
      O.Rope(1);
      O.Rope(1F);
      O.Rope(1);
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
