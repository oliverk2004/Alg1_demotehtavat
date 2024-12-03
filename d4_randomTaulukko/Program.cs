using System;

// Tätä voisi hyödyntää valintamenetelmä (selection sort) algoritmin toteuttamiseen. 

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int[] taulukko = new int[10];

        for (int i = 0; i < taulukko.Length; i++)
        {
            taulukko[i] = random.Next(1,50);
        }
        
        Console.WriteLine("Taulukko: " + string.Join(",", taulukko));
        Valintamenetelma(taulukko);
        Console.WriteLine("Taulukko vaihdon jälkeen: " + string.Join(",", taulukko));
    }


    /// <summary>
    /// Taulukon ensimmäinen alkio vaihtaa paikkaa löytyneen pienimmän alkion kanssa.
    /// </summary>
    /// <param name="taulukko">taulukko, josta etsitään.</param>
    public static void Valintamenetelma(int[] taulukko)
    {
        int pienin = 0;
        
        for (int i = 1; i < taulukko.Length; i++)
        {
            if (taulukko[i] < taulukko[pienin])
            {
                pienin = i;
            }
        }
        (taulukko[0], taulukko[pienin]) = (taulukko[pienin], taulukko[0]);
    }


}