using System;

class Program
{
    public static void Main(string[] args)
    {
        string merkkijono1 = "pallo on pyöreä";
        string merkkijono2 = "pöydällä on paljon erilaisia kirjoja";

        montakoSanaa(merkkijono1);
        Console.WriteLine(montakoSanaa(merkkijono2));

    }


    public static int montakoSanaa(string merkkijono)
    {
        int määrä = 0;
        string välilyönti = " ";


        while (merkkijono.Contains(välilyönti))
        {
            määrä += 1;
        }
        
        return määrä;
    }
}


