using System.Text.RegularExpressions;

namespace EditorHtml;

public class Viewer
{
    static void Show(string text)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO Visualização");
        Console.WriteLine("--------------");
        Replace(text);
    }

    static void Replace(string text)
    {
        
    }
}