namespace Paragon.UI.IO;

public static class Output
{
    private static readonly int intercharacter_write_delay_ms;

    static Output()
    {
        intercharacter_write_delay_ms = 80;
    }

    public static void TypeCharacter(char character)
    {
        Console.Write(character);
        Console.Out.Flush();

        Thread.Sleep(intercharacter_write_delay_ms);
    }

    public static void Type(string message)
    {
        foreach (char character in message)
        {
            TypeCharacter(character);
        }
    }

    public static void TypeLine(string message)
    {
        foreach (char character in message)
        {
            TypeCharacter(character);
        }

        Type(Environment.NewLine);
    }

    public static void TypeFile(string filepath)
    {
        int character;

        using (StreamReader reader = new StreamReader(filepath))
        {
            while ((character = reader.Read()) != -1)
            {
                TypeCharacter((char) character);
            }
        }
    }

    public static void TypeError(string message)
    {
        Type("error> ");
        TypeLine(message);
    }
}