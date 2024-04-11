using Paragon.Domain.Interfaces;

namespace Paragon.UI.Menu;

public static class Menus
{
    public static IMenu HomeScreen { get; } = new Menu("homescreen.txt");
}