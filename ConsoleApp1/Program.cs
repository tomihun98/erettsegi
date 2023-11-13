using System;
using System.IO;

class Program
{
    static void Main()
    {
        // 1. feladat: Olvassa be és tárolja el az utca.txt állományban talált adatokat.
        string[] sorok = File.ReadAllLines("utca.txt");

        // 2. feladat: Hány telek adatai találhatók az állományban?
        Console.WriteLine($"2. feladat: A telek adatok száma: {sorok.Length}");

        // 3. feladat: Kérje be egy tulajdonos adószámát, és írassa ki az építmény adatait.
        Console.Write("3. feladat: Kérem adja meg a tulajdonos adószámát: ");
        string adoszam = Console.ReadLine();

        bool talalat = false;

        foreach (string sor in sorok)
        {
            string[] adatok = sor.Split(' ');

            if (adatok[0] == adoszam)
            {
                Console.WriteLine($"Az építmény adatai: {adatok[1]} {adatok[2]} {adatok[4]} m2");
                talalat = true;
                break;  // Mivel megtaláltuk a keresett adószámot, nincs szükség további keresésre.
            }
        }

        if (!talalat)
        {
            Console.WriteLine("Nem szerepel az adatállományban.");
        }
    }
}
has context menu
Compose