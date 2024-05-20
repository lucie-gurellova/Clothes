using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothes_pololetniprojekt.model
{
    internal class ClothingArticle
    {
        public string nazev;
        public string znacka;
        private int cena;
        public string barva;
        public string velikost;
        public string kategorie;


        public ClothingArticle(string u_nazev, string u_znacka, int u_cena, string u_barva, string u_velikost)
        {
            nazev = u_nazev;
            znacka = u_znacka;
            cena = u_cena;
            barva = u_barva;
            velikost = u_velikost;


        }
        public void podoba_baneru()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(nazev.ToUpper());
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("           ");
            Console.WriteLine("Značka: " + znacka);
            Console.WriteLine("Cena: " + cena);
            Console.WriteLine("Barva: " + barva);
            Console.WriteLine("Velikost: " + velikost);
            Console.WriteLine("Kategorie: " + kategorie);
            Console.WriteLine("           ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------------------------------------------------------------------");

        }

        public static ClothingArticle ziskat_clothes(string vypsat)
        {
            int count = 0;
            foreach (ClothingArticle k in Program.ListClothing)
            {
                Console.WriteLine(count + ") " + k.nazev);
                count = count + 1;

            }
            Console.WriteLine(vypsat);
            string clothes = Console.ReadLine();
            int index = int.Parse(clothes);
            ClothingArticle objekt_clothes = Program.ListClothing[index];
            return objekt_clothes;
        }

        public string GetDisplayPrice()
        {
            return cena + "Kč";
        }
    }

}

