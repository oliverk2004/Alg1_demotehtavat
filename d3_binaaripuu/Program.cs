using System;
using System.Xml.Serialization;

/// <summary>
/// D3 TEHTÄVÄ
/// Ohjelma, joka toteuttaa Solmu-luokan, jonka avulla ensin muodostetaan binääripuu ja sen jälkeen
/// pystytään tulostamaan halutut arvot halutuista lapsisolmuista. 
/// </summary>
class Program
{
    public static void Main(string[] args)
    {
        // Lähdetään muodostamaan puuta juuresta. 
        Solmu juuri = new Solmu(15);
        // Sitten lähdetään lisäämään lapsia. 
        // Lähdetään liikkeelle vasemmasta alipuusta. 
        juuri.Left = new Solmu(10);
        juuri.Left.Left = new Solmu(8);
        juuri.Left.Right = new Solmu(13);
        juuri.Left.Right.Left = new Solmu(11);
        // Tehdään sitten juuren oikea alipuu. 
        juuri.Right = new Solmu(21);
        juuri.Right.Left = new Solmu(20);
        juuri.Right.Right = new Solmu(23);
        // Binääripuu on nyt siis muodostettu. 
        
        // Seuraavaksi käytetään Solmu-luokkaa tulostaakseemme juurisolmun oikean puoleisen lapsisolmun arvon. 
        Console.WriteLine("Juurisolmun oikeanpuoleisen lapsisolmun arvo on: " + juuri.Right.Key);
        // Sitten vielä tulostetaan äsken tulostetun solmun vasemmanpuoleisen lapsisolmun arvo.
        Console.WriteLine("Edellä tulostetun vasemmanpuoleisen lapsisolmun arvo on: " + juuri.Right.Left.Key);
        
    }


    /// <summary>
    /// Luokka hakee binääripuusta halutut alkiot. 
    /// </summary>
    public class Solmu
    {
        public int Key;
        public Solmu Left;
        public Solmu Right;


        /// <summary>
        /// Jotta puu pystytään luomaan. 
        /// </summary>
        /// <param name="key"></param>
        public Solmu(int key)
        {
            this.Key = key;
            this.Left = null;
            this.Right = null;
        }
    }
}
