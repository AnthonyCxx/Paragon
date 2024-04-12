using Paragon.UI.IO;
using Paragon.UI.Contracts;

namespace Paragon.UI.Menu;

public class Menu : IMenu
{
    public string Prompt { get; init;}
    public List<MenuChoice> Choices { get; init; }

    public Menu(string prompt, List<MenuChoice> choices)
    {
        Prompt = prompt;
        Choices = choices;
    }

    public void Display()
    {
        Output.WriteLine(Prompt);

        for (int i = 0; i < Choices.Count; ++i)
        {
            Output.WriteLine($"{i + 1}. {Choices[i].Text}");
        }

        int choice = Input.ReadInteger(1, Choices.Count);
        Choices[choice - 1].Choose();
    }
}