using Paragon.UI.IO;
using Paragon.UI.Menu;

namespace Paragon.Application;

public static class Game
{
    public static void Run()
    {
        Menus.HomeScreen.Display();

        Output.TypeLine("\nHello, Paragon!");
        Input.ReadNumber(0, 4);
    }
}
