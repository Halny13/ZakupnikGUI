using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ZakupnikGUI;

namespace Core
{/*
    public static class MainDict
    {
        private static string pathDict = File.ReadAllText("Dictionary.json");
        private static Dictionary<string, Przepis> _przepisy;
        Dictionary<string, Przepis> D
        {
            get => _przepisy;
            private set => _przepisy = value;
        }


        private static void Dict()
        {
            try
            {
                if (File.Exists(pathDict))
                {
                    string jsonContent = File.ReadAllText(pathDict);
                    _przepisy = JsonSerializer.Deserialize<Dictionary<string, Przepis>>(jsonContent);
                }
                else
                {
                    _przepisy = new Dictionary<string, Przepis>();
                    // Możesz tutaj dodać jakieś domyślne przepisy jeśli chcesz
                    SaveDictionary(); // Tworzy pusty plik
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd ładowania słownika przepisów: {ex.Message}", "Błąd",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                _przepisy = new Dictionary<string, Przepis>();
            }
        }

        public static void SaveDictionary()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonContent = JsonSerializer.Serialize(_przepisy, options);
                File.WriteAllText(pathDict, jsonContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd zapisywania słownika przepisów: {ex.Message}", "Błąd",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }*/
}
