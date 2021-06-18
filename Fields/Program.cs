using System;

namespace Fields
{
  
  
  class Laptop
  {
    string Owner;
    string Brand;
    string Color;
    float weight;

    internal Laptop()
    {

    }
  }

  
  public class Run
  {
    internal int numOfError = 0;

    int _howManyMouse;
    string _mouseColor;
    public Run()
    {
      Console.WriteLine("Field Test Running.");
      
      // static test
       _mouseColor= Mouse.color;
      Mouse.AddMouse();
      Mouse.AddMouse();
      Mouse.AddMouse();
       _howManyMouse = Mouse.NumberOfMouse();
      Console.WriteLine(_howManyMouse);

      // protected test
      var O = new Owner();
      var U = new User();

      Console.WriteLine(O.ownerNo1); // jun
      Console.WriteLine(User.mainAdministrator);

      // readonly test
      /*User.mainAdministrator = "Hero";*/ //  This will return error because the var is readonly
      Console.WriteLine(U.commonAdmin);

      // unsafe test
      UnsafeAndPointer Un = new UnsafeAndPointer();
      Un.UnsafeTest();

      // volatile test
      runVolatileTestWorker.Run();

    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Run X = new Run();
      /*Console.WriteLine("Number of error: " + X.numOfError.ToString());*/
    }
  }
}
