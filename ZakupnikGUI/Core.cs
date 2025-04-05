using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ZakupnikGUI
{
    internal class Core
    {
        private static string pathDict = File.ReadAllText("Dictionary.json");
        public static Dictionary<string, Przepis> loadedDictionary = JsonSerializer.Deserialize<Dictionary<string, Przepis>>(pathDict);

        private List<string> _list = new List<string>();
        private string _path = "Przepisy.txt";
        public void ListCreator(string name, List<string> quantity)
        {

            var temp = default(string);
            temp = name + ";" + quantity;
            _list.Add(temp);

        }
        public void AddNewRecipe(string name, List<string> quantity)
        {
            /* var tempString = default(string);
             var recipe = new Przepis();
             recipe.Name = name;
             recipe.Ingridiens = quantity;
             tempString = name+"xx";
             foreach (var item in quantity)
             {
                 tempString += "x"+item;
             }
             using (StreamWriter writer = File.AppendText(_path))
             {
                 writer.WriteLine(tempString);
             }

              string loadedJson = File.ReadAllText("people.json");
         Dictionary<string, Person> loadedPeople = JsonSerializer.Deserialize<Dictionary<string, Person>>(loadedJson);


             */
            var stringName = name;
            loadedDictionary[name] = new Przepis { Name = name, Ingridiens = quantity };
            string jsonString = JsonSerializer.Serialize(loadedDictionary, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("Dictionary.json", jsonString);





        }
        public void DeleteRecipe()
        {

        }
        public void ListOfRecipes()
        {

        }
        public void SafeToFile()
        {

        }
        public void CounterCart()
        {

        }
    }
}
