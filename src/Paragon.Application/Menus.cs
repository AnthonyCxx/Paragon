using Paragon.UI.Menu;

namespace Paragon.Application;

public static class Menus
{
    public static Menu TitleScreen = new(
        "< << PARAGON >> >",
        new List<MenuChoice>() {
            new MenuChoice("New Game", Game.NewGame, Introduction01),
            new MenuChoice("Load Game", Game.LoadGame, null),
            new MenuChoice("Quit Game", Game.QuitGame, null)
        }
    );

    public static Menu Introduction01 = new(
        "Introduction",
        new List<MenuChoice> {
            new MenuChoice("Introduction choice one", null, null)
        }
    );
}