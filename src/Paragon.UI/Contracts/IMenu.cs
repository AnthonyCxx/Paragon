using Paragon.UI.Menu;

namespace Paragon.UI.Contracts;

public interface IMenu
{
    public string Prompt { get; init;}
    public List<MenuChoice> Choices { get; init;}

    void Display();
}