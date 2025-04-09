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
        public static void MainDictExist()
        {
            string jsonString = JsonSerializer.Serialize(MainDict.Dict, new JsonSerializerOptions { WriteIndented = true });
            if (MainDict.Dict == null)
            {
                Core core = new Core();
                core.AddNewRecipe("Mój pierwszy przepis", new List<string> { "one" });
                if (!File.Exists(pathDict))
                {
                    File.WriteAllText(pathDict, jsonString);
                }
            }
            
        }
    }

    public static class ListOfIng
    {
        public static List<string> mlistOfIng = new List<string>();

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
        public void CounterCart()
        {
            
        }

        public void AddListOfIng(string Ing)
        {
            ZakupnikGUI.ListOfIng.mlistOfIng.Add(Ing);
        }

        public void SafeListOfIng()
        {
            string path = "ListaSkładników.txt";
            foreach (var item in ListOfIng.mlistOfIng)
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(item);
                    sw.Close();
                }
               
            }
            
        }
        public void LoadListOfIng()
        {
            string path = "ListaSkładników.txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                foreach (var line in lines)
                {
                    ListOfIng.mlistOfIng.Add(line);
                }
            }
            else
            {
                File.Create(path).Close();
            }
            
            
        }
    }
}
