using System;

namespace Ornek_GenericMyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> Secenekler = new MyDictionary<string>();
            Secenekler.Add("HAYATI DOLU DOLU YAŞAMAK");
            Secenekler.Add("HAYATI DOLU DOLU YAŞAMAK");
            Secenekler.Add("HAYATI DOLU DOLU YAŞAMAK");
            Console.WriteLine(Secenekler.Count);
        }
    }
}
