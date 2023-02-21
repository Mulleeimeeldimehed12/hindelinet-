using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> koolid = new Dictionary<int, string>();
  
        koolid.Add(1, "Tartu Raatuse kool");
        koolid.Add(2, "Tallinna Laagna Gümnaasium");
        koolid.Add(3, "Tallinna TööstusHaridusKeskus");
  
        foreach (string kool in koolid.Values)
        {
            Console.WriteLine(kool);
        }
    }
}
