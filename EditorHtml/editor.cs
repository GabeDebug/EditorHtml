using System.Runtime.Serialization;
using System.Text;

namespace EditorHtml;

public static class Editor
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO EDITOR");
        Console.WriteLine("--------------");
        Start();
    }

    public static void Start()
    {
        var file = new StringBuilder();
        do
        {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
        Console.WriteLine("---------------");
        
        Console.WriteLine("Deseja Salva o Arquivo? [Sim - 1] ou [Não - 2]");
        string text = "";

        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 1: 
                break;
            case 2: System.Environment.Exit(0);
                break;
        }
    }
}