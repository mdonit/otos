using LottoSzimulator.Data;
using LottoSzimulator.Models;
using System;
using System.IO;
using System.Linq;

namespace LottoFeltoltes
{
    class Program
    {
        static void Main(string[] args)
        {
            LottoAdatContext db = new LottoAdatContext();

            if (!db.Otos.Any())
            {
                var sorok = File.ReadAllLines(@"E:\Donat\tanfolyam\classes\Asztali es mobil alkalmazasok fejlesztese és tesztelese\03\LottoSzamok.csv");

                foreach (var sor in sorok)
                {
                    try
                    {
                        db.Otos.Add(new Huzas(sor));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Hibás: " + sor);
                    }
                }
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine($"Az Otos tábla már tartalmaz {db.Otos.Count()} db rekordot!");
            }

            Console.ReadLine();
        }
    }
}
