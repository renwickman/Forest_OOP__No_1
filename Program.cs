using System;

namespace Forest_OOP
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Congo", "Tropical");
      f.trees = 0;

      Forest r = new Forest("Rendlesham");
      Console.WriteLine(r.biome);
    }
  }
}
