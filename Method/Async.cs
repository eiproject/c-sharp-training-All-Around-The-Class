using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
  internal class CountingStar
  {
     static bool isCounting = true;
    /*static int numberOfStars = 0;*/

    /*// example
    public static async Task<int> Method1()
    {
      int count = 0;
      await Task.Run(() =>
      {
        for (int i = 0; i < 100; i++)
        {
          Console.WriteLine(" Method 1");
          count += 1;
        }
      });
      return count;
    }*/
    internal static async Task<int> startCounting()
    {
      int numberOfStars = 0;
      await Task.Run(() => {
        for (int j = 0; j < 10; j++)
        {
          Console.WriteLine("Counting stars: " + j.ToString());
          numberOfStars += 1;
        }
    });

      return numberOfStars;
    }

    public static void countAsteroid()
    {
      for (int i = 0; i < 20; i++)
      {
        Console.WriteLine("Number of asteorid: " + i.ToString());
      }
    }

    internal static void stopCounting(int count)
    {
      Console.WriteLine("Number of star counted: " + count.ToString());
    }

  }
}
