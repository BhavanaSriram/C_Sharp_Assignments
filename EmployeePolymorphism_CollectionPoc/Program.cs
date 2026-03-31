using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> list = new List<string>();
        list.Add("A");
        list.Add("B");
        list.Add("C");
        foreach (var i in list) Console.WriteLine(i);
        list[1] = "BB";
        list.Remove("A");
        Console.WriteLine("List After Update/Delete:");
        foreach (var i in list) Console.WriteLine(i);

        HashSet<int> set = new HashSet<int>();
        set.Add(1);
        set.Add(2);
        set.Add(3);
        foreach (var i in set) Console.WriteLine(i);
        set.Remove(2);
        Console.WriteLine("Set After Delete:");
        foreach (var i in set) Console.WriteLine(i);

        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "One");
        dict.Add(2, "Two");
        dict.Add(3, "Three");
        foreach (var i in dict) Console.WriteLine(i.Key + " " + i.Value);
        dict[2] = "Two Updated";
        dict.Remove(1);
        Console.WriteLine("Dictionary After Update/Delete:");
        foreach (var i in dict) Console.WriteLine(i.Key + " " + i.Value);
    }
}