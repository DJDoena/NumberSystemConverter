namespace DoenaSoft.NumberSystemConverter;

/// <summary>
/// Interface for number system converters that convert between ulong values and string representations.
/// </summary>
public interface INumberSystemConverter
{
    /// <summary>
    /// Converts a number to its string representation in this number system.
    /// </summary>
    /// <param name="input">The number to convert.</param>
    /// <returns>String representation of the number.</returns>
    string FromULong(ulong input);

    /// <summary>
    /// Converts a string representation to a number.
    /// </summary>
    /// <param name="input">The string to convert.</param>
    /// <returns>The numeric value.</returns>
    ulong ToULong(string input);
}