namespace DoenaSoft.NumberSystemConverter;

public static class ConverterExtensions
{
    public static string Convert(this INumberSystemConverter from
        , string input
        , INumberSystemConverter to)
    {
        if (from == null)
        {
            throw new ArgumentNullException(nameof(from));
        }
        else if (to == null)
        {
            throw new ArgumentNullException(nameof(to));
        }

        var intValue = from.ToULong(input);

        var result = to.FromULong(intValue);

        return result;
    }
}