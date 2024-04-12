using Paragon.UI.IO;

namespace Paragon.UI.Menu;

public struct MenuChoice
{
    public delegate void OnChosenDelegate(/*params object[] args)*/);

    public string Text { get; init; }
    private OnChosenDelegate OnChosen { get; init; }

    private Menu? NextMenu { get; init; }

    public MenuChoice(string text, OnChosenDelegate on_chosen, Menu? next_menu)
    {
        Text = text;
        OnChosen = on_chosen;
        NextMenu = next_menu;
    }

    public void Choose()
    {
        OnChosen?.Invoke();
        NextMenu?.Display();
        
        for (int i = 0; i < 3; ++i)
        {
            Output.WriteLine("", prompt: false);
        }
    }
}