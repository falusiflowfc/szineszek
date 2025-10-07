using System;
using System.Collections.Generic;
using System.IO;
using szineszek;
namespace szineszek
{

    internal class Program
    {
        static void Main(string[] args)
        {
            const string fajl = "D:\\Info\\random\\szineszek\\szineszek.txt";

            List<Szineszek> objektum = new List<Szineszek>();

            using (StreamReader olvaso = new StreamReader(fajl))
            {
                //_ = olvaso.ReadLine(); első sor átugrása
                

                while (!olvaso.EndOfStream)
                {
                    objektum.Add(new(olvaso.ReadLine()));
                }

                foreach (var item in objektum)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            Console.WriteLine($"A sorok száma:{objektum.Count}");
            Console.WriteLine($"fc vok");

        }
    }

}
