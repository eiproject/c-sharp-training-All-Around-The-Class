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

      // Ref parameter
      // Pass By Value And Pass By Reference
      AssignNumber V1 = new AssignNumber();
      int num1 = 5;
      V1.PBValueWithValue(num1);
      Console.WriteLine($"Pass by value with value : {num1}");
      V1.PBRefWithValue(ref num1);
      Console.WriteLine($"Pass by reference with value : {num1}");

      AssignName N1 = new AssignName() { Name = "Razif"};
      AssignName N2 = N1;
      N2.Name = "Rizqullah";
      Console.WriteLine($"Pass by value with reference N1 N2: {N1.Name} {N2.Name}");

      AssignName N3 = new AssignName() { Name = "Razif" };
      AssignName.ChangeName(N3);
      Console.WriteLine($"Pass by value with reference N3: {N3.Name}");

      AssignName N4 = new AssignName() { Name = "Razif" };
      AssignName.ChangeName2(N4);
      Console.WriteLine($"Pass by value with reference N4: {N4.Name}");
      
      AssignName N5 = new AssignName() { Name = "Razif" };
      AssignName.ChangeName3( ref N5);
      string res = (N5 == null) ? "null" : N5.Name;
      Console.WriteLine($"Pass by reference with reference N5: { res }");

      AssignName N6 = new AssignName() { Name = "Razif" };
      AssignName.ChangeName4(ref N6);
      string res2 = (N6 == null) ? "null" : N6.Name;
      Console.WriteLine($"Pass by reference with reference N6: { res2 }");

      // out parameter
      string Color, Brand;
      int Count;
      KeyboardData K = new KeyboardData();
      K.GetData(out Color, out Brand, out Count);
      // get data from object default information
      Console.WriteLine($"(Out) Information : {Brand} {Color} {Count}");

      int intResult;
      string yearStr = "1998";
      K.StringToInteger( yearStr, out intResult);
      Console.WriteLine($"(Out) Integer result from { yearStr } is : { intResult }");
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
