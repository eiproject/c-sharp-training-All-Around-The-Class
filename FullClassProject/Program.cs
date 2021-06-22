using System;

namespace TrainingFullClass
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello My World!");
      Fields.Run app = new Fields.Run();
      Method.Run app2 = new Method.Run();
      InstanceConstructor.Run app3 = new InstanceConstructor.Run();
      Indexer.Run app4 = new Indexer.Run();
    }
  }
}
