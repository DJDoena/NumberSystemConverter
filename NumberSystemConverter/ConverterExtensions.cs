namespace DoenaSoft.NumberSystemConverter;

/// <summary>
/// Extension methods for <see cref="INumberSystemConverter"/> to enable conversion between different number systems.
/// </summary>
public static class ConverterExtensions
{
    /// <summary>
    /// Converts a number from one number system to another.
    /// </summary>
    /// <param name="from">The source number system converter.</param>
    /// <param name="input">The string representation in the source system.</param>
    /// <param name="to">The target number system converter.</param>
    /// <returns>String representation in the target system.</returns>
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