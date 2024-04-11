using Paragon.Domain.Interfaces;
using Paragon.Domain;
using Paragon.UI.IO;

namespace Paragon.UI.Menu;

public class Menu : IMenu
{
    public string Path { get; init; }
    public List<string>? Choices { get; init; }

    public Menu(string filename)
    {
        Path = System.IO.Path.Combine(Constants.ResourcesFolderPath, filename);
        Choices = null;

        if (!File.Exists(Path))
        {
            throw new FileNotFoundException(Path);
        }
    }

    public void Display()
    {
        Output.TypeFile(Path);
    }

    public int GetChoice()
    {
        if (Choices is null)
        {
            throw new InvalidOperationException("cannot get choice from menu without choices");
        }

        for (int i = 0; i < Choices.Count; ++i)
        {
            Output.TypeLine($"{i + 1}. {Choices[i]}");
        }

        return Input.ReadNumber(0, Choices.Count);
    }
}