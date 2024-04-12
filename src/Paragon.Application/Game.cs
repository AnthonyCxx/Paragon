using Paragon.Domain;
using Paragon.UI.IO;
using Paragon.UI.Menu;

namespace Paragon.Application;

public static class Game
{
    public static void Run()
    {
        Console.Title = Constants.GameName;
        Menus.TitleScreen.Display();
    }

    public static void NewGame()
    {
        Output.WriteLine("New Game!");
    }

    public static void LoadGame()
    {
        Output.WriteLine("Load Game!");
    }

    public static void QuitGame()
    {
        Output.WriteLine("Quitting!");
    }
}
