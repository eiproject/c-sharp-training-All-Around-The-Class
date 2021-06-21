using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Fields
{
  class volatileTest
  {
    private volatile bool _isStop;
    private bool _isStop2;
    internal void workingTask()
    {
      int counter = 0;
      while (!_isStop)
      {
        Console.WriteLine("counter: " + counter.ToString());
        counter++;
      }
      Console.WriteLine("Thread terminated.");
    }

    internal void anotherWorkingTask()
    {
      int counter = 0;
      while (!_isStop2)
      {
        Console.WriteLine("another counter: " + counter.ToString());
        counter++;
        if (counter == 20)
        {
          _isStop = true;
          _isStop2 = true;
        }
      }
      Console.WriteLine("Another thread terminated.");
    }

    internal void stopWorkingTask()
    {
      _isStop = true;
    }

    internal void stopWorkingTask2()
    {
      _isStop2 = true;
    }

    internal void startWorkingTask()
    {
      _isStop = false;
    }
    internal void startWorkingTask2()
    {
      _isStop = false;
    }
  }

  class runVolatileTestWorker
  {
    internal static void Run()
    {
      volatileTest T = new volatileTest();
      Thread Worker = new Thread(T.workingTask);
      Thread AnotherWorker = new Thread(T.anotherWorkingTask);
      Console.WriteLine("Main thread: starting worker thread...");
      Worker.Start();
      while (!Worker.IsAlive)
        Console.WriteLine("Starting ...");
        ;
      Thread.Sleep(100);
      AnotherWorker.Start();
      Thread.Sleep(200);
      /*AnotherWorker.Start(); // Error : Thread is running or terminated*/
      Thread.Sleep(200);
      T.stopWorkingTask();
      T.stopWorkingTask2();
    }
  }
}
