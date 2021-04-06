using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students1 = new Dictionary<int, string>();
            students1.Add(123, "Salih");
            students1.Add(235, "Metin");

            MyDictionary<int, string> students2 = new MyDictionary<int, string>();
            students2.Add(1653, "Yiğit");
            students2.Add(3425, "Ahmet");
        }
    }
}
