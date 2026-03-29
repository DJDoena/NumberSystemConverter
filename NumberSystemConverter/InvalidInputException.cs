namespace DoenaSoft.NumberSystemConverter;

/// <summary>
/// Exception thrown when input to a converter is invalid for that number system.
/// </summary>
/// <param name="message">The error message.</param>
public sealed class InvalidInputException(string message)
    : Exception(message)
{
}