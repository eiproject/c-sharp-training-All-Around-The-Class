using System;
using System.Collections.Generic;
using System.Text;

namespace Fields
{
  class UnsafeAndPointer
  {
    internal unsafe void UnsafeTest()
    {
      int val = 50;
      int* x = &val;
      val = 51;
      int* y = &val;

      IntPtr ptr = (IntPtr) x;

      Console.WriteLine("Data: {0} ", val);
      Console.WriteLine("Address: {0}", (int)x);
      Console.WriteLine("Address: {0}", (long)y);
      Console.WriteLine("Data: {0} ", ptr.ToString("x"));


      int* numbers = stackalloc int[] { 0, 1, 3, 5, 20, 500 };
      int* p1 = &numbers[0];
      int* p2 = &numbers[1];
      int* p3 = &numbers[2];
      int* p4 = &numbers[3];
      int* p5 = &numbers[4];
      int* p6 = &numbers[5];

      // 4 byte storage
      Console.WriteLine($"All address = { (int)p1 }, { (int)p2 }, { (int)p3 }, { (int)p4 }, { (int)p5 }, { (int)p6 }");

      long* numbers2 = stackalloc long[] { 0, 1, 3, 5, 20, 500 };
      long* q1 = &numbers2[0];
      long* q2 = &numbers2[1];
      long* q3 = &numbers2[2];
      long* q4 = &numbers2[3];
      long* q5 = &numbers2[4];
      long* q6 = &numbers2[5];

      // 8 byte storage
      Console.WriteLine($"All address = { (long)q1 }, { (long)q2 }, { (long)q3 }, { (long)q4 }, { (long)q5 }, { (long)q6 }");
      
      Console.WriteLine(p5 - p1);  // output: 4
      Console.WriteLine(q5 - q1);  // output: 4


      Console.ReadKey();
    }
  }
}
