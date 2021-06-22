using System;

namespace Indexer
{
  public class Run
  {
    public Run()
    {
      // string Index
      StringIndexer S = new StringIndexer();
      char res = S.stringIndex(null, 2);
      Console.WriteLine($"String indexer result: { res }");
      char res2 = S.stringIndex("razif", 2);
      Console.WriteLine($"String indexer result: { res }");

      // string and this
      Sentence Se = new Sentence("all around the world");
      /*Console.WriteLine($"{Se[0]} - {Se[1]} - {Se[2]} - {Se[3]}");*/
      Se.set_Item(3, "class");
      Console.WriteLine($"{Se.get_Item(0)} - {Se.get_Item(1)} - {Se.get_Item(2)} - {Se.get_Item(3)}");

      // constant
      double theR = 10.8;
      Circle C = new Circle(theR);
      Console.WriteLine(C.Area);

      // static constructor
      Pencil P1 = Pencil.ThePencil;
      Console.WriteLine(P1);
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
