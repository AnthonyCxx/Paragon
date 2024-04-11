using System.Numerics;

namespace Paragon.UI.IO;

public static class Input
{
    public static T ReadNumber<T>(T minimum, T maximum) where T: INumber<T>
    {
        string? user_input;
        T value = T.Zero;

        do
        {
            user_input = Console.ReadLine();
        
            if (!T.TryParse(user_input, System.Globalization.NumberStyles.Number, null, out value))
            {
                Output.TypeError($"number not in range [{minimum},{maximum}]");
            }

        } while (user_input is not null && value >= minimum && value <= maximum);
    
        return value;
    }
}