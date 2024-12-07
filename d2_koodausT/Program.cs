using System;
/// @author Oliver
/// <summary>  
/// D2 TEHTÄVÄ
/// </summary>
class Program
{
    private const int PMAX = 5; // max 5 alkion taulukoita.
    
    static void Main(string[] args)
    {
        Random rnd = new Random();
        
        int[] pino = new int[PMAX];
        for (int i = 0; i < PMAX; i++)
        {
            pino[i] = rnd.Next(0, 2) == 0 ? 0 : rnd.Next(1, 10); // joko täyttää paikan kokonaisluvulla 1-10 tai jättää sen tyhjäksi (0).
        }

        Console.WriteLine($"Pino: " + (onkoPinoTaynna(pino) ? "Täynnä" : "Ei täynnä"));
        Console.WriteLine("Sisältö: [" + string.Join(", ", pino) + "]");

    }

    
    /// <summary>
    /// Aliohjelma, joka tarkistaa onko pino täynnä.
    /// Tarkoituksena se, että jos taulukossa on kokonaisluku (muu kuin 0), niin se lisää n alkiota eli
    /// taulukossa olevien täysien paikkojen lukumäärää silmukan avulla.  
    /// </summary>
    /// <param name="array">taulukko kokonaislukuja tai tyhjiä paikkoja</param>
    /// <returns></returns>
    public static bool onkoPinoTaynna(int[] array)
    {
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                n++;
            }
        }
        return n == PMAX; // Palauttaa true jos pino on täynnä. 
    }
}

