using Clothes_pololetniprojekt.model;

namespace Clothes_pololetniprojekt
{
    internal class Program
    {
        public static List<ClothingArticle> ListClothing = new List<ClothingArticle>();
        static string ulozeni_clothes = "databaze.json";

        static void NacistClothes()
        {
            if (File.Exists(ulozeni_clothes))
            {
                string json = File.ReadAllText(ulozeni_clothes);
                if (json != "")
                {
                    List<ClothingArticle> nacteny_list_p = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ClothingArticle>>(json);
                    ListClothing = nacteny_list_p;

                }

            }
            else
            {
                File.Create(ulozeni_clothes).Dispose();
            }
        }
        static void UlozitData()
        {
            string ulozit_poznamky = Newtonsoft.Json.JsonConvert.SerializeObject(ListClothing);
            File.WriteAllText(ulozeni_clothes, ulozit_poznamky);
        }
        static int Getimput()
        {
            while (true)
            {
                Console.WriteLine("1)Přidat položku");
                Console.WriteLine("2)Smazat položku");
                Console.WriteLine("3)Vyhledat");
                Console.WriteLine("4)Editovat položku");
                Console.WriteLine("5)Zobrazit seřazený seznam podle zadané vlastnosti");
                Console.WriteLine("6)Konec");
                Console.WriteLine("Napiš číslo funkce kterou chceš využít: ");
                string radek = Console.ReadLine();
                int cisloFunkce;
                if (!int.TryParse(radek, out cisloFunkce))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Zadej znovu:");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                if (cisloFunkce > 6 || cisloFunkce < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Zadej znovu:");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                return cisloFunkce;
            }
        }
        static void Main(string[] args)
        {
            ClothingArticle Cepice = new ClothingArticle ("cepice","Bape", 3000, "cernobila","M");
            Console.WriteLine(Cepice.GetDisplayPrice());


        }
    }
    }
