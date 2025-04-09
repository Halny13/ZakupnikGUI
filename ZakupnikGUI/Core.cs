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
        
        public static List<string> ListOfRecipes()
        {
            foreach (var key in Dict.Keys)
            {
                _lista.Add(key);
            }
            return _lista;
        }
        public static string PathReturn()
        {
            return pathDict;
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
            SafeToFile();
        }
        public void DeleteRecipe(string name)
        {
            MainDict.Dict.Remove(name);
            SafeToFile();
        }

    
        public void ListOfRecipes()
        {

        }
        public void SafeToFile()
        {
            string jsonString = JsonSerializer.Serialize(MainDict.Dict, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("Dictionary.json", jsonString);
        }
            /*if (File.Exists("Dictionary.json"))
            {
                string jsonString = JsonSerializer.Serialize(MainDict.Dict, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText("Dictionary.json", jsonString);

            }
            else
            {
                string jsonString = JsonSerializer.Serialize("cokolwiek", new JsonSerializerOptions { WriteIndented = true });

                using (FileStream fs = File.Create("Dictionary.json"))
                {
                    using (StreamWriter writer = new StreamWriter(fs))
                    {
                        writer.WriteAsync(jsonString);
                    }
                }
                SafeToFile();
            }
        }
           
        {
            string jsonString = JsonSerializer.Serialize(MainDict.Dict, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("Dictionary.json", jsonString);
            
        }
        */
        public void CounterCart()
        {

        }
    }
}
