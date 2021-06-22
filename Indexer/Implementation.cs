using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer
{
  class StringIndexer
  {
    internal char stringIndex(string text, int index)
    {
      return text == null ? ' ': text[index];
    }
  }

  class Sentence
  {
    string[] words;
    internal Sentence(string sentence)
    {
      words = sentence.Split();
    }
    
    /*internal string this[int wordNum]
    {
      get { return words[wordNum]; }
      set { words[wordNum] = value; }
    }*/

    internal string get_Item(int wordNum) { return words[wordNum]; }
    internal void set_Item(int wordNum, string value) { words[wordNum] = value; }
  }

  class Circle
  {
    internal double Area { get; } = 0;
    const double Pi = Math.PI;
    internal Circle(double r)
    {
      Area = Pi * r * r;
    }

    
  }

  class Pencil
  {
    internal static string Color = "black";
    internal static Pencil ThePencil= new Pencil();
    /*internal static string Color = "green";*/

    internal Pencil()
    {
      Console.WriteLine($"Color: {Color}");
    }
  }
}
