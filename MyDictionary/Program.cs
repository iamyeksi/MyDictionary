using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryList<int, string> names = new DictionaryList<int, string>();

            names.Add(21, "Yakup Kadri");
            names.Add(20, "Busesu");
            names.Add(24, "Elif");


            Console.WriteLine("Yaşı: " + names.Keys[0] + "\t" + "İsmi: " + names.Values[0]);
            Console.WriteLine("Yaşı: " + names.Keys[1] + "\t" + "İsmi: " + names.Values[1]);
            Console.WriteLine("Yaşı: " + names.Keys[2] + "\t" + "İsmi: " + names.Values[2]);



        }
    }
}
