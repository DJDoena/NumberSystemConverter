namespace DoenaSoft.NumberSystemConverter;

public sealed class InvalidInputException(string message)
    : Exception(message)
{
}