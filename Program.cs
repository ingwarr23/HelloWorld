using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      SomeClass myClass = new SomeClass(12, "gica");
      myClass.PrintName();
    }
  }
}
