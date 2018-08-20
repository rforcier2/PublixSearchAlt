using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main(string[] args)
        {
            
            var s = "hello world! This hello is my hello home";
            var n = String.Join(" ", s.Split(' ').Reverse().ToArray());
            
            if(n.Contains("hello"))
            {
              int index = n.IndexOf("hello");
              Console.WriteLine("Found at position: " + index);
            }
        }
    }
