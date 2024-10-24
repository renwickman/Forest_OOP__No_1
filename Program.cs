using System;

namespace Forest_OOP
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Congo", "Tropical");
      f.Grow();
      f.Grow();
      f.Grow();
      f.Grow();
      Console.WriteLine(f.name);
      Console.WriteLine(f.biome);
      Console.WriteLine(f.trees);
      Console.WriteLine(f.age);
      
      Console.WriteLine("");
      Console.WriteLine("");

      Forest r = new Forest("Rendlesham");
      Console.WriteLine(r.biome);
      Console.WriteLine(r.name);
    }
  }
}
