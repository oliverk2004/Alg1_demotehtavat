using System;

class Program
{
    public static void Main(string[] args)
    {
        string merkkijono1 = "pallo on pyöreä";
        string merkkijono2 = "pöydällä on paljon erilaisia kirjoja";
        string merkkijono3 = "Algoritmit-kurssi";

        Console.WriteLine("Sanassa (" + merkkijono1 + ") on " + montakoSanaa(merkkijono1) + " sanaa.");
        Console.WriteLine("Sanassa (" + merkkijono2 + ") on " + montakoSanaa(merkkijono2) + " sanaa.");
        Console.WriteLine("Sanassa (" + merkkijono3 + ") on " + montakoSanaa(merkkijono3) + " sanaa.");

    }


    public static int montakoSanaa(string merkkijono)
    {
        string[] sanat = merkkijono.Split(' ');
        int määrä = 0;

        foreach (string sana in sanat)
        {
            if (sana != "") määrä++;
        }

        return määrä;
    }
}


