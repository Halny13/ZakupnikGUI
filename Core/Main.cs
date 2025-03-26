using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ZakupnikGUI;

namespace ZakupnikGUI
{
    public class ZakupnikApp

    {
        private static string pathDict = File.ReadAllText("Dictionary.json");
        public static Dictionary<string, Przepis> loadedDictionary = JsonSerializer.Deserialize<Dictionary<string, Przepis>>(pathDict);

        public ZakupnikManager ZakupnikManager { get; set; } = new ZakupnikManager();
        public void Introduce()
        {
            Console.WriteLine("Witaj w programie który zrobi Ci liste zakupów z wybranych przepisów!");
        }

        public void AddRecipe()
        {

            var option = default(string);
            var name = default(string);
            var skladnik = default(string);
            var ilosc = default(int);
            var iloscString = default(string);
            var list = new List<string>();
            Console.WriteLine("Podaj nazwę przepisu");
            name = Console.ReadLine();
            Console.WriteLine("Dodaj składnik i jego ilość");
            option = "T";
            while (option == "T")
            {

                skladnik = Console.ReadLine();
                ilosc = int.Parse(Console.ReadLine());
                iloscString = ilosc.ToString();
                skladnik = skladnik + ":" + iloscString;
                list.Add(skladnik);
                Console.WriteLine("Czy chcesz dodać kolejny składnik? T/N");
                option = Console.ReadLine();
            }

            ZakupnikManager.AddNewRecipe(name, list);
            AskWhatToDo();
        }

        public void DeleteRecipe()
        {

        }

        public void ShopingList()
        {
            foreach (var key in loadedDictionary.Keys)
            {
                foreach (var item in loadedDictionary[key].Ingridiens)
                {
                    Console.WriteLine($"Klucz={key}, wartości: {loadedDictionary[key].Name}, {item} aaa");
                }

            }
            AskWhatToDo();
        }

        public void RecipesList()
        {

        }
        public void AskWhatToDo()
        {
            var option = default(string);


            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("Wybierz z listy:");
            Console.WriteLine("Stworzyć listę zakupów? - 1");
            Console.WriteLine("Wyświetlić wszystkie przepisy? - 2");
            Console.WriteLine("Dodać przepis? - 3");
            Console.WriteLine("Usunąć przepis? - 4");
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    ShopingList(); break;
                case "2":
                    RecipesList(); break;
                case "3":
                    AddRecipe(); break;
                case "4":
                    DeleteRecipe(); break;
                default: Console.WriteLine("Zła opcja"); break;

            }
        }
    }
}
