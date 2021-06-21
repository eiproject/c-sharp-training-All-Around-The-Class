using System;

namespace Indexer
{
  class Run
  {
    internal Run()
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
