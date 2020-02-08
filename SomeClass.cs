using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
  class SomeClass
  {
    int age;
    String name;

    public SomeClass(int age, String name)
    {
      this.age = age;
      this.name = name;
    }

    public void PrintName()
    {
      System.Console.WriteLine(String.Format("name = {0}", this.name));
    }
  }
}
