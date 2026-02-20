namespace EditorHtml;

public class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Black;
        
        Draw();
    }

    public static void Draw()
    {
        Console.Write("+");
        for (int i = 0; i < 30; i++)
        {
            Console.Write("-");
        }
        Console.Write("+");
        Console.Write("\n");

        for (int lines = 0; lines <= 10; lines++)
        {
            Console.Write("|");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            Console.Write("\n");
        }
        Console.Write("+");
        for (int i = 0; i < 30; i++)
        {
            Console.Write("-");
        }
        Console.Write("+");
        Console.Write("\n");
    }

    public static void WriteOp()
    {
        Console.SetCursorPosition(3,2);
    }
}