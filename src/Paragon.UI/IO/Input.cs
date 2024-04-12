using System.Runtime.Serialization;

namespace Paragon.UI.IO;

public static class Input
{
    private static readonly string input_prompt;

    static Input()
    {
        input_prompt = "input> ";
    }


    public static int ReadInteger(int minimum, int maximum)
    {
        string? user_input;
        int value;

        do
        {
            Output.Write(input_prompt, prompt: false);
            user_input = Console.ReadLine();

            if (user_input is null)
            {
                Output.WriteError("no input");
            }

            if (!Int32.TryParse(user_input, out value))
            {
                Output.WriteError("input not an integer");
            }
            else if (value < minimum || value > maximum)
            {
                Output.WriteError($"number \'{value}\' not in the range [{minimum},{maximum}]");
            }
            else
            {
                return value;
            }

        } while (true);
    }
}