// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
  class Program
  {
    static void reffun(out int i)
    {
        i =50;
       // Console.WriteLine(i);
    } 
    static void Main(string[] args)
    {
        int r;

      //Console.WriteLine(r);
      reffun(out r);    
      Console.WriteLine(r);    
    }

  }
}