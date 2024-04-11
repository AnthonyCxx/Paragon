namespace Paragon.Domain.Interfaces;

public interface IMenu
{
    public string Path { get; init; }
    public List<string>? Choices { get; init;}

    void Display();
    int GetChoice();
}