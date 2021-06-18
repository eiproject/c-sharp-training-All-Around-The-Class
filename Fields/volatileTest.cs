using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Fields
{
  class volatileTest
  {
    private volatile bool _isStop;
    internal void workingTask()
    {
      int counter = 0;
      while (!_isStop)
      {
        Console.WriteLine(counter);
        counter++;
      }
      Console.WriteLine("Thread terminated.");
    }

    internal void stopWorkingTask()
    {
      _isStop = true;
    }
  }

  class runVolatileTestWorker
  {
    internal static void Run()
    {
      volatileTest T = new volatileTest();
      Thread Worker = new Thread(T.workingTask);
      Worker.Start();
      Console.WriteLine("Main thread: starting worker thread...");
      while (!Worker.IsAlive)
        Console.WriteLine("Starting ...");
        ;
      Thread.Sleep(5);
      T.stopWorkingTask();
      Worker.Join();
    }
  }
}
