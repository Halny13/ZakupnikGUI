using Core;
using System.Text.Json;

namespace ZakupnikGUI
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var main = new ZakupnikApp();
            main.Introduce();
            main.AskWhatToDo();
        }
    }
}
