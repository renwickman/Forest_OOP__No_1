using System;

namespace Forest_OOP
{
  class Forest
  {
    public string name;
    public int trees;
    public int age;
    public string biome;

    public Forest(string name, string biome) 
    {
      this.name = name;
      this.biome = biome;
      age = 1;
    }

    public Forest(string name) : this(name, "Unknown")
    {
      Console.WriteLine("Default Value is there in case there is none");
    }

    public int Grow()
    {
      this.trees += 30;
      this.age++;
      return this.trees;
    }

    public int Burn() 
    {
      trees -= 20;
      age++;
      return trees;
    }
  }

}