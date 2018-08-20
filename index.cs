//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var s = "hello world! This is my home";
            var n = String.Join(" ", s.Split(' ').Reverse().ToArray());
            if(n.Contains("hello")){
              int index = n.IndexOf("hello");
              Console.WriteLine("Found at position: " + index);
            }
        }
    }
}
