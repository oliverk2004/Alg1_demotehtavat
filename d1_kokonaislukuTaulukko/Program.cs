using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

/// @author Oliver
/// @version 31.10.2024
/// <summary>
/// D1 TEHTÄVÄ
/// Kirjoita ohjelma, jolla voidaan laskea,
/// kuinka moni kokonaislukutaulukon alkioista on jaollinen annetulla luvulla m.
/// Muodosta taulukko, joka sisältää satunnaisia kokonaislukuja,
/// ja laske kuinka moni sen luvuista on jaollinen luvuilla m=2, m=3 ja m=5.
/// </summary>
public class Program
{
    /// <summary>
    /// 
    /// </summary>
    public static void Main()
    {
        Random rnd = new Random();
        
        int[] kokonaisluvut = new int[10];
        
        
        List<int> jaolliset2 = new List<int>();
        List<int> jaolliset3 = new List<int>();
        List<int> jaolliset5 = new List<int>();

        for (int i = 0; i < kokonaisluvut.Length; i++)
        {
            kokonaisluvut[i] = rnd.Next(1, 100); // eli satunnainen luku 1-100 väliltä
            // Ongelma tässä on nyt se, että kokonaislukutaulukko voi sisältää
            // saman luvun. 
            
            
            if (kokonaisluvut[i] % 2 == 0)
            {
                jaolliset2.Add(kokonaisluvut[i]);
            }
            if (kokonaisluvut[i] % 3 == 0)
            {
                jaolliset3.Add(kokonaisluvut[i]);
            }
            if (kokonaisluvut[i] % 5 == 0)
            {
                jaolliset5.Add(kokonaisluvut[i]);
            }


        }

        Console.WriteLine("Kokonaisluvut ovat: " + string.Join(", ", kokonaisluvut));
        
        Console.WriteLine("Luvulla 2 jaolliset: " + string.Join(", ", jaolliset2));
        Console.WriteLine("Luvulla 3 jaolliset: " + string.Join(", ", jaolliset3));
        Console.WriteLine("Luvulla 5 jaolliset: " + string.Join(", ", jaolliset5));
    }

}