using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ZakupnikGUI
{
    public class MainDict
    {
        private static string pathDict = File.ReadAllText("Dictionary.json");
        public static Dictionary<string, Przepis> Dict { get; set; } = JsonSerializer.Deserialize<Dictionary<string, Przepis>>(pathDict);
        public static List<string> _lista = new List<string>();
        
        public static List<string> DicList()
        {
            foreach (var key in Dict.Keys)
            {
                _lista.Add(key);
            }
            return _lista;
        }
    }

    
    internal class Core
    {
        
        
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
           
            var stringName = name;
            MainDict.Dict.Add(name, new Przepis { Name = name, Ingridiens = quantity });

            string jsonString = JsonSerializer.Serialize(MainDict.Dict, new JsonSerializerOptions { WriteIndented = true });
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
