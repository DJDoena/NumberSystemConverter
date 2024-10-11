namespace DoenaSoft.NumberSystemConverter;

public static class ConverterExtensions
{
    public static string Convert(this INumberSystemConverter from, string input, INumberSystemConverter to)
    {
        if (from == null)
        {
            throw new ArgumentNullException(nameof(from));
        }
        else if (to == null)
        {
            throw new ArgumentNullException(nameof(to));
        }

        var intValue = from.ToUInt(input);

        var result = to.FromUInt(intValue);

        return result;
    }
}